class Car
{
    string vendor;
    string category;
    double price;
    const byte noOfWheels = 4; //Compile Time  // Constants are by default static
    readonly byte noOfGears = 6; //Runtime
    static byte seats = 4;
    public Car()
    {

    }

    void Test()
    {
        Car car1 = new();
        car1.vendor = "TaTa";

        Car.seats = 5; //Similar to Console.WriteLine("Directly Accessed through Console Class");
    }

}


//static
/*
Access Modifiers :
public - Highest visibility, jo le pani pauxa yo public defined class lai
internal - 
private,
 protected
 Learn About Project Referencing
*/