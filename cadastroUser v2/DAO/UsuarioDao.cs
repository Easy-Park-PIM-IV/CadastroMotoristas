using cadastroUser_v2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroUser_v2.DAO
{
    public class UsuarioDao : IUsuarioDAO
    {
        private readonly string connectionString = "server=localhost;database=EasyPark;user=root;password=";

        public UsuarioEntity BuscarUsuario(string usuario, string senha)
        {
            UsuarioEntity usuarioEncontrado = null;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Usuario WHERE Usuario = @usuario AND Senha = @senha";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                usuarioEncontrado = new UsuarioEntity
                                {
                                    Id = reader.GetInt32("Id"),
                                    Nome = reader.GetString("Nome"),
                                    Usuario = reader.GetString("Usuario"),
                                    Senha = reader.GetString("Senha"),
                                    Tipo = reader.GetString("Tipo")
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao buscar usuário: " + ex.Message);
                }
            }
            return usuarioEncontrado;
        }
    }
 }
