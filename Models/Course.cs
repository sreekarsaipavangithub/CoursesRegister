using System.ComponentModel.DataAnnotations;

namespace Login_Register_App.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Display(Name = "Course Name")]
        public string courseName { get; set; }

        [Display(Name = "Course Duration(days)")]
        public int courseDuration { get; set; }

        [Display(Name = "Instructor name")]
        public string instructor { get; set; }

        [Display(Name = "Cost(Rs.)")]
        public int cost { get; set; }
    }
}
