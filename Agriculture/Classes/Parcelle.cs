using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Classes
{
    internal class Parcelle
    {
        private  int _noParcelle;
        private  float _surface;
        private  string _nomParcelle;
        private  string _coordonees;


        public  int NoParcelle { get => _noParcelle; set => _noParcelle = value; }
        public  float Surface { get => _surface; set => _surface = value; }
        public  string NomParcelle { get => _nomParcelle; set => _nomParcelle = value; }
        public  string Coordonees { get => _coordonees; set => _coordonees = value; }


        public static List<Parcelle> Selection()
        {
            // récuperer plusieurs Parcelle
            List<Parcelle> list = new List<Parcelle>();
            basededonee basededonee = basededonee.GetDatabase();
            basededonee.Connection.Open();
            MySqlCommand commandeSelect = new MySqlCommand("SELECT * FROM Parcelle",basededonee.Connection);
            
            MySqlDataReader reader = commandeSelect.ExecuteReader();
            while (reader.Read())
            {
                list.Add(
                new Parcelle
                {
                    NoParcelle = reader.GetInt32("no_parcelle"),
                    NomParcelle = reader.GetString("nom_parcelle"),
                });
            }
            reader.Close();
            basededonee.Connection.Close();
            return list;
        }

        public static List<Parcelle> SelectionAvecId()
        {
            // récuperer plusieurs Parcelle
            List<Parcelle> list = new List<Parcelle>();
            basededonee basededonee = basededonee.GetDatabase();
            basededonee.Connection.Open();
            int no_parcelle = 2;
            MySqlCommand commandeSelectId = new MySqlCommand("SELECT * FROM Parcelle WHERE no_parcelle = 1", basededonee.Connection);
            commandeSelectId.Parameters.AddWithValue("@no_parcelle", no_parcelle);
            MySqlDataReader readerSelectId = commandeSelectId.ExecuteReader();
            while (readerSelectId.Read())
            {
                list.Add(
                new Parcelle
                {
                    NoParcelle = readerSelectId.GetInt32("no_parcelle"),
                    NomParcelle = readerSelectId.GetString("nom_parcelle"),
                    Surface = readerSelectId.GetFloat("surface"),
                    Coordonees = readerSelectId.GetString("coordonees")
                });
            }
            readerSelectId.Close();
            basededonee.Connection.Close();
            return list;
        }
    }
}
