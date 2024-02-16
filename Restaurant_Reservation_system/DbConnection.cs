using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Reservation_system
{
    class DbConnection
    {
        public MySqlConnection connectDB()
        {
            string con_string = "server=127.0.0.1;uid=root;pwd=;database=restaurant_reservation";
            MySqlConnection con = new MySqlConnection(con_string);
            return con;
        }
    }
}
