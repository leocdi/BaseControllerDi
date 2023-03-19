using BaseControllerDi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace BaseControllerDi.Controllers
{

    public abstract class BaseController<T> : Controller where T : BaseController<T>
    {
        //https://learn.microsoft.com/en-us/aspnet/core/fundamentals/http-context?view=aspnetcore-7.0


        private IHelloService? _helloService;
        protected IHelloService HelloService => _helloService ??= HttpContext.RequestServices.GetRequiredService<IHelloService>();
        
        private ITimeService? _timeService;
        protected ITimeService TimeService => _timeService ??= HttpContext.RequestServices.GetRequiredService<ITimeService>();

        private ILogger<T>? _logger;
        protected ILogger<T> Logger => _logger ??= HttpContext.RequestServices.GetService<ILogger<T>>(); //GetService peut renvoyer null d'ou le warning...
    }
}
