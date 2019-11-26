using Microsoft.AspNetCore.Antiforgery;
using TEST.Controllers;

namespace TEST.Web.Host.Controllers
{
    public class AntiForgeryController : TESTControllerBase
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
