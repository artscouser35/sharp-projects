namespace OOP.RocketStation;

public class FalconS : Rocket
{
    public FalconS() : base(1500, "FalconS")
    {
        
    }

    public override void Check()
    {
        Console.WriteLine("Checked");
    }

    public override void Start()
    {
        Console.WriteLine("Start");
    }

    public override void Stop()
    {
        Console.WriteLine("Stop");
    }
}