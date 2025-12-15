namespace OrganTransplant;

public class Donor
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string BloodType { get; set; }

    public Donor(string name, int age, string gender, string bloodType)
    {
        Name = name;
        Age = age;
        Gender = gender;
        BloodType = bloodType;
    }

    public void PrintDonorInfo()
    {
        Console.WriteLine($"Name: {Name}\nAge: {Age}\nGender: {Gender}\nBlood Type: {BloodType}");
    }
}