class Entrypoint
{
    static void Main()
    {
        // Console.WriteLine("Inside Console");

        // //Number Types
        // int a = 100000; //The int data type can store whole numbers from -2147483648 to 2147483647.
        // Console.WriteLine(a);

        // long b = 15000000000L; //The long data type can store whole numbers from -9223372036854775808 to 9223372036854775807.
        // Console.WriteLine(b);

        // float c = 5.75F; //Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
        // Console.WriteLine(c);

        // double d = 19.99D;//Stores fractional numbers.Sufficient for storing 15 decimal digits
        // Console.WriteLine(d);

        // //Scientific Numbers
        // float f1 = 35e3F;
        // double d1 = 12E4D;
        // Console.WriteLine(f1);
        // Console.WriteLine(d1);

        // //Boolean 
        // bool isCSharpFun = true;
        // bool isFishTasty = false;
        // Console.WriteLine(isCSharpFun);   // Outputs True
        // Console.WriteLine(isFishTasty);   // Outputs False
        // Console.WriteLine("Please Enter a Number : ");
        // var input = Console.ReadLine();

        // int number = int.Parse(input);

        // if (number % 2 == 0)
        // {
        //     Console.WriteLine(number + " is Even");
        // }
        // else
        // {
        //     Console.WriteLine(number + " is Odd");
        // }
        Console.WriteLine("Please Enter Principal : ");
        var princial = int.Parse(Console.ReadLine());

        Console.WriteLine("Please Enter Time in years : ");
        var time = int.Parse(Console.ReadLine());

        Console.WriteLine("Please Enter Rate : ");
        var rate = int.Parse(Console.ReadLine());

        var interest = (princial * time * rate) / 100;

        Console.WriteLine("The intrest for the provided values  is : " + interest);
        Console.WriteLine("Press any key to exit");
        Console.ReadLine();
    }
}