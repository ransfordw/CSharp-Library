using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_01
{
    /* An interface that defines actions that the receiver can perform */
    public interface ISwitchable
    {
        void PowerOn();
        void PowerOff();
    }
}
