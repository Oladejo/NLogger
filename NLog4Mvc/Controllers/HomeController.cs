using NLog;
using System;
using System.Web.Mvc;

namespace NLog4Mvc.Controllers
{
    public class HomeController : Controller
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            try
            {
                int x = 0;
                int y = 5;
                int z = y / x;
            }
            catch (Exception ex)
            {
                logger.ErrorException("Error occured in Home controller Index Action", ex);
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}