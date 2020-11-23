using Soccer.Shared.FutDb;
using System.Threading.Tasks;

namespace Soccer.Server.FutDb
{
	public interface IFutService
	{
		Task<Leagues> GetLeagues();
		Task<Players> GetPlayer(int league, int limit = 20, int page = 0);
	}
}
