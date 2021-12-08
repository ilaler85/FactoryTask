using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp8.DateAccess
{
    public class FactoryDataAccess : BaseDataAccess
    {
        public FactoryDataAccess(string connectionString) : base(connectionString) { }


        public List<Factory> GetFactory()
        {
            List < Factory > factories= new List<Factory>();
            string sql = @"SELECT Ow.id_owner,Ow.FIO,
                            Fa.id_factory, Fa.Name, Fa.Square, Fa.opening_year,
                            St.id_street, St.Name +' '+ Ci.Name +' '+ Co.Name AS SCC
                            FROM Factory Fa JOIN Owner Ow ON Fa.id_owner = Ow.id_owner
                            JOIN Street St ON St.id_street = Fa.id_street
                            JOIN City Ci ON Ci.id_city = St.id_city
                            JOIN Country Co ON Co.id_country = Ci.id_country
                            ORDER BY 3";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            factories.Add(new Factory
                            {
                                id_factory = (int)reader["id_factory"],
                                Name = (string)reader["Name"],
                                Square = (int)reader["Square"],
                                opening_year = reader["opening_year"] != DBNull.Value?(int)reader["opening_year"]: (int?)null,
                                address = new Address
                                {
                                    id_street = (int)reader["id_street"],
                                    SCC = (string)reader["SCC"]
                                },

                                owner = new Owner
                                {
                                    id_owner = (int)reader["id_owner"],
                                    FIO = (string)reader["FIO"]
                                }


                            });
                        }
                        reader.Close();
                    }

                }
                connection.Close();
            }
            return factories;
        }

        public void InsertFactory(Factory factory)
        {
            string sqlQuery = @"INSERT INTO Factory( Name, Square, opening_year, id_street, id_owner)
                                       VALUES(@Name, @Square, @opening_year, @id_street, @id_owner)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Name", factory.Name));
                    command.Parameters.Add(new SqlParameter("@Square", factory.Square));
                    command.Parameters.Add(new SqlParameter("@id_street", factory.address.id_street));
                    command.Parameters.Add(new SqlParameter("@id_owner", factory.owner.id_owner));
                    if (factory.opening_year != null)
                        command.Parameters.Add(new SqlParameter("@opening_year", factory.opening_year));
                    else
                        command.Parameters.Add(new SqlParameter("@opening_year", DBNull.Value));
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void UpdateFacory(Factory factory)
        {
            string sqlQuery = @"UPDATE Factory SET Name = @Name, Square = @Square, opening_year= @opening_year, id_street= @id_street, id_owner= @id_owner
                                WHERE id_factory = @id_factory";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Name", factory.Name));
                    command.Parameters.Add(new SqlParameter("@Square", factory.Square));
                    command.Parameters.Add(new SqlParameter("@id_street", factory.address.id_street));
                    command.Parameters.Add(new SqlParameter("@id_owner", factory.owner.id_owner));
                    if (factory.opening_year != null)
                        command.Parameters.Add(new SqlParameter("@opening_year", factory.opening_year));
                    else
                        command.Parameters.Add(new SqlParameter("@opening_year", DBNull.Value));
                    command.Parameters.Add(new SqlParameter("@id_factory", factory.id_factory));
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }


        public void DeleteFactory(Factory factory)
        {
            string sql = @"DELETE FROM Factory
                           WHERE id_factory = @id_factory";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add(new SqlParameter("@id_factory", factory.id_factory));
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
