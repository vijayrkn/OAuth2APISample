using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TestWebAPI
{
    public class UserDBContext: IdentityDbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
                
        }
    }
}
