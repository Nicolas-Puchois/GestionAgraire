using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Classes
{
    internal class Culture
    {
        private int _idCulture;
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private float _qteRecolte;



        public  int IdCulture {get => _idCulture; set => _idCulture = value;}

        public DateTime  DateDebut {get => _dateDebut; set => _dateDebut = value;}
  
        public DateTime  DateFin {get => _dateFin; set => _dateFin = value;}

        public float QteRecolte { get => _qteRecolte; set => _qteRecolte = value; }

        public Culture(int idCulture, DateTime dateDebut, DateTime dateFin, float qteRecolte)
        {
            IdCulture = idCulture;
            DateDebut = dateDebut;
            DateFin = dateFin;
            QteRecolte = qteRecolte;
        }

    }
}
