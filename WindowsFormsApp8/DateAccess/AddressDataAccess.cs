using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp8.DateAccess
{
    class AddressDataAccess : BaseDataAccess
    {
        public AddressDataAccess(string connectionString) :
            base(connectionString)
        { }

        public List<Address> GetAddresses()
        {
            List<Address> addresses = new List<Address>();

            string sql = @"SELECT St.id_street, St.Name +' '+ Ci.Name +' '+ Co.Name AS SCC
                           FROM Street St JOIN City Ci ON Ci.id_city  = St.id_city
                           JOIN Country Co ON Co.id_country = Ci.id_country";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            addresses.Add(new Address
                            {
                                id_street = (int)reader["id_street"],
                                SCC =  (string)reader["SCC"]
                            });
                        }
                        reader.Close();
                    };
                }
                connection.Close();
            }

            return addresses;
        }
    }
}
