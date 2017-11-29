using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Etrans.Authorization.Roles;
using Etrans.Authorization.Users;
using Etrans.MultiTenancy;

namespace Etrans.EntityFrameworkCore
{
    public class EtransDbContext : AbpZeroDbContext<Tenant, Role, User, EtransDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public EtransDbContext(DbContextOptions<EtransDbContext> options)
            : base(options)
        {
        }
    }
}
