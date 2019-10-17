using System;
using MySql.Data.MySqlClient;

namespace RGarciaDSWebsite.Models
{
    public class RGarciaDrivingSchool
    {
        private MySqlConnection CreateConnection()
        {
            string connection = "server=localhost;database=OnlineShopWebsite;user=root;password=c1h2i3n4e5s6e7;port=3306";
            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            return con;
        }
        public void addCustomerToDB(Customer cust)
        {
            var con = this.CreateConnection();
            string cmdText = $"insert into customers (`firstName`, `lastName`, `email`) values ('{cust.firstName}', '{cust.lastName}', '{cust.email}')";
            MySqlCommand cmd = new MySqlCommand (cmdText, con);
            cmd.ExecuteNonQuery();
        }

        public void addAddressToDB(Address addr)
        {
            var con = this.CreateConnection();
            string cmdText = $"insert into addresses (`houseNumber`, `street`, `city`, `province`) values ({addr.houseNumber}'{addr.street}', '{addr.city}', '{addr.province}')";
            MySqlCommand cmd = new MySqlCommand (cmdText, con);
            cmd.ExecuteNonQuery();
        }
    }
} 