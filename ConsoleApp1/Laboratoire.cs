using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{


    class Laboratoire
    {

        private String _laboratoireName;
        public List<Switcheur> LSwitcheur;
        public List<Routeur> LRouteur;


        public Laboratoire(String laboratoireName)
        {
            _laboratoireName = laboratoireName;
            LSwitcheur = new List<Switcheur>();
            LRouteur = new List<Routeur>();

        }

        public void Print()
        {
            Console.WriteLine("Nom laboratoire = " + _laboratoireName);
            foreach(Switcheur sw in LSwitcheur)
            {
                sw.Print();
            }
            foreach (Routeur rt in LRouteur)
            {
                rt.Print();
            }
        }
    }



}
