using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using kns.fms.Authorization.Roles;
using kns.fms.Authorization.Users;
using kns.fms.MultiTenancy;

namespace kns.fms.EntityFrameworkCore
{
    public class fmsDbContext : AbpZeroDbContext<Tenant, Role, User, fmsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public fmsDbContext(DbContextOptions<fmsDbContext> options)
            : base(options)
        {
        }
    }
}
