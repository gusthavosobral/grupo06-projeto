using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Core.Configuration;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace WindowsFormsApp1
{
    internal class AvaliacaoRepository
    {
        private readonly string _connectionString;
        public AvaliacaoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void InserirComentario(Avaliacao avaliacao)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string insertQuery = @"INSERT INTO avaliacao (id_usuario, id_foto, comentario, curtida) 
                                       VALUES (@IdUsuario, @IdFoto, @Comentario, @Curtida)";

                using (var command = new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@IdUsuario", avaliacao.IdUsuario);
                    command.Parameters.AddWithValue("@IdFoto", avaliacao.IdFoto);
                    command.Parameters.AddWithValue("@Comentario", avaliacao.Comentario);
                    command.Parameters.AddWithValue("@Curtida", avaliacao.Curtida);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void AtualizarCurtida(int idUsuario, int idFoto, bool curtida)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string updateQuery = @"UPDATE avaliacao  SET curtida = @Curtida WHERE id_usuario = @IdUsuario AND id_foto = @IdFoto";



                using (var command = new MySqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Curtida", curtida);
                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    command.Parameters.AddWithValue("@IdFoto", idFoto);

                    command.ExecuteNonQuery();
                }
            }
        }
        public bool? ObterCurtidaPorUsuarioEFoto(int idUsuario, int idFoto)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"SELECT curtida FROM avaliacao 
                         WHERE id_usuario = @IdUsuario AND id_foto = @IdFoto
                         ORDER BY id DESC LIMIT 1";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    command.Parameters.AddWithValue("@IdFoto", idFoto);

                    var result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        return Convert.ToBoolean(result);

                    return null;
                }
            }

        }
        public int? ObterCurtidas(int idFoto)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = @"SELECT COUNT(*) FROM avaliacao 
                         WHERE id_foto = @IdFoto AND curtida = true";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdFoto", idFoto);
                    var result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        return Convert.ToInt32(result);
                    return null;
                }
            }

        }
    }
}
    


