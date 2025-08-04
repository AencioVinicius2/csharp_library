using Microsoft.AspNetCore.Mvc;

namespace StudentPortal.Web.Controllers
{
    public class StudentsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add()
        {

        }
    }
}
