using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Creational_FactoryPattern_01
{
    /// <summary>
    /// Product Interface
    /// </summary>
    public interface IFactory
    {
        void Drive(int miles);
    }
}
