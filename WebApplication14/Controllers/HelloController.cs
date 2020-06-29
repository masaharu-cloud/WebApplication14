using Microsoft.AspNetCore.Mvc;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class HelloController : Controller
    {

        private readonly MyContext _context;
        public HelloController(MyContext context)
        {
            this._context = context;
        }
        public IActionResult List()
        {
            return View(this._context.Book);
        }


        public IActionResult Index()
        {
            ViewBag.Message = "これはIndexだよ！！！！";
            return View();
        }

        public IActionResult Greet()
        {
            ViewBag.Message = "こんにちは！世界！";
            return View();

        }
    }
}
