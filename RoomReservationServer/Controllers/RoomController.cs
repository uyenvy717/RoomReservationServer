using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace RoomReservationServer.Controllers
{
    [Route("api/room")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        public RoomController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllRooms()
        {
            try
            {
                var rooms = _repository.Room.GetAllRooms();
                _logger.LogInfo($"Returned all rooms from database.");
                return Ok(rooms);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllRooms action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
