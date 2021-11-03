using Microsoft.AspNetCore.Mvc;

namespace LojaSapatoKhalai.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}