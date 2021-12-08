using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp8.DateAccess
{
    class OwnerDataAccess : BaseDataAccess
    {
        public OwnerDataAccess(string connectionString) :
            base(connectionString)
        { }

        public List<Owner> GetOwners()
        {
            List<Owner> owners = new List<Owner>();
            string sql = @"SELECT Ow.*
                           FROM Owner Ow";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            owners.Add(new Owner
                            {
                                id_owner = (int)reader["id_owner"],
                                FIO = (string)reader["FIO"]
                            });
                        }
                        reader.Close();
                    };
                }
                connection.Close();
            }
            return owners;
        }
    }
}
