namespace StudentAdministrationSystem;

public class Grades
{
    public Student Student { get; set; }
    public Subject Subject { get; set; }
    public string Grade { get; set; }

    public Grades(Student student, Subject subject, string grade)
    {
        Student = student;
        Subject = subject;
        Grade = grade;

    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"\nName: {Student.Name}\nCourse Name: {Subject.Course}\nGrade: {Grade}");
    }
}