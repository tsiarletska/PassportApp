using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PassportsApp.Controllers
{
    [Authorize]
    public class PassportTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
