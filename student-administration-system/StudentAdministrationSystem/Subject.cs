namespace StudentAdministrationSystem;

public class Subject
{
    public string Course { get; set; }
    public string CourseCode { get; set; }
    public int Credits { get; set; }
    
    
    public Subject(string course, string courseCode, int credits)
    {
        Course = course;
        CourseCode = courseCode;
        Credits = credits;
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"\nCourse: {Course}\nCourse Code: {CourseCode}\nTotal Credits: {Credits}");
    }
}