using System.Linq;
using System.Reflection;
using Eventures.Data;
using Eventures.Data.Seeding;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Eventures.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void UseDbSeeding(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                Assembly.GetAssembly(typeof(EventuresDbContext))
                    .GetTypes()
                    .Where(type => typeof(ISeeder).IsAssignableFrom(type))
                    .Where(type => type.IsClass)
                    .Select(type => (ISeeder)serviceScope.ServiceProvider.GetRequiredService(type))
                    .ToList()
                    .ForEach( seeder =>  seeder.Seed());

                //using (var context = serviceScope.ServiceProvider.GetRequiredService<EventuresDbContext>())
                //{
                //    context.Database.EnsureCreated();
                //}
            }
        }
    }
}