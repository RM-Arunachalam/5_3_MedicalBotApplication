namespace ClassLibrary
{
    public class Patient
    {
        private string _name;
        private int _age;
        private string _gender;
        private string _medicalHistory;
        private string _symptomCode;
        private string _prescription;

        public bool SetName(string name, out string errorMessage)
        {
            errorMessage = "The name should not be null or empty. Patient name should contain at least two or more characters.";
            if (name != null && name != "" && name.Length > 1)
            {
                errorMessage = "";
                _name = name;
                return true;
            }
            return false;
        }
        public string GetName()
        {
            return _name;
        }

        public bool SetAge(int age, out string errorMessage)
        {
            errorMessage = "Patient age can't be negative.Patient age can't be greater than 100";
            if (age >= 0 && age <= 100)
            {
                errorMessage = "";
                _age = age;
                return true;
            }
            return false;

        }

        public int GetAge()
        {
            return _age;
        }


        public bool SetGender(string gender, out string errorMessage)
        {
            gender = gender.ToLower();
            errorMessage = "Patient gender should be either Male, Female or Other";
            if (gender == "male" || gender == "female" || gender == "other")
            {
                errorMessage = "";
                _gender = gender;
                return true;
            }
            return false;
        }

        public string GetGender()
        {
            return _gender;
        }


        public void SetMedicalHistory(string medicalHistory)
        {
            _medicalHistory = medicalHistory;
        }

        public string GetMedicalHistory()
        {
            return _medicalHistory;
        }


        public bool SetSymptomCode(string symptomCode, out string errorMessage)
        {
            symptomCode=symptomCode.ToUpper();
            errorMessage = "Symptom Code should either be S1, S2, or S3";
            if (symptomCode == "S1"|| symptomCode=="S2"|| symptomCode == "S3")
            {
                errorMessage = "";
                _symptomCode = symptomCode;
                return true;
            }
            return false ;
        }

 public  string GetSymptoms()
        {
             string symptonDesc = "unknown";
            if (_symptomCode == "S1")
                  symptonDesc= "headache";
            else if (_symptomCode == "S2")
                 symptonDesc =  "skin rashes";
            else if (_symptomCode == "S3")
                symptonDesc = "dizziness";
            return symptonDesc;

        }
             public void SetPrescription(string prescription)
        {
            _prescription = prescription;
        }

        public string GetPrescription()
        {
            return _prescription;
        }

    }
}
