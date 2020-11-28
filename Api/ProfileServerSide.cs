using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;
using System.Security.Claims;

namespace Soccer.Server
{
    public static class ProfileServerSide
    {
        [FunctionName("ProfileServerSide")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            var principal = UserHelpers.UserHelper.Parse(req);
            if(principal.Identity != null)
                return new OkObjectResult(new { 
                    Name = principal.Identity.Name
                });
            return new OkObjectResult(new { Name = "Non autenticato" });
        }
    }
}
