using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Reservation_system
{
    public class DbTransactions
    {
        private string access;
        public string Access
        {
            get { return access; }
            set { access = value; }
        }
        public bool loginCheck(string username, string password)
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "select * from login_details";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (username.Equals(reader.GetString("username")) && password.Equals(reader.GetString("password")))
                    {
                        //MessageBox.Show("login success !");
                        access = reader.GetString("access");
                        return true;
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public bool signinInsert(string firstName, string lastName, string userName, string passWord)
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "insert into login_details(first_name,last_name,username,password)" +
                    "values('" + firstName + "','" + lastName + "','" + userName + "','" + passWord + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public int orderPrice(string foodName, int quantity)
        {
            int price = 0;
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "select * from food_details";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (foodName.Equals(reader.GetString("food_name")))
                    {
                        price = reader.GetInt32("price");
                        //MessageBox.Show(price);
                        return price;
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return price;
            }
            return price;
        }
        public bool insertFood(string foodName, string category, int price)
        {
            MySqlConnection con = new DbConnection().connectDB();
            string query = "insert into products(food_name,category,price) values('" + foodName + "','" + category + "'," + price + ")";
            MySqlCommand cmd = new MySqlCommand( query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
       // public bool
    }
}
