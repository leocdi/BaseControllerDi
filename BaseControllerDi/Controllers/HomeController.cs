using BaseControllerDi.Models;
using BaseControllerDi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BaseControllerDi.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(
            ILogger<HomeController> logger,
            IHelloService helloService,
            ITimeService timeService)
            : base(helloService, timeService)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var helloMsg = _helloService.SayHello();
            var dateTimeNow = await _timeService.GetDateTimeNowAsync();
            _logger.LogInformation("Index call {time} {message}", dateTimeNow, helloMsg);


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