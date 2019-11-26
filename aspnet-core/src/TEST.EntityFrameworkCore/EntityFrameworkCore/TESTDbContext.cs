using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TEST.Authorization.Roles;
using TEST.Authorization.Users;
using TEST.MultiTenancy;

namespace TEST.EntityFrameworkCore
{
    public class TESTDbContext : AbpZeroDbContext<Tenant, Role, User, TESTDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TESTDbContext(DbContextOptions<TESTDbContext> options)
            : base(options)
        {
        }
    }
}
