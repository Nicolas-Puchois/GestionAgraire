using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Classes
{
    internal class Epandre
    {
        private float _qteEpandu;

        public float QteEpandu { get => _qteEpandu; set => _qteEpandu = value; }

        public Epandre(float qteEpandu) 
        {
            QteEpandu = qteEpandu;
        }
    }
}
