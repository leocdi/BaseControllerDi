using BaseControllerDi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace BaseControllerDi.Controllers
{

    public abstract class BaseController<T> : Controller where T : BaseController<T>
    {
        private IHelloService? _helloService;
        protected IHelloService HelloService => _helloService ??= HttpContext.RequestServices.GetRequiredService<IHelloService>();
        
        private ITimeService? _timeService;
        protected ITimeService TimeService => _timeService ??= HttpContext.RequestServices.GetRequiredService<ITimeService>();

        private ILogger<T>? _logger;
        protected ILogger<T> Logger => _logger ??= HttpContext.RequestServices.GetService<ILogger<T>>(); //GetService peux renvoyer null d'ou le warning...
    }
}
