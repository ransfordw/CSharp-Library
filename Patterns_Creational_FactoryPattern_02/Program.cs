using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Creational_FactoryPattern_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new ConcreteBird();

            IAves cuckoo = bird.GetAves("Cuckoo");
            IAves crow = bird.GetAves("Crow");
            IAves chickadee = bird.GetAves("Chickadee");
            
            cuckoo.Call("Cuck-oo");
            crow.Call("Caw caw caw");
            chickadee.Call("Chicka-dee-dee-dee");

            Console.ReadLine();
        }
    }
}
