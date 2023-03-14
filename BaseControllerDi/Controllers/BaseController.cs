using BaseControllerDi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BaseControllerDi.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly IHelloService _helloService;
        protected readonly ITimeService _timeService;

        public BaseController(IHelloService helloService, ITimeService timeService)
        {
            _helloService = helloService;
            _timeService = timeService;
        }
    }
}
