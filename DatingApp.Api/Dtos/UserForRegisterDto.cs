using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.Api.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify a password between 4 and 8 characters")]
        public string Password { get; set; }

        public string Gender { get; set; }
        public string KnownAs { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastActive { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}