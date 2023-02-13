using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WorkForceManagement.Web.Enums;

namespace WorkForceManagement.Web.Models;

public class Employee
{
	public int Id { get; set; }

	[Required(ErrorMessage ="Please enter your name")]
	[MinLength(2,ErrorMessage ="Name must be at least 2 letters.")]
	[MaxLength(50,ErrorMessage ="Name must be less than 50 letters.")]
	[RegularExpression("[A-Za-z]+")]
	public string Name { get; set; } = string.Empty;
	public string? Address { get; set; } = string.Empty;
	public Gender Gender { get; set; } = Gender.Male;

	[DisplayName("Date Of Birth")]
	[DataType(DataType.Date)]
	public DateTime DateOfBirth { get; set; }
	public string Contact { get; set; } = string.Empty;
	[DisplayName("Join Date")]
	[DataType(DataType.Date)]
	public DateTime JoinDate { get; set; } = DateTime.Now;
	public string Department { get; set; } = string.Empty;
	public string Designation { get; set; } = string.Empty;



}
