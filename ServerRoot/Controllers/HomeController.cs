
using Microsoft.AspNetCore.Mvc;

namespace ServerRoot
{

    [Route("/[action]")]
    public class HomeController : Controller
    {

        [Route("/")]
        public IActionResult Index() => View();
        public IActionResult Aboutme() => View();
        public IActionResult Contact() => View();
        public IActionResult Cv() => View();

    }
}