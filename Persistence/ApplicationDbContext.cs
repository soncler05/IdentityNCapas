using Microsoft.AspNet.Identity.EntityFramework;
using Models;

namespace Persistence
{
    //TODO: checar <TUser>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    //public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
