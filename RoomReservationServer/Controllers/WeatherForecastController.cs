using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace RoomReservationServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //private readonly ILoggerManager _logger;
        //public WeatherForecastController(ILoggerManager logger)
        //{
        //    _logger = logger;
        //}
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    _logger.LogInfo("Here is info message from the controller.");
        //    _logger.LogDebug("Here is debug message from the controller.");
        //    _logger.LogWarn("Here is warn message from the controller.");
        //    _logger.LogError("Here is error message from the controller.");
        //    return new string[] { "value1", "value2" };
        //}

        private IRepositoryWrapper _repository;
        public WeatherForecastController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //var domesticAccounts = _repository.Account.FindByCondition(x => x.AccountType.Equals("Domestic"));
            //var owners = _repository.Owner.FindAll();
            return new string[] { "value1", "value2" };
        }
    }
}