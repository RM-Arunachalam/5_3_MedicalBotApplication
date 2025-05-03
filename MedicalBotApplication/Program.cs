using ClassLibrary;

class Medbot
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hi, I'm "+MedicalBot.botName+". I'm here to help you in your medication.\nEnter your (patient) details:");
        Patient p = new Patient();

        Console.Write("Enter Patient Name: ");
        while (!p.SetName(Console.ReadLine(), out string NameErrormsg))
        {
            Console.Write(NameErrormsg);
            Console.Write("\nEnter Patient Name: ");
        }
  
        Console.Write("Enter Patient Age: ");
        while (!p.SetAge(int.Parse(Console.ReadLine()), out string AgeErrormsg))
        {
            Console.Write(AgeErrormsg);
            Console.Write("\nEnter Patient Age: "); 
        }

        Console.Write("Enter Patient Gender: ");
        while(!p.SetGender(Console.ReadLine(), out string GenderErrorMsg))
        {
            Console.Write(GenderErrorMsg);
            Console.Write("\nEnter Patient Gender: ");
        }
        Console.Write("Enter Medical History. Eg: Diabetes. Press Enter for None:");
        p.SetMedicalHistory(Console.ReadLine());
        Console.Write("Welcome " + p.GetName() + "," + p.GetAge());
        Console.Write("\nWhich of the following symptoms do you have:\nS1. Headache\nS2. Skin rashes\nS3. Dizziness\nEnter the symptom code from above list (S1, S2 or S3):");

        while(!  p.SetSymptomCode(Console.ReadLine(), out string symptonCodeErrMsg)) { 
            Console.Write(symptonCodeErrMsg);
            Console.Write("\nWhich of the following symptoms do you have:\nS1. Headache\nS2. Skin rashes\nS3. Dizziness\nEnter the symptom code from above list (S1, S2 or S3):");
        }

        MedicalBot mb = new MedicalBot();
        mb.PrescribeMedication(p);
        Console.WriteLine("\nYour prescription based on your age, symptoms and medical history:");
        System.Console.WriteLine(p.GetPrescription());
       
        System.Console.WriteLine("\nThank you");
    }
}
