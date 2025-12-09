namespace StudentAdministrationSystem;

public class Grades
{
    public Subject Subject { get; set; }
    public string Grade { get; set; }

    public Grades(Subject subject, string grade)
    {
        Subject = subject;
        Grade = grade;

    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"\nCourse Name: {Subject.Course}\nGrade: {Grade}");
    }
}