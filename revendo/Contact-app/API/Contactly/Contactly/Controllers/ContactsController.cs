using Microsoft.AspNetCore.Mvc;

namespace Contactly.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
