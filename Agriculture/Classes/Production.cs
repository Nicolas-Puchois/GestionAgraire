using MySql.Data.MySqlClient;
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
        private string _unite;

        public int CodeProduction { get => _codeProduction; set => _codeProduction = value; }

        public string NomProduction { get => _nomProduction; set => _nomProduction = value; }

        public string Unite { get => _unite; set => _unite = value; }

        public static List<Production> SelectionDeToutlesProduits()
        {

            // récuperer plusieurs Parcelle
            List<Production> list = new List<Production>();
            basededonee basededonee = basededonee.GetDatabase();
            basededonee.Connection.Open();
            MySqlCommand commandeSelectToutlesProduits = new MySqlCommand("SELECT nom_production, unite FROM production; ", basededonee.Connection);
            MySqlDataReader reader = commandeSelectToutlesProduits.ExecuteReader();
            while (reader.Read())
            {
                list.Add(
                new Production
                {
                    NomProduction = reader.GetString("nom_production"),
                    Unite = reader.GetString("unite")
                });
            }
            reader.Close();
            basededonee.Connection.Close();
            return list;
        }
    }
}
