using Microsoft.AspNetCore.Mvc;

namespace lojaSapato.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}