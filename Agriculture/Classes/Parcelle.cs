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
        private int _noParcelle;
        private float _surface;
        private string _nomParcelle;
        private string _coordonees;


        public int NoParcelle { get => _noParcelle; set => _noParcelle = value; }
        public float Surface { get => _surface; set => _surface = value; }
        public string NomParcelle { get => _nomParcelle; set => _nomParcelle = value; }
        public string Coordonees { get => _coordonees; set => _coordonees = value; }

        public Parcelle(int noParcelle, float surface, string nomParcelle, string coordonees)
        {
            NoParcelle = noParcelle;
            Surface = surface;
            NomParcelle = nomParcelle;
            Coordonees = coordonees;
        }


        public static void Selection()
        {
            string connStr = $"server=localhost;user=root;database=agriculture;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            MySqlCommand commandeSelect = new MySqlCommand("SELECT * FROM Parcelle", conn);
            MySqlDataReader reader = commandeSelect.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t", reader[0],
                        reader[1], reader[2]);
                }
            }
            else
            {
                Console.WriteLine("Aucune colonne trouvé");
            }
            reader.Close();

        }
    }
}
