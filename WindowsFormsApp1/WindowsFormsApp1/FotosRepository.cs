using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Core.Configuration;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    internal class FotosRepository
    {
        private readonly string _connectionString;

        public FotosRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void SalvarFoto(string nome, string descricao, Image imagem, DateTime dataLancamento)
        {
            byte[] imagemBytes = ImageUtil.ConverterImagemParaBytes(imagem);

            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO fotos (nome, descricao, imagem, datalancamento) 
                         VALUES (@Nome, @Descricao, @Imagem, @DataLancamento)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Descricao", descricao);
                    command.Parameters.AddWithValue("@Imagem", imagemBytes);
                    command.Parameters.AddWithValue("@DataLancamento", dataLancamento);
                    command.ExecuteNonQuery();
                }
            }
        }
        public Image ObterImagemPorNome(string nome)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT imagem,descricao FROM fotos WHERE nome = @Nome";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);


                    using (var reader = command.ExecuteReader())
                    {

                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            byte[] imagemBytes = (byte[])reader["imagem"];

                            return ImageUtil.ConverterBytesParaImagem(imagemBytes);



                        }

                    }
                }
            }

            return null;
        }

        public string ObterDescricaoPorNome(string nome)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT descricao FROM fotos WHERE nome = @Nome";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);


                    using (var reader = command.ExecuteReader())
                    {

                        if (reader.Read() && !reader.IsDBNull(0))
                        {


                            return reader.GetString(0);



                        }

                    }
                }
            }

            return null;
        }
        public int? ObterIdFotoPorNome(string nome)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT id_foto FROM fotos WHERE nome = @Nome";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);

                    var result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        return Convert.ToInt32(result);

                    return null;
                }
            }
        }
       public List<RankingFoto> Ranking()
        {
            var ranking = new List<RankingFoto>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT id_foto, Count(*) AS totalCurtidas " +
                    "FROM avaliacao WHERE curtida = TRUE GROUP BY id_foto ORDER BY totalCurtidas DESC LIMIT 3;";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                        {
                            ranking.Add(new RankingFoto

                            {
                                IdFoto = reader.GetInt32("id_foto"),
                                TotalCurtidas = reader.GetInt32("totalCurtidas")
                            }
                            );

                        }
                }

            }
            return ranking;
        }
        public string ObterNomePorIdFoto(int id_foto)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT nome FROM fotos WHERE id_foto= @Id";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("Id", id_foto);

                    var result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        return Convert.ToString(result);

                    return null;
                }
            }
        }
    }
}
    
