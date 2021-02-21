using System.ComponentModel.DataAnnotations;

namespace Forum.Models.ViewModels
{
    public class RegistrationViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Birth year")]
        public int Year { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Password length must be at least 6 symbols")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string PasswordConfirm { get; set; }

        [Display(Name = "Phone number")]
        [Phone]
        [MinLength(10, ErrorMessage = "Phone length must be at least 10 symbols")]
        [MaxLength(13, ErrorMessage = "Phone length must be not less than 13 symbols")]
        public string PhoneNumber { get; set; }
    }
}
