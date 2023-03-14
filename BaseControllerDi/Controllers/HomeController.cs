using BaseControllerDi.Models;
using BaseControllerDi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BaseControllerDi.Controllers
{
    public class HomeController : BaseController<HomeController>
    {


        public async Task<IActionResult> Index()
        {
            var helloMsg = HelloService.SayHello();
            var dateTimeNow = await TimeService.GetDateTimeNowAsync();
            Logger.LogInformation("Index call {time} {message}", dateTimeNow, helloMsg);


            return View(new HomeIndexViewModel() { Message = $"{helloMsg} {dateTimeNow}" });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}