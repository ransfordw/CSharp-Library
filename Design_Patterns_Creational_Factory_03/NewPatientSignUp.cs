using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_03
{
    public class NewPatientSignUp : NewPatientFactory
    {
        public override IPatient GetPatient(string name, int age, string gender, bool isDiabetic)
        {
            if (age < 18)
                return new PatientTypeOne
                {
                    Name = name,
                    Age = age,
                    Gender = gender,
                    IsDiabetic = isDiabetic,
                };
            else if (age >= 18 && age <= 65)
                return new PatientTypeTwo
                {
                    Name = name,
                    Age = age,
                    Gender = gender,
                    IsDiabetic = isDiabetic,
                };
            else
                return new PatientTypeThree
                {
                    Name = name,
                    Age = age,
                    Gender = gender,
                    IsDiabetic = isDiabetic,
                };
        }
    }
}
