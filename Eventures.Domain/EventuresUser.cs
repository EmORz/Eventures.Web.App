using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Identity;

namespace Eventures.Domain
{
    public class EventuresUser : IdentityUser 
    {
        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        public string LastName { get; set; }

        [Required]
        [RegularExpression("^[0-9]{10}$")]
        public string UCN { get; set; }

    }
}