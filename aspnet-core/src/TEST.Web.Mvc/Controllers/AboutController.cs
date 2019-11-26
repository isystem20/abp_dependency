using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TEST.Controllers;

namespace TEST.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : TESTControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
