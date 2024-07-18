using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Classes
{
    internal class Parcelle
    {
        private int _noParcelle;
        private float _surface;
        private string _nomParcelle;
        private string _coordonees;


        public int    NoParcelle {get => _noParcelle; set => _noParcelle = value ;}
        public float  Surface    {get => _surface; set => _surface = value ;}
        public string NomParcelle{get =>_nomParcelle ; set => _nomParcelle = value ;}
        public string Coordonees { get => _coordonees; set => _coordonees = value ;}

        public Parcelle(int noParcelle, float surface, string nomParcelle, string coordonees)
        {
            NoParcelle = noParcelle;
            Surface = surface;
            NomParcelle = nomParcelle;
            Coordonees = coordonees;
        }
    }
}
