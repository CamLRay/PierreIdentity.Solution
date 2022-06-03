using Microsoft.AspNetCore.Mvc;


namespace PierreIdentity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
