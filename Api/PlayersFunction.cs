using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Soccer.Server.FutDb;

namespace Soccer.Server
{
    public class PlayersFunction
    {
        private readonly IFutService futService;

        public PlayersFunction(IFutService futService)
        {
            this.futService = futService;
        }

        [FunctionName("Players")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            int league = int.Parse(req.Query["league"]);
            int limit;
            int page;
            if (!int.TryParse(req.Query["limit"], out limit))
                limit = 20;
            if (!int.TryParse(req.Query["page"], out page))
                page = 0;

            var players = await futService.GetPlayer(league, limit, page);
            
            return new OkObjectResult(System.Text.Json.JsonSerializer.Serialize(players));
        }
    }
}
