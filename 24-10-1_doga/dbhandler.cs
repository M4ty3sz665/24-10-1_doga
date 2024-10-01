using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace _24_10_1_doga
{
    public class dbhandler
    {
       
            MySqlConnection connection;
            string table = "bake";
            public dbhandler()
            {
                string username = "root";
                string password = "";
                string host = "localhost";
                string dbName = "bakery";

                string connectionstring = $"username={username};password={password};host={host};database={dbName}";

                connection = new MySqlConnection(connectionstring);
            }

            public void addOne(products oneProduct)
            {
                try
                {
                    connection.Open();
                    string query = $"Insert into {table}(name,quantity,price) " + $"values('{oneProduct.name}','{oneProduct.quantity}','{oneProduct.price}')";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                    MessageBox.Show("sikerult");
                }
                catch (Exception)
                {


                }
            }

            public void deleteOne(products oneProduct)
            {
                try
                {
                    connection.Open();
                    string query = $"Delete from {table} where id = {oneProduct.id}";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                    MessageBox.Show("delete one");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "error:");
                }
            }

            public void readAll()
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * from bake";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader read = command.ExecuteReader();
                    while (read.Read())
                    {
                        int id = read.GetInt32(read.GetOrdinal("id"));
                        string name = read.GetString(read.GetOrdinal("name"));
                        int quantity = read.GetInt32(read.GetOrdinal("quantity"));
                        int price = read.GetInt32(read.GetOrdinal("price"));

                        products oneProduct = new products();

                    oneProduct.id = id;
                    oneProduct.name = name;
                    oneProduct.quantity = quantity;
                    oneProduct.price = price;
                    

                    products.product.Add(oneProduct);

                    }
                    read.Close();
                    command.Dispose();
                    connection.Close();
                    MessageBox.Show("siker");


                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error:");

                }
            }
        
    }
}
