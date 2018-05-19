using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Routeur
    {
        public int _reference;
        public string _hostName;
        public int _nbInterface;
        public int _nbIntSeria;

        public Routeur(int reference, string hostname, int nbInterface, int nbIntSerial)
        {
            _reference = reference;
            _hostName = hostname;
            _nbInterface = nbInterface;
            _nbIntSeria = nbIntSerial;
        }

        public void Print()
        {
            Console.WriteLine("Routeur " + _reference.ToString() +
                              " : Hostname = " + _hostName +
                              " - Nombre interface FA : " + _nbInterface +
                              " - Nombre interface Serial = " + _nbIntSeria);
        }
    }
}
