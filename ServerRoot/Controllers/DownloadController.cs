
using Microsoft.AspNetCore.Mvc;

namespace ServerRoot
{

    public class DownloadController : Controller
    {
        [Route("/download/WorldSkills-Standard")]
        public IActionResult DownloadWorldSkills() => File ("/Assets/Files/WSC2019_WSSS19_Industrial_Control-1.pdf", "application/pdf", "WSC2019_WSSS19_Industrial_Control-1.pdf");

    }
}