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

/* Абстрактный класс кофе, который будет родителем для разного вида кофе и который будет иметь абстрактные поля
 Методы:
 формирования заказа PlaceAnOrder(), расчет заказа Price(), возможность купить(наличие ингредиентов) CheckedIngredient(), Выдача или не выдача кофе IsAccepted()
 Интерфейс: 
 ICoffee - интерефейс будет содержать все методы.
 Поля:
 название Name(Латте, Эспрессо, Американо) размер Size(S, M, l), добавки(сахар, сироп, молоко), прайс кофе Price
 Свойства:
 количество воды Water{get;set}, количество сиропа Syrup{get;set}, количество молока Milk{get;set}, количество зёрен Beans{get; set;} */
