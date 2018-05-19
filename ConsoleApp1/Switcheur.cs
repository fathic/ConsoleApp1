using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Switcheur
    {
        public int _reference;
        public string  _hostName;
        public int _nbInterface;
        public string _ipAdress;


        public Switcheur(int reference, string hostname, int nbInterface, string ipAdress)
        {
            _reference = reference;
            _hostName = hostname;
            _nbInterface = nbInterface;
            _ipAdress = ipAdress;
        }

        public void Print()
        {
            Console.WriteLine("Switch " + _reference.ToString() + 
                              " : Hostname = " + _hostName + 
                              " - Nombre interface FA : " + _nbInterface + 
                              " - IP = " + _ipAdress);
        }
    }
}
