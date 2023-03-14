namespace BaseControllerDi.Services
{
    public interface ITimeService
    {
        Task<DateTime> GetDateTimeNowAsync();
    }

    public class FakeTimeService : ITimeService
    {
        public Task<DateTime> GetDateTimeNowAsync()
        {
            return Task.FromResult(DateTime.Parse("2018-08-22T10:00:00Z"));
        }
    }

    public class LocalTimeService : ITimeService
    {
        public Task<DateTime> GetDateTimeNowAsync()
        {
            return Task.FromResult(DateTime.Now);
        }
    }
}
