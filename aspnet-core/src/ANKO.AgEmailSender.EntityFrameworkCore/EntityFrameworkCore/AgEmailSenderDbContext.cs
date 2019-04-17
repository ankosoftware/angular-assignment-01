using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ANKO.AgEmailSender.Authorization.Roles;
using ANKO.AgEmailSender.Authorization.Users;
using ANKO.AgEmailSender.MultiTenancy;

namespace ANKO.AgEmailSender.EntityFrameworkCore
{
    public class AgEmailSenderDbContext : AbpZeroDbContext<Tenant, Role, User, AgEmailSenderDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AgEmailSenderDbContext(DbContextOptions<AgEmailSenderDbContext> options)
            : base(options)
        {
        }
    }
}
