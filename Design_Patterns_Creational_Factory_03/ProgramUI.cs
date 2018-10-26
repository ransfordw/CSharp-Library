using System;

namespace Design_Patterns_Creational_Factory_03
{
    internal class ProgramUI
    {
        private NewPatientFactory _newSignUp = new NewPatientSignUp();
        private IPatient _newPatient;

        internal void Run()
        {
            _newPatient = _newSignUp.GetPatient(GetPatientName(), GetPatientAge(), GetPatientGender(), GetPatientDiabetesInfo());

            _newPatient.TakeMeds();
            _newPatient.TakeInsulin();
            _newPatient.VisitDoctor();

            Console.ReadLine();
        }

        #region Factory Resources

        //These methods retrieve parameters from the user to package and send to the factory.
        public string GetPatientName()
        {
            Console.Write("Enter patient name:");
            var name = Console.ReadLine();
            return name;
        }

        public int GetPatientAge()
        {
            Console.Write("Enter patient age:");
            var age = int.Parse(Console.ReadLine());
            return age;
        }

        public string GetPatientGender()
        {
            Console.Write("Enter patient gender (male/female):");
            var gender = Console.ReadLine();
            return gender;
        }

        public bool GetPatientDiabetesInfo()
        {
            bool isDiabetic;
            Console.WriteLine("Is the patient diabetic? y/n");
            var response = Console.ReadLine();
            if (response == "y" || response == "Y")
                isDiabetic = true;
            else
                isDiabetic = false;
            return isDiabetic;
        }
        #endregion
    }
}