using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Classes
{
    internal class Date_enregistrer
    {
        private DateTime _dateEnregistrer;
        public DateTime DateEnregistrer { get => _dateEnregistrer; set => _dateEnregistrer = value; }

        public Date_enregistrer(DateTime dateEnregistrer)
        {
            DateEnregistrer = dateEnregistrer;
        }
    }
}
