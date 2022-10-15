using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("reservation")]
    public class Reservation
    {
        public Guid IdReservation { get; set; }


        [Required(ErrorMessage = "Date created is required")]
        public DateTime CreatedAt { get; set; }


        public DateTime UpdatedAt { get; set; }


        [Required(ErrorMessage = "Date booking is required")]
        public DateOnly BookingAt { get; set; }


        [ForeignKey(nameof(User))]
        public Guid IdUser { get; set; }
        public User? User { get; set; }

        [ForeignKey(nameof(Room))]
        public Guid IdRoom { get; set; }
        public Room? Room { get; set; }
    }
}
