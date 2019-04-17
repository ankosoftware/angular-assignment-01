using System.Collections.Generic;

namespace ANKO.AgEmailSender.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
