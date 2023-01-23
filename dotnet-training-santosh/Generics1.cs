
//class Generic<T> We can define class like this too

class Generic
{
    //When we have similar functionality but the argument data type is different, Generic comes handy
    //<T>
    public void Print<T>(T message)
    {
        Console.WriteLine(message);
    }
    //Using the Print<T> we do not need to define other functions with string, double, float or int argument data type
    public void Print(string message)
    {
        Console.WriteLine(message);
    }

    public void Print(double message)
    {
        Console.WriteLine(message);
    }

    public void Print(float message)
    {
        Console.WriteLine(message);
    }

    public void Print(DateTime message)
    {
        Console.WriteLine(message);
    }

    public void TestGeneric()
    {
        Print<string>("Hello World");
        Print<double>(3.21668);
        Print<int>(51);
        Print<bool>(false);
        Print<DateTime>(DateTime.Now);
        Print<Paragraph>(new Paragraph());

    }
}

class Generic1<T>
{
    public void Print(T message)
    {
        Console.WriteLine(message);
    }

    public void Test()
    {
        //
    }

}