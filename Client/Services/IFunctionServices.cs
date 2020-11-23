using Soccer.Shared.FutDb;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace Soccer.Client.Services
{
	public interface IFunctionServices
	{
		Task<Leagues> GetLeagues();
		Task<Players> GetPlayer(int league, int limit = 20, int page = 0);
	}

	public class FunctionServices : IFunctionServices
	{
		private readonly HttpClient client;

		public FunctionServices(HttpClient client)
		{
			this.client = client;
		}

		public async Task<Leagues> GetLeagues()
		{
			var response = await client.GetAsync("/api/leagues");
			var r = await response.Content.ReadAsStringAsync();
			return System.Text.Json.JsonSerializer.Deserialize<Leagues>(r);
            //var leagues = await client.GetFromJsonAsync<Leagues>("/api/leagues");
            //return leagues;
        }

		public async Task<Players> GetPlayer(int league, int limit = 20, int page = 0)
		{
			return await client.GetFromJsonAsync<Players>($"/api/players?league={league}&limit={limit}&page={page}");
		}
	}
}
