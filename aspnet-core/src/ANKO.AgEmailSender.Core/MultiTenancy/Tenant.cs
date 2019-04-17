using Abp.MultiTenancy;
using ANKO.AgEmailSender.Authorization.Users;

namespace ANKO.AgEmailSender.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
