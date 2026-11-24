using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementAPI.Models.Entity
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public Guid StudentId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(15)]
        [Phone]
        [Column(TypeName = "nvarchar(15)")]
        public string Phone { get; set; } = string.Empty;

        [Required]
        public int Age { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string Course { get; set; } = string.Empty;

        [MaxLength(250)]
        [Column(TypeName = "nvarchar(250)")]
        public string? Address { get; set; }
    }
}
