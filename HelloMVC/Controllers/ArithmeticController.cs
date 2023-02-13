using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers;

public class ArithmeticController : Controller
{
    public IActionResult MTable(int from,int to)
    {
        return View(( from,to));
    }
}
