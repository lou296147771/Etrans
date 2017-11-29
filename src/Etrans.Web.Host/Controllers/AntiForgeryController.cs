using Microsoft.AspNetCore.Antiforgery;
using Etrans.Controllers;

namespace Etrans.Web.Host.Controllers
{
    public class AntiForgeryController : EtransControllerBase
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
