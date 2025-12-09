namespace StudentAdministrationSystem;

public class ConsoleApp
{
    public void Run()
    {
        // Subject List
        var subjects = new List<Subject>
        {
            // Law Subjects
            new Subject("Introduction to Law", "LAW1001", 10),
            new Subject("Contract Law", "LAW1304", 12),
            new Subject("Criminal Law", "LAW1203", 18),
            // CS Subjects
            new Subject("Introduction to Programming", "CS1001", 10),
            new Subject("Data Structures and Algorithms", "CS2002", 15),
            new Subject("Database Systems", "CS2201", 20),
            
        };

        var student1Subjects = new List<Subject>
        {
            subjects[0], subjects[1], subjects[2]
        };

        var student2Subjects = new List<Subject>
        {
            subjects[3], subjects[4], subjects[5]
        };
        
        
        // Student 1
        var student1 = new Student("Lyra", 20, 9875, "Law", 
            student1Subjects, new List<Grades>
            {
                new Grades(subjects[0], "B"),
                new Grades(subjects[1], "C"),
                new Grades(subjects[2], "A"),
            });
        
        // Student 2
        var student2 = new Student("Mae", 22, 9568, "Computer Science", 
            student2Subjects, new List<Grades>
            {
                new Grades(subjects[3], "A"),
                new Grades(subjects[4], "C"),
                new Grades(subjects[5], "A")
            });
        
        
        // Print Student 1 info
        Console.WriteLine("\n=== Student 1 ===");
        
        student1.PrintInfo();
        
        foreach (var studentGrade in student1.Grades)
        {
            studentGrade.PrintInfo();
        }

        double avg1 = student1.CalculateAvgGrade();
        int credits1 = student1.CalculateTotalCredits();
        
        Console.WriteLine($"\nAverage Grade: {avg1:F1}");
        Console.WriteLine($"Total Credits: {credits1}");

        
        // Print Student 2 info
        Console.WriteLine("\n=== Student 2 ===");

        student2.PrintInfo();
        
        foreach (var studentGrade in student2.Grades)
        {
            studentGrade.PrintInfo();
        }
        
        double avg2 = student2.CalculateAvgGrade();
        int credits2 = student2.CalculateTotalCredits();
        
        Console.WriteLine($"\nAverage Grade: {avg2:F1}");
        Console.WriteLine($"Total Credits: {credits2}");
    }
}