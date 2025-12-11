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
        
        
        // Print Student Info
        var students = new List<Student> {student1, student2};
        foreach (var student in students)
        {
            student.PrintInfo();

            foreach (var studentGrade in student.Grades)
            {
                studentGrade.PrintInfo();
            }

            double avg = student.CalculateAvgGrade();
            int credits = student.CalculateTotalCredits();
            
            Console.WriteLine($"\nAverage Grade: {avg:F1}");
            Console.WriteLine($"Total Credits: {credits}");
        }
        
    }
}