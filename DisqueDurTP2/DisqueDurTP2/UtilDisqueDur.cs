using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisqueDurTP2
{
    class UtilDisqueDur
    {
        static void Main(string[] args)
        {
            DisqueDur MonDisqueDur;
            MonDisqueDur = new DisqueDur();
            MonDisqueDur.diminuerEspOccup();
            MonDisqueDur.augmenterEspOccup();
            MonDisqueDur.ajoutPart();
            MonDisqueDur.supprPart();
            MonDisqueDur.ajoutFichier();
            MonDisqueDur.supprFichier();
            MonDisqueDur.espaceLibre();
            MonDisqueDur.proprietes();
            Console.ReadLine();
        }
    }
}
