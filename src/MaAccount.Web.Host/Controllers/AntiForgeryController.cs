using Microsoft.AspNetCore.Antiforgery;
using MaAccount.Controllers;

namespace MaAccount.Web.Host.Controllers
{
    public class AntiForgeryController : MaAccountControllerBase
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
