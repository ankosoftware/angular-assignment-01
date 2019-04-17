using Abp.AutoMapper;
using ANKO.AgEmailSender.Authentication.External;

namespace ANKO.AgEmailSender.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
