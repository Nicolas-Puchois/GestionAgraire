using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Agriculture.Classes
{
    internal class Culture
    {
        private int _idCulture;
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private float _qteRecolte;
        private int _noParcelle;
        private int _codeProd;



        public  int IdCulture {get => _idCulture; set => _idCulture = value;}

        public DateTime  DateDebut {get => _dateDebut; set => _dateDebut = value;}
  
        public DateTime  DateFin {get => _dateFin; set => _dateFin = value;}

        public float QteRecolte { get => _qteRecolte; set => _qteRecolte = value; }

        public int NoParcelle { get => _noParcelle; set => _noParcelle = value; }

        public int CodeProd { get => _codeProd; set => _codeProd = value; }

        public static List<Culture> SelectionAll()
        {
            // récuperer plusieurs Parcelle
            List<Culture> list = new List<Culture>();
            basededonee basededonee = basededonee.GetDatabase();
            basededonee.Connection.Open();
            MySqlCommand commandeSelect = new MySqlCommand("SELECT * FROM Culture", basededonee.Connection);

            MySqlDataReader reader = commandeSelect.ExecuteReader();
            while (reader.Read())
            {
                list.Add(
                new Culture
                {
                    IdCulture = reader.GetInt32("id_culture"),
                    DateDebut = reader.GetDateTime("date_debut"),
                    DateFin = reader.GetDateTime("date_fin"),
                    QteRecolte = reader.GetFloat("qte_recolte"),
                    NoParcelle = reader.GetInt32("noParcelle"),
                    CodeProd = reader.GetInt32("code_prod"),
                });
            }
            reader.Close();
            basededonee.Connection.Close();
            return list;
        }


        public static List<Culture> SelectionUneCulture()
        {
            // récuperer plusieurs Parcelle
            List<Culture> list = new List<Culture>();
            basededonee basededonee = basededonee.GetDatabase();
            basededonee.Connection.Open();
            string nomParcelle = "Boby";
            MySqlCommand commandeSelectUneCulture = new MySqlCommand("SELECT Parcelle.no_parcelle, Culture.* FROM Culture  INNER JOIN Parcelle On Culture.noParcelle = Parcelle.no_parcelle WHERE Parcelle.nom_parcelle = @nom_parcelle", basededonee.Connection);
            commandeSelectUneCulture.Parameters.AddWithValue("@nom_parcelle", nomParcelle);
            MySqlDataReader reader = commandeSelectUneCulture.ExecuteReader();
            while (reader.Read())
            {
                list.Add(
                new Culture
                {
                    IdCulture = reader.GetInt32("id_culture"),
                    DateDebut = reader.GetDateTime("date_debut"),
                    DateFin = reader.GetDateTime("date_fin"),
                    QteRecolte = reader.GetFloat("qte_recolte"),
                    NoParcelle = reader.GetInt32("noParcelle"),
                    CodeProd = reader.GetInt32("code_prod"),
                });
            }
            reader.Close();
            basededonee.Connection.Close();
            return list;
        }

        public static List<Culture> SelectionCultureQuantiteSupUn()
        {
            // récuperer plusieurs Parcelle
            List<Culture> list = new List<Culture>();
            basededonee basededonee = basededonee.GetDatabase();
            basededonee.Connection.Open();
            MySqlCommand commandeSelectCultureQuantiteSupUn = new MySqlCommand("SELECT Culture.* FROM Culture  WHERE qte_recolte > 1", basededonee.Connection);
            MySqlDataReader reader = commandeSelectCultureQuantiteSupUn.ExecuteReader();
            while (reader.Read())
            {
                list.Add(
                new Culture
                {
                    IdCulture = reader.GetInt32("id_culture"),
                    DateDebut = reader.GetDateTime("date_debut"),
                    DateFin = reader.GetDateTime("date_fin"),
                    QteRecolte = reader.GetFloat("qte_recolte"),
                    NoParcelle = reader.GetInt32("noParcelle"),
                    CodeProd = reader.GetInt32("code_prod"),
                });
            }
            reader.Close();
            basededonee.Connection.Close();
            return list;
        }
    }
}
