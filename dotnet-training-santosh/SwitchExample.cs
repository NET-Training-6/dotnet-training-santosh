class SwitchExample
{
    //Ask user to enter his total percentage and greet him
    //if his total marks is grater than less than 60%, print You passed with second division
    //if his total marks is grater than 60% and less than 80%, print You passed with first division
    //if his total marks is grater than 80%, print You passed with distinction

    void EnterPercentage()
    {
        Console.Write("Enter Your Percentage : ");
        float percentage = float.Parse(Console.ReadLine());

    }
}