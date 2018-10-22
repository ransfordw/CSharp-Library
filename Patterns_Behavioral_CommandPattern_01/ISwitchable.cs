using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Behavioral_CommandPattern_01
{
    /* An interface that defines actions that the receiver can perform */
    public interface ISwitchable
    {
        void PowerOn();
        void PowerOff();
    }
}
