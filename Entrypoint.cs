using Basics;

class Entrypoint
{
    static void Main()
    {
        MethodLearner ml = new();
        // ml.Print();
        // ml.Print();

        // ml.PrintMessage("Print some message with parameter");
        // ml.PrintMessage("Print another message with argument");

        // var sum = ml.Add(5.4, 3.2);
        // Console.WriteLine(sum);

        // sum = ml.Add(3.8, 5.9);
        // Console.WriteLine(sum);

        // bool isArgumentEven = ml.isNumberEven(5);

        // ml.isNumberEven(6);
        // var avg = ml.CalculateAverage(num1: 1, num3: 2, num2: 3);
        // double[] numbersArray = { 15.8889, 21.98, 38.6, 4, 15.8 };
        // var average = ml.CalculateAverage(numbersArray);
        // Console.WriteLine(average);
        // var minimum = ml.FindMinimum(12, 15, 3, 4, 1, 8, 48, 49, -18);
        // Console.WriteLine($"Minimum Number is {minimum}");

        // var (sum, product) = ml.GetSumAndProduct(12, 15);

        // Room room1 = new Room();
        // room1.UpdateOwner("Rajan");

        // Room room2 = new Room(roomId: 5, roomBookedBy: "Santosh");
        // room2.startDateTime = DateTime.Now.AddDays(3);
        // room1.endDateTime = DateTime.Now.AddDays(5);

        // Console.WriteLine(room2.PrintMessage());


        // Rectangle rect = new Rectangle(4.2, 5.6);
        // rect.Area();
        // rect.Perimeter();
        // rect.PrintDetails();

        // Square square = new Square(side: 5.9);
        // square.Area();
        // square.Perimeter();
        // square.PrintDetails();

        // Triangle triangle = new Triangle(3, 4, 5);
        // triangle.Area();
        // triangle.Perimeter();
        // triangle.PrintDetails();

        // Dell dell = new("Dell G5", "Black");
        // dell.PrintInfo();
        // MSI msi = new("MSI GE 63 Raider", "Silver");
        // msi.PrintInfo();

        string address = "Tinkune, Kathmandu-Nepal";
        var arr = address.Split(new string[] { ",", " ", "-" }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"Locality : {arr[0]} City : {arr[1]},Country : {arr[2]}");

        string news = "Ukraine has said that Kramatorsk and Kherson were shelled head of the unilateral Russian Christmas ceasefire on Friday. Russian President Vladimir Putin ordered a 36-hour unilateral ceasefire in Ukraine from Friday until Saturday but the move was rejected by Kyiv and dismissed as hypocrisy. The US has also expressed skepticism about Putin’s intentions.";
        string[] sentenceDelimeter = new string[] { ".", "?" };
        string[] wordsDelimeter = new string[] { " " };
        string[] charactersDelimeter = new string[] { ",", " ", ".", "?", "-", "'" };
        var sentences = news.Split(sentenceDelimeter, StringSplitOptions.RemoveEmptyEntries);
        var words = news.Split(wordsDelimeter, StringSplitOptions.RemoveEmptyEntries);
        var characters = news.Split(charactersDelimeter, StringSplitOptions.RemoveEmptyEntries);
        var noOfCharacters = 0;
        foreach (var sentence in sentences)
        {
            Console.WriteLine(sentence);
        }

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }

        string skipCharacters = " '.,\"*-";
        foreach (var stringItem in news)
        {
            if (skipCharacters.Contains(stringItem) == false)
            {
                Console.Write(stringItem);
                noOfCharacters++;
            }

        }


        Console.WriteLine($"\n\nNo of Sentences : {sentences.Length}, No of words : {words.Length}, No of characters : {noOfCharacters}");


    }
}