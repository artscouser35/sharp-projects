namespace CoffeeMachine;

class Program
{
    static void Main(string[] args)
    {
        Machine machine = new Machine(1,"LG",100);
        Console.WriteLine(machine.Id);
        machine.Launch();
        machine.Id = 12;
        Machine ultraMachine = new Machine("Samsung", 200);
        ultraMachine.Launch();
    }
}