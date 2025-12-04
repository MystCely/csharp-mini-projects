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


        var student1 = new Student("Lyra", 20, 9875, "Law");
        var subject1 = new Subject("Criminal Law", "LAW1203", 15);
        var grades1 = new Grades(student1, subject1, "B");
        
        var student2 = new Student(name, age, id, program);
        var subject2 = new Subject(course, courseCode, credits);
        var grades2 = new Grades(student2, subject2, grade);
        
        student1.PrintInfo();
        subject1.PrintInfo();
        grades1.PrintInfo();
        
        student2.PrintInfo();
        subject2.PrintInfo();
        grades2.PrintInfo();
    }
}