using System;
using System.Data.SqlClient;

namespace yes.classes
{
    internal class ConnectionConturi
    {
        private const string SERVER = "DESKTOP-JR1VUTK\\SQLEXPRESS01";
        private const string DATABASE = "scoala";
        private const string USER = "Calina";
        private const string PASSWORD = "calina115";

        static string GetConnectionString()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = SERVER,
                InitialCatalog = DATABASE,
                UserID = USER,
                Password = PASSWORD,
                IntegratedSecurity = true

            };

            return builder.ConnectionString;
        }

        public void adaugaCont(string nume, string email, string parola)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();

                string sql = "INSERT INTO conturi(nume, email, parola) VALUES(@nume, @email, @parola)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nume", nume);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@parola", parola);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void citeste()
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                string sql = "SELECT * FROM conturi";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0} {1} {2} {3}", reader.GetInt32(0), reader.GetString(1),
                                reader.GetString(2), reader.GetString(3));
                        }
                    }
                }
            }
        }

        public bool login(string nume, string parola)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                string sql = "SELECT * FROM conturi WHERE nume = @nume AND parola = @parola";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nume", nume);
                    command.Parameters.AddWithValue("@parola", parola);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(1).Equals(nume) && reader.GetString(3).Equals(parola))
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }
        }
    }
}
