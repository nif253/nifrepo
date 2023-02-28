using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Csharp_Hotel_System
{
    class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection("datasource=b7bkeb3p71wfduo2vcec-mysql.services.clever-cloud.com;port=3306;username=ujwhlqwduzagstgr;password=vUr0lbEaalBpobOx5qbq;database=b7bkeb3p71wfduo2vcec;");

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void openConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
