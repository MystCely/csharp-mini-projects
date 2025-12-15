namespace OrganTransplant;

public class Hospital
{
    public List<Donor> Donors { get; set; }

    public Hospital(List<Donor> donors)
    {
        Donors = donors;
    }

    
    public void CheckDonorMatch(Patient patient, Donor donor)
    {
        if (donor.BloodType == patient.BloodType)
        {
            Console.WriteLine("\nIt's a match. The surgery was a success. Congrats!");
        } 
        else if (donor.BloodType == "O")
        {
            Console.WriteLine("\nThe donor's blood type is O. The surgery was a success. Congrats!");
        }
        else
        {
            Console.WriteLine("\nSorry, unfortunately it's not a match.\nBernt DIED.");
        }

    }
    
}