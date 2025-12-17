using System.ComponentModel.DataAnnotations;

namespace QrInfoApp.Models
{
    public class UserProfile
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string MobileNo { get; set; }

        [Required(ErrorMessage = "Experience is required")]
        [Range(0.0, 30.0, ErrorMessage = "Experience must be between 0 and 30 years")]
        public decimal ExperienceYears { get; set; }

        [Required(ErrorMessage = "Last company name is required")]
        public string LastCompany { get; set; }

        [Required(ErrorMessage = "Skills are required")]
        public string Skills { get; set; }
    }
}
