using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Classes
{
    internal class Element_chimique
    {
        private string _codeElement;
        private string _libelleElement;


        public string CodeElement { get => _codeElement; set => _codeElement = value; }
        public string LibelleElement { get => _libelleElement; set => _libelleElement = value ; }

        public Element_chimique(string codeElement, string libelleElement)
        {
            CodeElement = codeElement;
            LibelleElement = libelleElement;
        }
    }
}
