using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Classes
{
    internal class Epandre
    {
        private float _qteEpandu;
        private int _noParcelle;
        private int _idEngrais;
        private DateTime _dateEnregistrer;

        public float QteEpandu { get => _qteEpandu; set => _qteEpandu = value; }
        public int NoParcelle { get => _noParcelle; set => _noParcelle = value; }
        public int IdEngrais { get => _idEngrais; set => _idEngrais = value; }
        public DateTime DateEnregistrer { get => _dateEnregistrer; set => _dateEnregistrer = value; }

        public float TotalQuantiteEpendu;

        public static List<Epandre> SelectionQuantiteTotalEpanduDansUneParcelle()
        {
            
            // récuperer plusieurs Parcelle
            List<Epandre> list = new List<Epandre>();
            basededonee basededonee = basededonee.GetDatabase();
            basededonee.Connection.Open();
            MySqlCommand commandeSelectQuantiteTotalDansUneParcelle = new MySqlCommand("SELECT no_parcelle, SUM(qte_epandu) FROM Epandre WHERE date_enregistrer = '2024-06-12' GROUP BY no_parcelle; ", basededonee.Connection);
            MySqlDataReader reader = commandeSelectQuantiteTotalDansUneParcelle.ExecuteReader();
            while (reader.Read())
            {
                list.Add(
                new Epandre
                {
                    NoParcelle = reader.GetInt32("no_parcelle"),
                    TotalQuantiteEpendu = reader.GetFloat("SUM(qte_epandu)")
                });
            }
            reader.Close();
            basededonee.Connection.Close();
            return list;
        }



    }
}
