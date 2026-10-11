using Microsoft.AspNetCore.Mvc;

namespace BookTracker_.Controllers
{
    public class NewBookController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> Create()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }
        //}
    }
}
