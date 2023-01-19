// Language INtegrated Query - LINQ
// Way / Technique to query collections

//ADO.NET - Database Query 
using System.Linq;

class LinqTutorial
{
    int[] numbers = { 2, 3, 4, 9, 1000, 980, 78, 45, 74, 36, 63, 47, 96, 100 };
    string[] names = { "Santosh", "Rajan", "Sudip", "Kiran", "Tigre", "Apar", "Arpan", "avishek" };

    List<Employee> employees = new(){
            new Employee(){Name = "Santosh Poudel", Age = 21,Department="HR",Designation= "Software Engineer" },
            new Employee(){Name = "Rajan", Age = 38,Department="HR",Designation= "Software Engineer" },
            new Employee(){Name = "Bam", Age = 21,Department="R&D",Designation= "Engineer" },
            new Employee(){Name = "Avishek", Age = 34,Department="R&D",Designation= "QA" },
            new Employee(){Name = "Bikrant", Age = 18,Department="IT",Designation= "Network Engineer" },
            new Employee(){Name = "Sudip", Age = 35,Department="IT",Designation= "Network Engineer" },
            new Employee(){Name = "Santosh", Age = 65,Department="HR",Designation= "QA" },
        };
    public void EvenNumbers()
    {
        Console.WriteLine("\nPrinting all odd numbers");
        //Get all numbers in "numbers"
        //Imperative Way
        List<int> evenNumbers = new();
        foreach (var num in numbers)
        {
            if (num % 2 == 0)
            {
                evenNumbers.Add(num);
            }
        }
        //At this point "evenNumbers" has only even number in it

        //How to do the samething with LINQ
        //Declarative Way
        var evenNums = numbers.Where(num => num % 2 == 0);

        // Alternate syntax 
        evenNums = from num in numbers where num % 2 == 0 select num;
        foreach (var num in evenNums)
        {
            Console.WriteLine(num);
        }

    }

    public void GetAllOddNumbers()
    {
        Console.WriteLine("\nPrinting all odd numbers");
        var oddNums = numbers.Where(num => num % 2 != 0);
        //Alternative syntax similar to sql
        oddNums = from num in numbers where num % 2 != 0 select num;
        PrintNumbers(oddNums);
    }

    public void GetNumberEndsWithZero()
    {
        Console.WriteLine("\nPrinting all numbers that ends with 0");
        var nums = numbers.Where(num => num % 10 == 0);
        PrintNumbers(nums);
    }

    //Projections
    //Get squares of all numbers in "numbers" array
    public void SquareNumbers()
    {
        Console.WriteLine("\nCreating Squares of Each numbers");
        var nums = numbers.Select(num => num * num);
        PrintNumbers(nums);
    }

    public void GetSquareOfNumbersGraterThan50()
    {
        Console.WriteLine("\nPrinting the squares of numbers grater than 50");
        var nums = numbers.Where(x => x > 50).Select(num => num * num);
        PrintNumbers(nums);
    }

    public void PrintNumbers(IEnumerable<int> nums)
    {
        foreach (var num in nums)
        {
            Console.WriteLine(num);
        }
    }

    public void FilterName()
    {
        Console.WriteLine("\nFiltering names which starts with A");
        var namesWithA = names.Where(name => name.StartsWith("A", StringComparison.CurrentCultureIgnoreCase));
        foreach (var name in namesWithA)
        {
            Console.WriteLine(name);
        }
    }

    //. Get all person names with less than 4 characters and convert them to uppercase

    public void Assignment()
    {
        List<Country> countries = new()
        {
            new Country(name: "Nepal",continent:"Asia",area:21115.45,gdp:4500),
            new Country(name : "India",continent : "Asia",area : 17823783.23,gdp : 155478),
            new Country(name : "China",continent : "Asia",area : 9817823783.23,gdp : 125548),
            new Country(name : "Africa",continent : "Africa",area : 458165.23,gdp : 125547),
            new Country(name : "Indonesia",continent : "Europe",area : 7895462165.23,gdp : 110000),
            new Country(name : "Iran",continent : "Europe",area : 85216479.23,gdp : 122598),
            new Country(name : "Iraq",continent : "Asia",area : 12549877899.23,gdp : 125447),
            new Country(name : "Afghanistan",continent : "Asia",area : 1255879444.23,gdp : 9500),
            new Country(name : "Siria",continent : "Africa",area : 2265554778899.23,gdp : 965587),
            new Country(name : "Korea",continent : "Asia",area : 1222544888.23,gdp : 125587),
            new Country(name : "Thiland",continent : "Asia",area : 12226699774455.23,gdp : 1255879),
            new Country(name : "Australia",continent : "Australia",area : 9817823783.23,gdp : 7895547),
            new Country(name : "United States",continent : "South Ameria",area : 78555549955.23,gdp : 336698554)
        };

        //Sorting countries by area
        var countriesByArea = countries.OrderBy(country => country.area);
        //Expression syntax
        countriesByArea = from country in countries orderby country.area select country;
        foreach (var country in countriesByArea)
        {
            Console.WriteLine($"Country : {country.name}, Area : {country.area.ToString("N0")} ");
        }

        //sorting countries by their gdp
        var countriesByGDP = countries.OrderBy(country => country.gdp);
        //Expression syntax 
        countriesByGDP = from country in countries orderby country.gdp select country;
        Console.WriteLine("\n\n");
        foreach (var country in countriesByGDP)
        {
            Console.WriteLine($"Country : {country.name}, GDP : {country.gdp.ToString("N0")} ");
        }

    }

    public void LinqDay2()
    {
        //1. Find if "numbers" array contain any even number
        var hasEven = numbers.Any(num => num % 2 == 0);

        // 2. Find if "numbers" array has all even numbers
        var allEven = numbers.All(num => num % 2 == 0);

        //3. Get first 5 elements from numbers 
        var firstFive = numbers.Take(5);

        //4. Get 5 elements skipping first 2 from "numbers"
        var skipTwo = numbers.Skip(2).Take(5);





    }

    public void LearnToQueryComplexCollection()
    {
        //1. Get all employees in HR Department
        var employeesInHr = employees.Where(emp => emp.Department == "HR");

        //2. Get employees in HR Department
        var employeesNamesInHrDepartment = employees.Where(emp => emp.Department == "HR").Select(employee => employee.Name);
        //alternative syntax - expression syntax
        employeesNamesInHrDepartment = from emp in employees where emp.Department == "HR" select emp.Name;
        //3. Get all software engineers under age of 12
        var softwareEngineersUnderAge12 = employees.Where(employee => employee.Designation == "Software Engineer" && employee.Age < 22);
        foreach (var employee in softwareEngineersUnderAge12)
        {
            Console.WriteLine(employee.Name + employee.Age.ToString());
        }
    }
}

class Country
{
    public string name;
    public string continent;
    public double area;
    public double gdp;

    public Country(string name, string continent, double area, double gdp)
    {
        this.name = name;
        this.continent = continent;
        this.area = area;
        this.gdp = gdp;

    }

}

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
    public string Designation { get; set; }

}