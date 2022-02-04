using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TacoCatMVC.Helper;
using TacoCatMVC.Models;


namespace TacoCatMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TacoApp()
        {
            TacoAppModel tacoAppModel = new TacoAppModel();


            return View(tacoAppModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TacoApp(TacoAppModel model)
        {
            string userInput = model.UserInput!.ToLower();


            PalHelper helper = new();
            model = helper.GetResult(userInput);

            return View(model);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}