namespace StudentAdministrationSystem;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int StudentId { get; set; }
    public string DegreeProgram { get; set; }
    public List<Subject> Subjects { get; set; } = new List<Subject>();
    public List<Grades> Grades { get; set; } = new List<Grades>();


    public Student(string name, int age, int studentId, string degreeProgram)
    {
        Name = name;
        Age = age;
        StudentId = studentId;
        DegreeProgram = degreeProgram;
    }
    
    public Student(string name, int age, int studentId, string degreeProgram, List<Subject> subjects, List<Grades> grades)
    {
        Name = name;
        Age = age;
        StudentId = studentId;
        DegreeProgram = degreeProgram;
        Subjects = subjects;
        Grades = grades;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"\nName: {Name}\nAge: {Age}\nID: {StudentId}\nProgram: {DegreeProgram}");
    }


    private int ConvertGradeToNum(string grade)
    {
        switch (grade)
        {
            case "A":
                return 5;
            case "B":
                return 4;
            case "C":
                return 3;
            case "D":
                return 2;
            case "E":
                return 1;
            case "F":
                return 0;
            default:
                return 0;
        }
    }

    public double CalculateAvgGrade()
    {
        double sum = 0;
        foreach (var grade in Grades)
        {
            int number = ConvertGradeToNum(grade.Grade);
            sum += number;
        }

        double averageGrade = sum / Grades.Count;
        return averageGrade;
    }

    public int CalculateTotalCredits()
    {
        int total = 0;
        foreach (var subject in Subjects)
        {
            total += subject.Credits;
        }
        return total;
    }
}