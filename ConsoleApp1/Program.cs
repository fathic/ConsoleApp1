using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laboratoire Re1 = new Laboratoire("RE1.");
            Switcheur SWW1 = new Switcheur(745, "SWW1", 8, "192.168.12.0");
            Switcheur SWW2 = new Switcheur(845, "SWW2", 16, "192.168.12.1");
            Re1.LSwitcheur.Add(SWW1);
            Re1.LSwitcheur.Add(SWW2);

            Routeur R1 = new Routeur(99887, "R1", 8, 5);
            Routeur R2 = new Routeur(66777, "R2", 16, 3);
            Re1.LRouteur.Add(R1);
            Re1.LRouteur.Add(R2);

            Re1.Print();

        }
    }
}
