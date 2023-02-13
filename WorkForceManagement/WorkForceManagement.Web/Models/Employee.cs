using WorkForceManagement.Web.Enums;

namespace WorkForceManagement.Web.Models;

public class Employee
{
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public string? Address { get; set; } = string.Empty;
	public Gender Gender { get; set; } = Gender.Male;
	public DateTime DateOfBirth { get; set; }
	public string Contact { get; set; } = string.Empty;
	public DateTime JoinDate { get; set; } = DateTime.Now;
	public string Department { get; set; } = string.Empty;
	public string Designation { get; set; } = string.Empty;



}
