namespace ClassLibrary
{
    public class MedicalBot
    {
        public const string botName = "Bob";

        public static string GetBotName()
        {
            return botName;
        }

        public void PrescribeMedication(Patient patient)
        {
            if (patient.GetSymptoms() == "headache")
                patient.SetPrescription("ibuprofen"+" "+GetDosage("ibuprofen"));
            else if (patient.GetSymptoms() == "skin rashes")
                patient.SetPrescription("diphenhydramine" + " " + GetDosage("diphenhydramine"));
            else if (patient.GetSymptoms() == "dizziness")
            {
                if (patient.GetMedicalHistory().Contains("Diabetes"))
                    patient.SetPrescription("metformin" + " " + GetDosage("metformin"));
                else
                    patient.SetPrescription("dimenhydrinate" + " " + GetDosage("dimenhydrinate"));
            }

            string GetDosage(string medicineName)//local function
            {
                string dosage="0 mg";
                if (medicineName == "ibuprofen")
                    dosage= patient.GetAge() < 18 ? "400 mg" : "800 mg";
                else if (medicineName == "diphenhydramine")
                    dosage = patient.GetAge() < 18 ? "50 mg" : "300 mg";
                else if (medicineName == "dimenhydrinate")
                    dosage = patient.GetAge() < 18 ? "50 mg" : "400 mg";
                else if (medicineName == "metformin") dosage = "500 mg";
                return dosage;
            }
        }
    }
}
