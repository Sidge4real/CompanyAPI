using Microsoft.AspNetCore.Mvc;

namespace CompanyAPI.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok(new { Message = "Welcome to CompanyAPI" });
        }
    }
}
