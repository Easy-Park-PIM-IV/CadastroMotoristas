using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace cadastroUser_v2
{
    internal class MotoristaDao : IMotoristaDao
    {
        private string connectionString = "server=localhost;database=EasyPark;user=root";

        public void AddMotorista(Motorista motorista)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("INSERT INTO Motorista (Nome, Email, Telefone) VALUES (@Nome, @Email, @Telefone)", connection);
                command.Parameters.AddWithValue("@Nome", motorista.Nome);
                command.Parameters.AddWithValue("@Email", motorista.Email);
                command.Parameters.AddWithValue("@Telefone", motorista.Telefone);
                command.ExecuteNonQuery();
            }

        }

        public List<Motorista> GetMotoristas()
        {
            var motoristas = new List<Motorista>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT * FROM Motorista", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        motoristas.Add(new Motorista
                        {
                            Id = reader.GetInt32("Id"),
                            Nome = reader.GetString("Nome"),
                            Email = reader.GetString("Email"),
                            Telefone = reader.GetString("Telefone")
                        });
                    }
                }
            }
            return motoristas;
        }

        public Motorista GetMotorista(int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT * FROM Motorista WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Motorista
                        {
                            Id = reader.GetInt32("Id"),
                            Nome = reader.GetString("Nome"),
                            Email = reader.GetString("Email"),
                            Telefone = reader.GetString("Telefone")
                        };
                    }
                }
            }
            return null;
        }

        public void DeleteMotorista(int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("DELETE FROM Motorista WHERE Id = @Id", connection);
                command.Parameters.AddWithValue ("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}


