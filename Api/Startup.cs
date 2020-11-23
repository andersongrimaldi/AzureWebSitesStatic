using Soccer.Server.FutDb;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

[assembly: FunctionsStartup(typeof(Soccer.Server.Startup))]
namespace Soccer.Server
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient("FutDb", httpConfig => {
                httpConfig.BaseAddress = new Uri("https://futdb.app/api/");
                string futDbApiKey = builder.GetContext().Configuration["FutDb-ApiKey"];
                httpConfig.DefaultRequestHeaders.Add("X-AUTH-TOKEN", futDbApiKey);
            });
            builder.Services.AddMemoryCache();
            builder.Services.AddSingleton<IFutService, FutServices>();
        }
    }
}
