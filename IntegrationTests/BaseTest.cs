using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Presentation;
using Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace IntegrationTests
{
    public class BaseTest
    {
        protected readonly HttpClient TestClient;

        protected BaseTest()
        {
            var appFactory = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(builder =>
                    {
                        builder.ConfigureServices(services =>
                        {
                            services.RemoveAll(typeof(MedyCorpDbContext));
                            services.AddDbContext<MedyCorpDbContext>(options =>
                                options.UseInMemoryDatabase("TestDb"));
                        });
                    });
            
            TestClient = appFactory.CreateClient();
        }
    }
}
