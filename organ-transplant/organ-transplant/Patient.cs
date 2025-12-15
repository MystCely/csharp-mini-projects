namespace OrganTransplant;

public class Patient
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string BloodType { get; set; }

    public Patient()
    {
        Name = "Bernt";
        Age = 45;
        Gender = "Male";
        BloodType = "B";
    }

    public void PrintPatientInfo()
    {
        Console.WriteLine($"\nPatient Information:\nName: {Name}\nAge: {Age}\nGender: {Gender}\nBlood type: {BloodType}");
        Console.WriteLine("\n========");
    }

}

