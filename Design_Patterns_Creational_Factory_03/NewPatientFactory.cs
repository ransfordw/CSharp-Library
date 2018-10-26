using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_03
{
    //This is the Factory. It takes in the parameters from the user to give back a new Concrete Product, in this case a patient.

    //Think of the parameters as being the raw materials that the factory requires to produce.

    public abstract class NewPatientFactory
    {
        public abstract IPatient GetPatient(string name, int age, string gender, bool isDiabetic);
    }
}
