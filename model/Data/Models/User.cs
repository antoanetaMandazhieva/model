
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace model.Data.Models
{
    public class User : IdentityUser
    {
        //public User()
        //{
        //    Tickets = new List<Ticket>();
        //}
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
