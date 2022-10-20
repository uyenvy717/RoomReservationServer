using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("room")]
    public class Room
    {
        private Guid _id;
        [Key]
        public Guid IdRoom { get { return _id; } }


        [Required(ErrorMessage = "Number is required")]
        public int Number { get; set; }


        [Required(ErrorMessage = "Floor is required")]
        [StringLength(45, ErrorMessage = "Floor cannot be longer than 45 characters")]
        public string? Floor { get; set; }


        [StringLength(100, ErrorMessage = "Description cannot be longer than 100 characters")]
        public string? Description { get; set; }


        public ICollection<Reservation>? Reservations { get; set; }
    }
}
