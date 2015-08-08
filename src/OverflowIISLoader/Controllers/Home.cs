using Microsoft.AspNet.Mvc;

namespace OverflowIISLoader.Controllers
{
    public class Home : Controller
    {
        private readonly OverflowManager _overflowManager;

        public Home(OverflowManager overflowManager)
        {
            _overflowManager = overflowManager;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Overflow")]
        public IActionResult Overflow()
        {
            _overflowManager.CreateStackOverflow();
            return View();
        }
    }
}