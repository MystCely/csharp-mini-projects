namespace StudentAdministrationSystem;

public class ConsoleApp
{
    public void Run()
    {
        var input = new Input();

        string name = input.AskForInfo("What is your name?");
        int age = Convert.ToInt32(input.AskForInfo("What is your age?"));
        int id = Convert.ToInt32(input.AskForInfo("What is your StudentID?"));
        string program = input.AskForInfo("What is your degree program?");

        string course = input.AskForInfo("What is your course?");
        string courseCode = input.AskForInfo("What is the course code?");
        int credits = Convert.ToInt32(input.AskForInfo("How many credits does the course have?"));

        string grade = input.AskForInfo($"What is your grade on {course}?");
        
        
        var student = new Student(name, age, id, program);
        var subject = new Subject(course, courseCode, credits);
        var grades = new Grades(student, subject, grade);
        student.PrintInfo();
        subject.PrintInfo();
        grades.PrintInfo();
    }
}