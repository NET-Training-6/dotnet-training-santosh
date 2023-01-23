class CollectionLearner
{
    //List of something
    public void LearnLists()
    {
        List<int> myList = new List<int>() { 1, 45, 778, 99, 8, 75, 88, 55, 8, 5, 566, 5, 887 };
        myList.Add(12);
        myList.Add(18);
        myList.Add(16);
        myList.Add(02);
        myList.Add(09);
        myList.Add(555);
        myList.Remove(09);

        foreach (int num in myList)
        {
            Console.WriteLine(num);
        }
    }

    public void AddNamesToList()
    {
        List<string> listOfNames = new List<string>() { "Rajan", "Santosh", "Badri", "Bishnu", "Sudip", "Krishna", "Bhim", "Sudarshan", "Dipendra", "Birendra" };
        foreach (string name in listOfNames)
        {
            if (name.Length < 5)
                Console.WriteLine(name.ToUpper());
        }
    }

    public void Assignment1()
    {
        List<int> numbers = new List<int>() { 10, 15, 30, 14, 17, 19, 21, 60, 45, 87 };
        foreach (int number in numbers)
        {
            if (number % 3 == 0 && number % 5 == 0)
                Console.WriteLine(number);
        }
    }

    public void Assignment2()

    {
        List<DateTime> listOfDateOfBirths = new List<DateTime>() {
            DateTime.Now,
            DateTime.Now.AddDays(15),
            DateTime.Now.AddDays(18),
            DateTime.Now.AddDays(86),
            DateTime.Now.AddDays(29),
            DateTime.Now.AddDays(17),
            DateTime.Now.AddDays(105),
            DateTime.Now.AddDays(73),
            DateTime.Now.AddDays(45),
            DateTime.Now.AddDays(41),
            DateTime.Now.AddDays(28),
            DateTime.Now.AddDays(31)
        };

        listOfDateOfBirths.Sort();
        foreach (var dob in listOfDateOfBirths)
        {
            Console.WriteLine(dob.ToString("MMMM dd, yyyy"));
        }


    }

    public void LearnDictionary()
    {
        Dictionary<string, byte> people = new();
        people.Add("Santosh", 25);
        people.Add("Janak", 38);
        people.Add("Tirtha", 34);
        people.Add("Tigre", 24);
        people.Add("Bhime", 34);
        people.Add("Prakash", 45);
        people.Add("Janak1", 65);
        people.Add("Bam", 18);
        people.Add("Bhoj", 48);

        foreach (var person in people)
        {
            Console.WriteLine($"{person.Key} => {person.Value}");
        }

    }

    public void TupleList()
    {
        //(string country, long population, long area) = ("Nepal",3_00_00_000,141_000);
        List<(string country, long population, long area)> countries = new();
        countries.Add(("Nepal", 3_00_00_000, 141_000));
        countries.Add(("India", 300_00_00_000, 45_141_000));
        countries.Add(("China", 800_00_00_000, 48_141_000));
        countries.Add(("Indonesia", 1_05_00_000, 79_141_000));
        countries.Add(("USA", 45_00_00_000, 105_141_000));

        foreach (var country in countries)
        {
            Console.WriteLine($"Country : {country.country} \nPopulation : {country.population} \nArea : {country.area}\n\n");
        }


    }
}