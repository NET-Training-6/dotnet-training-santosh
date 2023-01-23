public class MethodLearner
{
    //Method That returns nothing and takes no argument(s)
    public void Print()
    {
        Console.WriteLine("Hello There");
        Console.WriteLine("Hello there from anther Console.WriteLine");
    }

    //Method that returns nothing but takes some arguments
    public void PrintMessage(string message)
    {
        Console.WriteLine("Hello There");
        Console.WriteLine(message);
    }

    //Method that returns sum and takes two parameters
    public double Add(double A, double B)
    {
        double sum = A + B;
        return sum;
    }

    public bool isNumberEven(int number)
    {
        //Learn Bitwise Operator
        return (number & 1) == 0;
        //Ternary Operator
        //return number % 2 == 0 ? true : false;

    }
    public double CalculateAverage(int num1, int num2, int num3)
    {
        double sum = num1 + num2 + num3;
        double average = sum / 3;
        return average;
    }
    public double CalculateAverage(double[] numbers)
    {
        double totalSum = 0;
        foreach (double number in numbers)
        {
            totalSum = totalSum + number;
        }
        double average = totalSum / numbers.Length;
        return average;
    }
    public double CalculateAverage(params int[] numbers)
    {
        double totalSum = 0;
        foreach (double number in numbers)
        {
            totalSum = totalSum + number;
        }
        double average = totalSum / numbers.Length;
        return average;
    }

    public int FindMinimum(params int[] numbers)
    {
        var minimumNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number < minimumNumber)
            {
                minimumNumber = number;
            }
        }
        return minimumNumber;
    }

    public (int, int) GetSumAndProduct(byte n1, byte n2)
    {
        var sum = n1 + n2;
        var product = n1 * n2;
        return (sum, product);
    }

}

