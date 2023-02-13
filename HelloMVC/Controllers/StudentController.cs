using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Name="Santosh Poudel",Email="santosraj38@gmail.com",Address="Koteshwor",Dob=DateTime.Now,Gender=Sex.Male }); ;
            students.Add(new Student() { Name="Sudip Nepal",Email="sudip@gmail.com",Address="Pepsi Cola",Dob=DateTime.Now,Gender=Sex.Male }); ;
            students.Add(new Student() { Name="Apar baral",Email="apar@gmail.com",Address="kalanki",Dob=DateTime.Now,Gender=Sex.Male }); ;
            students.Add(new Student() { Name="Kapil Bhattarai",Email="kapil@gmail.com",Address="Naikap",Dob=DateTime.Now,Gender=Sex.Male }); ;
            students.Add(new Student() { Name="Aakritee ",Email="akritee@gmail.com",Address="Jadibuti",Dob=DateTime.Now,Gender=Sex.Female }); ;
            
            return View(students);
        }

        public IActionResult Test()
        {
            string[] names = { "Santosh Poudel", "Sudip Nepal", "Apar Baral", "Yadav Ghorashainee", "Pujan Bhattarai","Test" };
            return View(names);
        }
    }
}
