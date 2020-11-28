using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Soccer.Server
{
    public static class RoutingFunctions
    {
        [FunctionName("reader")]
        public static async Task<IActionResult> RunReader(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            return new OkObjectResult("reader");
        }

        [FunctionName("anonymous")]
        public static async Task<IActionResult> RunAnonymous(
           [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
           ILogger log)
        {
            return new OkObjectResult("anonymous");
        }

        [FunctionName("superheroes")]
        public static async Task<IActionResult> RunSuperheroes(
           [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
           ILogger log)
        {
            return new OkObjectResult("superheroes");
        }

        [FunctionName("superheroesgithub")]
        public static async Task<IActionResult> RunSuperheroesgithub(
           [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
           ILogger log)
        {
            return new OkObjectResult("superheroesgithub");
        }
    }
}
