using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Creational_Factory_03
{
   public interface IPatient
    {
        string Name { get; set; }
        int Age { get; set; }
        string Gender { get; set; }
        bool IsDiabetic { get; set; }

        void TakeMeds();
        void TakeInsulin();
        void VisitDoctor();
    }
}
