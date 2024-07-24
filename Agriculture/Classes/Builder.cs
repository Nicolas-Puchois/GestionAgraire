using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agriculture.Classes
{
    internal class Builder
    {
        private readonly MySqlConnection _connection;
        private MySqlConnection Connection { get => _connection; }

        public Builder(basededonee database)
        {
            _connection = database.Connection;
        }

        private void Query(string query)
        {
            try
            {
                Connection.Open();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Source + " : " + exception.Message);
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
