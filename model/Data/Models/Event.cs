using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace model.Data.Models
{
    public class Event
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(64, MinimumLength = 2, ErrorMessage = "Event name cannot be longer than 64 letters")]
        public string Name { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "Event description cannot be longer than 255 letters")]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string ImgUrl { get; set; }
        public string GetImage()
        {
            if (!string.IsNullOrEmpty(ImgUrl))
            {
                return ImgUrl;
            }
            else
            {
                return "https://images.pexels.com/photos/2608517/pexels-photo-2608517.jpeg?cs=srgb&dl=pexels-matheus-bertelli-2608517.jpg&fm=jpg";
            }
        }

    }
}
