using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementMVC.Models;

public class AddEmployeeDto
{
    [Required, StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required, EmailAddress, StringLength(100)]
    public string Email { get; set; } = string.Empty;

    [Phone, StringLength(15)]
    public string? Phone { get; set; }

    [Range(typeof(decimal), "0", "9999999999999999.99")]
    public decimal Salary { get; set; }
}