namespace Basics;

public class Animal
{
    public string animalName = "";
    public int noOfLegs;
    public bool isDomenstic;

    public Animal()//Default Constructor
    {

    }

    public Animal(string name, bool trueFalse)
    {
        animalName = name;
        isDomenstic = trueFalse;
    }

}

class Test
{
    void test1()
    {
        Animal animal1 = new Animal("Dog", true);
        Animal animal2 = new();
    }
}