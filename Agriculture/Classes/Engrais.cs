using MySql.Data.MySqlClient;
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
        private string _unite;

        public int ID_engrais { get => _id_engrais; set => _id_engrais = value;}
        public string NomEngrais { get => _nomEngrais; set => _nomEngrais = value;}

        public string Unite { get => _unite; set => _unite = value; }

        public static List<Engrais> SelectionEngraisDansUneDateSpecifique()
        {
            // récuperer plusieurs Parcelle
            List<Engrais> list = new List<Engrais>();
            basededonee basededonee = basededonee.GetDatabase();
            basededonee.Connection.Open();
            MySqlCommand commandeSelectEngraisDansUneDateSpecifique = new MySqlCommand("SELECT engrais.id_engrais, nom_engrais FROM Engrais " +
                "LEFT JOIN epandre On Epandre.id_engrais = Engrais.id_engrais WHERE Epandre.date_enregistrer = '2021-06-17'", basededonee.Connection);
            MySqlDataReader reader = commandeSelectEngraisDansUneDateSpecifique.ExecuteReader();
            while (reader.Read())
            {
                list.Add(
                new Engrais
                {
                    ID_engrais = reader.GetInt32("id_engrais"),
                    NomEngrais = reader.GetString("nom_engrais")
                });
            }
            reader.Close();
            basededonee.Connection.Close();
            return list;
        }
    }
}
