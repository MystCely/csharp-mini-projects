namespace OrganTransplant;

public class ConsoleApp
{
    public void Run()
    {
        Console.WriteLine("ORGAN TRANSPLANT GAME");
        Console.WriteLine("Save Bernt by finding the correct donor in time! Press P to play.");

        var key = Console.ReadKey(true);

        if (key.Key == ConsoleKey.P)
        {
            var input = new Input();
        
            var patient = new Patient();
        
            var donors = new List<Donor>
            {
                new Donor("Selena", 23, "Female", "A"),
                new Donor("Felix", 34, "Male", "AB"),
                new Donor("Alex", 27, "Male", "B"),
                new Donor("Diana", 32, "Female", "O"),
            };

            var hospital = new Hospital(donors);
        
            // Print Patient
            patient.PrintPatientInfo();
        
            // print Donor List
            for (int i = 0; i < donors.Count; i++)
            {
                int donorNumber = i + 1;
                Console.WriteLine($"\nDONOR NUMBER: {donorNumber}");
                donors[i].PrintDonorInfo();
            }
        
            int chosenDonor = Convert.ToInt32(input.AskForInput("\nPlease choose a donor that matches the patient to save him!"));
            int index = chosenDonor - 1;
        
            Donor selectedDonor = donors[index];
        
            hospital.CheckDonorMatch(patient, selectedDonor);
        }
        else
        {
            Console.WriteLine("You didn't press P. Please run the program to try again.");
        }
        
    }
}