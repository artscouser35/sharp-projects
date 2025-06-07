namespace OOP.RocketStation;

public class Soyuz : Rocket
{
    public Soyuz() : base(800, "Союз")
    {
        
    }

    public override void Check()
    {
        Console.WriteLine("Проверка системы");
    }

    public override void Start()
    {
        Console.WriteLine("Стартуй");
    }

    public override void Stop()
    {
        Console.WriteLine("Остановись");
    }
}