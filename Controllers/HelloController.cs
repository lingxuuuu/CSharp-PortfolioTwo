using Microsoft.AspNetCore.Mvc;
    namespace portfolio_two.Controllers
    {
        public class HelloController : Controller
        {
            [HttpGet("")]
            public IActionResult Index()
            {
              return View();
            }
            [HttpGet("projects")]
            public IActionResult Projects()
            {
              return View();
            }
            [HttpGet("contact")]
            public IActionResult Contact()
            {
              return View();
            }
            [HttpPost("redirect")]
            public IActionResult Redirect()
            {
              return RedirectToAction("Index");
            }
        }
    }