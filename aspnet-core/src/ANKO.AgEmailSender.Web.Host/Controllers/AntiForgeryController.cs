using Microsoft.AspNetCore.Antiforgery;
using ANKO.AgEmailSender.Controllers;

namespace ANKO.AgEmailSender.Web.Host.Controllers
{
    public class AntiForgeryController : AgEmailSenderControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
