using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Classes
{
    internal class basededonee
    {

        private static readonly basededonee instance = new basededonee();

        private readonly string _server = "127.0.0.1";
        private readonly string _uid = "root";
        private readonly string _password = "";
        private readonly string _database = "agriculture";

        private readonly MySqlConnection _connection;

        public MySqlConnection Connection { get => _connection; }

        private basededonee() 
        {
            string connectionString = $"server={_server};uid={_uid};pwd={_password};database={_database}";
            _connection = new MySqlConnection(connectionString);
        }

        public static basededonee GetDatabase()
        {
            return instance;
        }

        public  void Connexion()
        {
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                Connection.Open();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Connection reussi");
                Console.ForegroundColor = ConsoleColor.White;

            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erreur de connection");
                Console.ForegroundColor = ConsoleColor.White;
                Connection.Close();
            }
        }
    }
}
