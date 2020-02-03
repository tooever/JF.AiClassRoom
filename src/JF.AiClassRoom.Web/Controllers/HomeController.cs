using Microsoft.AspNetCore.Mvc;

namespace JF.AiClassRoom.Web.Controllers
{
    public class HomeController : AiClassRoomControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}