using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_03
{
    class PatientTypeTwo : IPatient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool IsDiabetic { get; set; }

        public void TakeInsulin()
        {
            if (IsDiabetic)
                Console.WriteLine("Patient takes insulin.");
            else
                Console.WriteLine("Patient does not need insulin.");
        }

        public void TakeMeds()
        {
            Console.WriteLine("The patient takes their prescribed medication.");
        }

        public void VisitDoctor()
        {
            Console.WriteLine("The patient visits their family doctor.");
        }
    }
}
