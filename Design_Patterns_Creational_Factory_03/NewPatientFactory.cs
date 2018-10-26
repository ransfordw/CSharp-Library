using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_03
{
    public abstract class NewPatientFactory
    {
        public abstract IPatient GetPatient(string name, int age, string gender, bool isDiabetic);
    }
}
