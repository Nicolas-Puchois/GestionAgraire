using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Classes
{
    internal class Unite
    {
        private string _unite;

        public string Uniteutilise { get => _unite; set => _unite = value; }

        public Unite(string unite) 
        {
            Uniteutilise = unite;
        }
    }
}
