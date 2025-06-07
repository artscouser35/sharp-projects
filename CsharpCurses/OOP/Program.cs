namespace OOP;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Vanya")
        {
            TypeOfStudy = TypeOfStudy.University,
            Sex = "Male",
            Age = 20
        };
        
        Console.WriteLine($"{student.FullName} {student.Age} {student.TypeOfStudy.ToString()}");
        student.Study();
        Console.WriteLine(student.StudyLevel);
        student.Study();
        Console.WriteLine(student.StudyLevel);
        student.Study();
        Console.WriteLine(student.StudyLevel);
        
        student.Eat();
        student.Walking();
    }
}