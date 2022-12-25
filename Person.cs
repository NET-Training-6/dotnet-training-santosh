namespace Basics;

class Person
{
    //Members : Methods and fields/properties
    //Access Modifiers : public, private, internal, protected
    public string name;
    public byte age; //byte,short,int,long integral types
    string address;
    float height;
    float weight;
    DateTime dateOfBirth;

    void CalculateBMI()
    {
        double bmi = weight / (Math.Pow(height, 2));
        Console.WriteLine("Calculating BMI of person");
    }
}