using MongoDB.Driver;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1 { 
    internal class UsuarioRepository
{
    private readonly string _connectionString;

    public UsuarioRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

        public Usuario ObterPorEmailESenha(string email, string senha)
        {
            Usuario usuario = null;  // Mudei aqui para inicializar com null.
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT email, username, senha, poder, id FROM usuario WHERE email = @Email AND senha = @Senha";
                using (var command = new MySqlCommand(query, connection))
                {
                   
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Senha", senha);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                Email = reader.GetString("email"),
                                Username = reader.GetString("username"),
                                Senha = reader.GetString("senha"),
                                Poder = reader.GetString("poder"),
                                Id = reader.GetInt32("id")
                            };
                        }
                    }
                }
            }
            return usuario;
        }


        public int InserirUsuario(Usuario usuario)
    {
        int linhasAfetadas = -1;
        using (var connection = new MySqlConnection(_connectionString))
        {
            connection.Open();
            string query = "INSERT INTO usuario (email, username, senha, poder) VALUES (@Email, @Username, @Senha, @Poder)";
            using (var command = new MySqlCommand(query, connection))
            {


                    string hashedSenha = HashUtil.GerarHashSha256(usuario.Senha);
                    command.Parameters.AddWithValue("@Email", usuario.Email);
                command.Parameters.AddWithValue("@Username", usuario.Username);
                    command.Parameters.AddWithValue("@Senha", hashedSenha);
                command.Parameters.AddWithValue("@Poder", usuario.Poder);
                
                    linhasAfetadas = command.ExecuteNonQuery();
            }
        }
        return linhasAfetadas;
    }
        public int DarPoderPorId(int id, string poder)
        {
            int linhasAfetadas = -1;
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE usuario SET poder = @Poder WHERE id = @Id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Poder", poder);
                    
                    linhasAfetadas = command.ExecuteNonQuery();
                }
            }
            return linhasAfetadas;

        }
}

}





