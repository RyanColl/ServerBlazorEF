using System.ComponentModel.DataAnnotations;

namespace ServerBlazorEF.Models
{
    public class Student
    {
        [Required]
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string School { get; set; }
    }
}