using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace model.Data.Models
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int EventId { get; set; }
        public virtual Event Event { get; set; }

        [Required]
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
