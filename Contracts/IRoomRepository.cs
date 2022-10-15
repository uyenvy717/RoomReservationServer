using Entities.Models;

namespace Contracts
{
    public interface IRoomRepository : IRepositoryBase<Room>
    {
        IEnumerable<Room> GetAllRooms();
    }
}