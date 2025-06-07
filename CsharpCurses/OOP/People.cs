namespace OOP;

public class People : IPeople
{
    public string FullName { get; protected set; }
    public required int Age { get; init;}
    public required string Sex { get; init;}

    public People(string fullName)
    {
        FullName = fullName;
    }
    public void Married(string firstName)
    {
        string[] partsOfName = FullName.Split();
        partsOfName[0] = firstName;
        FullName = string.Join(" ", partsOfName);
    }


    public virtual void Eat()
    {
        Console.WriteLine("eating");
    }

    public virtual void Walking()
    {
        Console.WriteLine("Walking");
    }
}