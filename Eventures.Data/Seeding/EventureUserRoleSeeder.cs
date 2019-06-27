using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;

namespace Eventures.Data.Seeding
{
    public class EventureUserRoleSeeder : ISeeder
    {
        private readonly EventuresDbContext context;

        public EventureUserRoleSeeder(EventuresDbContext context)
        {
            this.context = context;
        }
        
        public void Seed()
        {
            if (context.Roles.Any() == false)
            {
                context.Roles.Add(new IdentityRole()
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                });
                context.Roles.Add(new IdentityRole()
                {
                    Name = "User",
                    NormalizedName = "USER"
                });
            }

            context.SaveChanges();
        }
    }
}