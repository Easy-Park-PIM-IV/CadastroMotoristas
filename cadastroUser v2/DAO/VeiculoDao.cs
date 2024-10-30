using cadastroUser_v2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroUser_v2.DAO
{
    public class VeiculoDao : IVeiculoDao
    {
        private readonly string connectionString = "server=localhost;database=EasyPark;user=root;password=";

        public void AddVeiculo(VeiculoEntity veiculo, int id_motorista)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("INSERT INTO Veiculo (id_motorista, placa, modelo, cor) VALUES (@id_motorista, @placa, @modelo, @cor)", connection);
                command.Parameters.AddWithValue("@id_motorista", id_motorista);
                command.Parameters.AddWithValue("@placa", veiculo.placa);
                command.Parameters.AddWithValue("@modelo", veiculo.modelo);
                command.Parameters.AddWithValue("@cor", veiculo.cor);
                command.ExecuteNonQuery();
            }
            
        }
    }
}
