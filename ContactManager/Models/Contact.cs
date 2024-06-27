using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactManager.Models
{
    [Table("Contact")]
    public class Contact
    {
        [Key]
        public Guid Id { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [RegularExpression(@"^[A-Za-z]*$", ErrorMessage = "First Name must contain only letters")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [RegularExpression(@"^[A-Za-z]*$", ErrorMessage = "Last Name must contain only letters")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number is required")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Phone Number must contain only numbers")]
        public string? PhoneNumber { get; set; }
       
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is required")]
        public string? CountryName { get; set; }

        public string? Address { get; set; }
    }
}
