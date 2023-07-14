using ApiObrasPrimas.DTOs;
using MySql.Data.MySqlClient;
using System.IO;

namespace ApiObrasPrimas.DAO
{
    public class ObraDAO
    {

        public List<ObraDTO> ListarObras()
        {
            var conexao = ConnectionFactory.Build();
            conexao.Open();

            var query = "SELECT*FROM obras_primas";

            var comando = new MySqlCommand(query, conexao);
            var dataReader = comando.ExecuteReader();

            var obras = new List<ObraDTO>();

            while (dataReader.Read())
            {
                var obra = new ObraDTO();
                obra.ID = int.Parse(dataReader["ID"].ToString());
                obra.Nome = dataReader["Nome"].ToString();
                obra.Categoria = dataReader["Categoria"].ToString();
                obra.Descricao = dataReader["Descricao"].ToString();
                obra.ano = int.Parse(dataReader["ano"].ToString());
                obra.Img_Url = dataReader["Img_Url"].ToString();


                obras.Add(obra);
            }
            conexao.Close();

            return obras;
        }

        public List<ObraDTO> ListarCarros()
        {
            var conexao = ConnectionFactory.Build();
            conexao.Open();

            var query = "SELECT*FROM Obras_primas WHERE Categoria = 'Carro'";

            var comando = new MySqlCommand(query, conexao);
            var dataReader = comando.ExecuteReader();

            var obras = new List<ObraDTO>();

            while (dataReader.Read())
            {
                var obra = new ObraDTO();
                obra.ID = int.Parse(dataReader["ID"].ToString());
                obra.Nome = dataReader["Nome"].ToString();
                obra.Categoria = dataReader["Categoria"].ToString();
                obra.Descricao = dataReader["Descricao"].ToString();
                obra.ano = int.Parse(dataReader["ano"].ToString());
                obra.Img_Url = dataReader["Img_Url"].ToString();

                obras.Add(obra);
            }
            conexao.Close();

            return obras;
        }
        public List<ObraDTO> ListarQuadros()
        {
            var conexao = ConnectionFactory.Build();
            conexao.Open();

            var query = "SELECT*FROM Obras_primas WHERE Categoria = 'Quadro'";

            var comando = new MySqlCommand(query, conexao);
            var dataReader = comando.ExecuteReader();

            var obras = new List<ObraDTO>();

            while (dataReader.Read())
            {
                var obra = new ObraDTO();
                obra.ID = int.Parse(dataReader["ID"].ToString());
                obra.Nome = dataReader["Nome"].ToString();
                obra.Categoria = dataReader["Categoria"].ToString();
                obra.Descricao = dataReader["Descricao"].ToString();
                obra.ano = int.Parse(dataReader["ano"].ToString());
                obra.Img_Url = dataReader["Img_Url"].ToString();

                obras.Add(obra);
            }
            conexao.Close();

            return obras;
        }

        public void CriarObra(ObraDTO obra)
        {
            var conexao = ConnectionFactory.Build();
            conexao.Open();

            var query = @"INSERT INTO Obras_primas (Nome, Categoria,Descricao, ano, Img_Url) VALUES
                        (@nome, @categoria, @descricao, @ano, @img_url);";

            var comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@nome", obra.Nome);
            comando.Parameters.AddWithValue("@categoria", obra.Categoria);
            comando.Parameters.AddWithValue("@descricao", obra.Descricao);
            comando.Parameters.AddWithValue("@ano", obra.ano);
            comando.Parameters.AddWithValue("@img_url", obra.Img_Url);


            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void AlterarObra(ObraDTO obra)
        {
            var conexao = ConnectionFactory.Build();
            conexao.Open();

            var query = @"UPDATE Obras_primas SET Nome = @nome, Categoria = @categoria, Descricao = @descricao, ano = @ano, Img_Url = @img_url
                          WHERE ID = @id";

            var comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@nome", obra.Nome);
            comando.Parameters.AddWithValue("@categoria", obra.Categoria);
            comando.Parameters.AddWithValue("@descricao", obra.Descricao);
            comando.Parameters.AddWithValue("@ano", obra.ano);
            comando.Parameters.AddWithValue("@img_url", obra.Img_Url);

            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public void RemoverObra(int id)
        {
            var conexao = ConnectionFactory.Build();
            conexao.Open();

            var query = @"DELETE FROM Obras_primas WHERE ID = @id;";

            var comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            conexao.Close();
        }

    }
}

