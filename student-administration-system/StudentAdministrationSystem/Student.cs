namespace StudentAdministrationSystem;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int StudentId { get; set; }
    public string DegreeProgram { get; set; }

    public Student(string name, int age, int studentId, string degreeProgram)
    {
        Name = name;
        Age = age;
        StudentId = studentId;
        DegreeProgram = degreeProgram;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"\n\nName: {Name}\nAge: {Age}\nID: {StudentId}\nProgram: {DegreeProgram}");
    }
}