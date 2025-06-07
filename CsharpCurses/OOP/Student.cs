namespace OOP;

public class Student : People, IStudiable
{
    public TypeOfStudy TypeOfStudy { get; init; }
    public int StudyLevel { get; private set; }

    public Student(string fullName, TypeOfStudy typeOfStudy) : base(fullName)
    {
        TypeOfStudy = typeOfStudy;
    }

    public Student(string fullName) : base(fullName)
    {
        TypeOfStudy = TypeOfStudy.University;
    }

    public void Study()
    {
        Random random = new Random();
        StudyLevel = random.Next(1, 100);
    }

    public override void Eat()
    {
        Console.WriteLine("Eating Cafeteria");
    }

    public override void Walking()
    {
        Console.WriteLine("Walking and study lections");
    }

    public override string ToString()
    {
        //TODO: ВЕРНУТЬ СТРОКУ С ПОДРОБНЫМ ОПИСАНИЕМ О СТУДЕНТЕ
        return " ";
    }
}