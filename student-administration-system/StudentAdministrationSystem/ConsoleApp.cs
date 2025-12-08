namespace StudentAdministrationSystem;

public class ConsoleApp
{
    public void Run()
    {
        // Subject List
        var subjects = new List<Subject>();
        
        // Law Subjects
        subjects.Add(new Subject("Introduction to Law", "LAW1001", 10));
        subjects.Add(new Subject("Contract Law", "LAW1304", 12));
        subjects.Add(new Subject("Criminal Law", "LAW1203", 18));
        // CS Subjects
        subjects.Add(new Subject("Introduction to Programming", "CS1001", 10));
        subjects.Add(new Subject("Data Structures and Algorithms", "CS2002", 15));
        subjects.Add(new Subject("Database Systems", "CS2201", 20));
        
        // Student 1
        var student1 = new Student("Lyra", 20, 9875, "Law");
        var gradesLaw1 = new Grades(student1, subjects[0], "B");
        var gradesLaw2 = new Grades(student1, subjects[1], "C");
        var gradesLaw3 = new Grades(student1, subjects[2], "A");
        
        // Student 2
        var student2 = new Student("Mae", 22, 9568, "Computer Science");
        var gradesCs1 = new Grades(student2, subjects[3], "A");
        var gradesCs2 = new Grades(student2, subjects[4], "C");
        var gradesCs3 = new Grades(student2, subjects[5], "A");
        
        // Adding subjects to student1
        student1.Subjects.Add(subjects[0]);
        student1.Subjects.Add(subjects[1]);
        student1.Subjects.Add(subjects[2]);
        
        student2.Subjects.Add(subjects[3]);
        student2.Subjects.Add(subjects[4]);
        student2.Subjects.Add(subjects[5]);
        
        // Store student grade
        student1.Grades.Add(gradesLaw1);
        student1.Grades.Add(gradesLaw2);
        student1.Grades.Add(gradesLaw3);
        
        student2.Grades.Add(gradesCs1);
        student2.Grades.Add(gradesCs2);
        student2.Grades.Add(gradesCs3);
        
        
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