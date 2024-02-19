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
        public int orderPrice(string foodName)
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
            try
            {
               MySqlConnection con = new DbConnection().connectDB();
            string query = "insert into food_details(food_name,category,price) values('" + foodName + "','" + category + "'," + price + ")";
            MySqlCommand cmd = new MySqlCommand( query, con);
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
        public bool insertEmployee(string firstName, string lastName, string username, string password, string access)
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "INSERT INTO  login_details(first_name,last_name,username,password,access) " +
                    "VALUES ('" + firstName +"','" + lastName + "','" + username + "','" + password + "','"+ access +"')";
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
        public bool insertInventory(string name, int quantity, int price)
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "insert into inventery(name,quantity,price) values('" + name + "','" + quantity + "'," + price + ")";
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
        public bool insertOrder(string name, int quantity, int price)
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "insert into order_details(food_name,quantity,price) values('" + name + "','" + quantity + "'," + price + ")";
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
        // detete food details using food id
        public bool deleteFood(string id)
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "delete from food_details where id=" + id;
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
        // delete employee deteils using id
        public bool deleteEmployee(string id)
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "delete from employee_details where id =" + id;
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
        // delete inventory items using id
        public bool deleteInventory(string id)
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "delete from inventery where name=" + id;
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
        // update food details using food name
        public bool updateFood(string foodName, string category, int price)
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "update food_details set category ='" + category + "', price = " + price + " where food_name ="+ foodName;
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

        // update employee details using first name
        public bool updateEmployee(string firstName, string lastName, string address, string position, int telephone)
        {
            try
            {
                MySqlConnection con = new DbConnection().connectDB();
                string query = "update food_details set last_name ='" + lastName + "', address = '" + firstName + "', position = '" + lastName + "'"+ telephone +" where first_name =" + firstName;
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
    }
}
