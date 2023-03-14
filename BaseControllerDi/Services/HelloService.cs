namespace BaseControllerDi.Services
{

    public interface IHelloService
    {
        string SayHello();
    }
    public class HelloService : IHelloService
    {
        int _helloCount = 0;

        public string SayHello()
        {
            _helloCount++;

            return $"Hello {_helloCount}";
        }
    }
}
