using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MaAccount.Authorization.Roles;
using MaAccount.Authorization.Users;
using MaAccount.MultiTenancy;

namespace MaAccount.EntityFrameworkCore
{
    public class MaAccountDbContext : AbpZeroDbContext<Tenant, Role, User, MaAccountDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MaAccountDbContext(DbContextOptions<MaAccountDbContext> options)
            : base(options)
        {
        }
    }
}
