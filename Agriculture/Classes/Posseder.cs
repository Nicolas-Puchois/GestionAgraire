using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Classes
{
    internal class Posseder
    {
        private int _valeur;

        public int Valeur { get => _valeur; set => _valeur = value; }

        public Posseder(int valeur)
        {
            Valeur = valeur;
        }
    }
}
