using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.Extensions.Caching.Memory;
using Soccer.Shared.FutDb;

namespace Soccer.Server.FutDb
{
	public class FutServices : IFutService
	{
		private readonly HttpClient client;
		private readonly IMemoryCache memoryCache;
		private const string LeaguesKey = "Leagues";
		public FutServices(IHttpClientFactory httpClientFactory, IMemoryCache memoryCache)
		{
			client = httpClientFactory.CreateClient("FutDb");
			this.memoryCache = memoryCache;
		}

		public async Task<Leagues> GetLeagues()
		{
			Leagues leagues = memoryCache.Get<Leagues>("Leagues");
			if (leagues != null)
				return leagues;
			else
			{
				leagues = await client.GetFromJsonAsync<Leagues>("/api/leagues?page=1&limit=100");
				foreach (var l in leagues.LeagueList)
				{
					l.Image = await client.GetByteArrayAsync($"/api/leagues/{l.Id}/image");
				}
				memoryCache.Set("Leagues", leagues);
			}
			return leagues;
		}

		public async Task<Players> GetPlayer(int league, int limit = 20, int page = 0)
		{
			Players players;
			string playerListCacheKey = $"Player-{league}-limit{20}-page{page}";
			if (memoryCache.TryGetValue(playerListCacheKey, out players))
				return players;

			var leagueFilter = new PlayersRequest { League = league };
			var playersMessages = await client.PostAsJsonAsync<PlayersRequest>($"/api/players?page={page}&limit={limit}", leagueFilter);
			if (!playersMessages.IsSuccessStatusCode)
				throw new InvalidOperationException(await playersMessages.Content.ReadAsStringAsync());
			else
			{
				var playersString = await playersMessages.Content.ReadAsStringAsync();
				players = JsonSerializer.Deserialize<Players>(playersString);
				memoryCache.Set(playerListCacheKey, players);
				foreach (var l in players.PlayerList)
				{
					byte[] image;
					string playerId = $"Player-{l.Id}";
					if (!memoryCache.TryGetValue(playerId, out image))
					{
						image = await client.GetByteArrayAsync($"/api/players/{l.Id}/image");
						memoryCache.Set(playerId, image);
					}
					l.Image = image;
				}
				return players;
			}
		}
	}
}
