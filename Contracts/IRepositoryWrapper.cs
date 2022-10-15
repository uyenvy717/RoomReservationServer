using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IReservationRepository Reservation { get; }
        IRoomRepository Room { get; }
        IUserRepository User { get; }
        void Save();
    }
}
