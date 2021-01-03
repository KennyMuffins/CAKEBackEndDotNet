using System.ComponentModel.DataAnnotations;

namespace Cake.Dtos
{
    public class UserCreateDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string DisplayName { get; set; }

        [Required]
        public string MobileNumber { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string ProfilePicUrl { get; set; }
    }
}