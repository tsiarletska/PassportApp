using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PassportsApp.Controllers
{
    [Authorize]
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
