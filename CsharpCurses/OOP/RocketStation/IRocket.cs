namespace OOP.RocketStation;

public interface IRocket: ICheckable, IStartable, IStopable
{
    int Power { get; }
    string Name { get; }
}