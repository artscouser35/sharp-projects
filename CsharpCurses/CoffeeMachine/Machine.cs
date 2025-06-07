namespace CoffeeMachine;

public class Machine
{
    public int Id { get; set; }
    private int id;
    public string name;
    public int model;

    public Machine(int id, string name, int model)
    {
        Id = id;
        this.name = name;
        this.model = model;
    }

    public Machine(string name, int model)
    {
        this.name = name;
        this.model = model;
    }

    public void Launch()
    {
        string Work = "On";
        Console.Write(Work);
        
    }
}