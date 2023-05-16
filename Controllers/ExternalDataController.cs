using Microsoft.AspNetCore.Mvc;

namespace ShoppingWithAPI.Controllers
{
    public class ExternalDataController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }
    }
}
