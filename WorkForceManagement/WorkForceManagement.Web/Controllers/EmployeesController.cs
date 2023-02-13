using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using WorkForceManagement.Web.Data;
using WorkForceManagement.Web.Enums;
using WorkForceManagement.Web.Models;

namespace WorkForceManagement.Web.Controllers;

public class EmployeesController : Controller
{
    WorkForceContext db = new WorkForceContext();

    public IActionResult Index()
    {
        List<Employee> employees = db.Employees.ToList();
        return View(employees);
    }
    [HttpGet]
    public IActionResult Create()
    {
        //return new RedirectToActionResult("Index", "Employees", new {id=5});
        return View();
    }

    [HttpPost]
    //[Route("/Employees/Create",Name ="StoreEmployee")]
    public IActionResult Create(Employee employee)
    {
        db.Employees.Add(employee);
        db.SaveChanges();
        //var incomingName = collection;
        
        return RedirectToAction("Index");
    }
    public IActionResult Detail(int id)
    {
        Employee emp = db.Employees.Find(id);
        return View(emp);
    }

    public IActionResult Edit(int id)
    {
        Employee emp = db.Employees.Find(id);
        return View(emp);
    }

    [HttpPost]
    public IActionResult Edit(Employee emp)
    {
        db.Employees.Update(emp);
        db.SaveChanges();
        return RedirectToAction("Detail",new {id = emp.Id});
    }
    [HttpPost]
    public IActionResult Delete(int id)
    {
        //Employee emp = db.Employees.Find(id);
        //db.Employees.Remove(emp);
        //db.SaveChanges();
        return StatusCode(200);
    }
    public IActionResult GetDataWithAdo()
    {
        List<Employee> employees = new List<Employee>();
        string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=WorkForce_Test;Integrated Security=true";

        string queryString = "SELECT * From dbo.Employees";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Create the Command and Parameter objects.
            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    employees.Add(new Employee()
                    {
                        Name = reader.GetString(1),
                        //Gender = reader.GetFieldValue<Gender>(2),
                        DateOfBirth = reader.GetDateTime(3),
                        Contact = reader.GetString(4)
                    }); 
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
        return View("Index",employees);
    }

    public IActionResult ThingsToLearnBeforeCourseCompletion()
    {
        return View("ToLearn");
    }
}
