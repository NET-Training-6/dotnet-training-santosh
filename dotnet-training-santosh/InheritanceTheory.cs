class A
{
    public int x;
}

class B : A //Single Inheritance, A is base class and B is derived/child/sub
{
    public string y;
}

class C : B // Multi-level Inheritance
{
    public float z;

    void Test()
    {

    }
}

interface IMinterface //Interface generally starts with I such as ICommand, IList, ICollection
{

}
//Multiple Inheritance
class E : B, IMinterface  //Class E inherits B and implements IMinterface
{

}