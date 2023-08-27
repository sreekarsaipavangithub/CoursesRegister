using System.ComponentModel.DataAnnotations;

namespace Login_Register_App.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Username")]
        [DataType(DataType.EmailAddress)]
        public string userName { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string phNumber { get; set; }
    }
}
