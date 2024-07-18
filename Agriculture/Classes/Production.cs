using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Classes
{
    internal class Production
    {
        private int _codeProduction;
        private string _nomProduction;

        public int CodeProduction { get => _codeProduction; set => _codeProduction = value; }

        public string NomProduction { get => _nomProduction; set => _nomProduction = value; }

        public Production(int codeproduction, string nomProduction) 
        { 
            CodeProduction = codeproduction;
            NomProduction = nomProduction;
        }
    }
}
