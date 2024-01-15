using System.Data.SqlClient;

namespace yes.classes
{
    internal class ConnectionElevi
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

        public static void conectare()
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();

                string sql = "INSERT INTO elevi(nume, prenume, adresa, nrMatricol, initialaTata) VALUES(@nume, @prenume, @adresa, @nrMatricol, @initialaTata)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nume", "a");
                    command.Parameters.AddWithValue("@prenume", "a");
                    command.Parameters.AddWithValue("@adresa", "a");
                    command.Parameters.AddWithValue("@nrMatricol", 1);
                    command.Parameters.AddWithValue("@initialaTata", 'a');

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void delete(string name)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                string sql = "DELETE FROM elevi WHERE nume = @nume";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nume", name);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void update(string name)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();
                string sql = "UPDATE elevi SET nume = @newName WHERE nume = @nume";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@newName", "newTest");
                    command.Parameters.AddWithValue("@nume", name);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
