namespace OOP;

public interface IPeople : IEatable, IWalkingable
{
    void Married(string firstName);
    public string FullName { get; }
    public  int Age { get; init; }
    public string Sex { get; init; }
}