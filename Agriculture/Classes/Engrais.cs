using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Classes
{
    internal class Engrais
    {
        private int _id_engrais;
        private string _nomEngrais;

        public int ID_engrais { get => _id_engrais; set => _id_engrais = value;}
        public string NomEngrais { get => _nomEngrais; set => _nomEngrais = value;}
    
        public Engrais(int idEngrais,string nomEngrais)
        {
            ID_engrais = idEngrais;
            NomEngrais = nomEngrais;
        }
    }
}
