namespace OOP.RocketStation;

public abstract class Rocket: IRocket
{
    public abstract void Check();
    public abstract void Start();
    public abstract void Stop();

    public int Power { get; }
    public string Name { get; }

    public Rocket(int power, string name)
    {
        Power = power;
        Name = name;
    }
}