using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.BancoDeDados
{
    internal class ArtistaDAL
    {
        public IEnumerable<Artista> Listar()
        {
            var lista = new List<Artista>();
            using var conexao = new Connection().ObterConexao();
            conexao.Open();

            string sql = "SELECT * FROM Artistas";
            SqlCommand comando = new SqlCommand(sql, conexao);
            using SqlDataReader leitor = comando.ExecuteReader();

            while (leitor.Read())
            {

                int idArtista = Convert.ToInt32(leitor["Id"]);
                string nomeArtista = Convert.ToString(leitor["Nome"]);
                string bioArtista = Convert.ToString(leitor["Bio"]);
                Artista artista = new Artista(nomeArtista, bioArtista)
                {
                    Id = idArtista
                };

                lista.Add(artista);
            }
            return lista;
            conexao.Close();
        }

        public void Adicionar(Artista artista)
        {
            using var conexao = new Connection().ObterConexao();
            conexao.Open();

            string sql = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)";
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", artista.Nome);
            comando.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
            comando.Parameters.AddWithValue("@bio", artista.Bio);

            int retorno = comando.ExecuteNonQuery();
            Console.WriteLine($"Linhas afetadas: {retorno}");
            conexao.Close();
        }

        public void Atualizar(Artista artista)
        {
            using var conexao = new Connection().ObterConexao();
            conexao.Open();

            string sql = "UPDATE Artistas SET Nome = @nome, Bio = @bio WHERE Id = @id";
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", artista.Nome);
            comando.Parameters.AddWithValue("@bio", artista.Bio);
            comando.Parameters.AddWithValue("@id", artista.Id);

            int retorno = comando.ExecuteNonQuery();
            Console.WriteLine($"Linhas Atualizadas: {retorno}");
            conexao.Close();
        }

        public void Deletar(Artista artista)
        {
            using var conexao = new Connection().ObterConexao();
            conexao.Open();

            string sql = "DELETE FROM Artistas WHERE Id = @id";
            SqlCommand comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@id", artista.Id);

            int retorno = comando.ExecuteNonQuery();
            Console.WriteLine($"Linhas Atualizadas: {retorno}");
            conexao.Close();
        }
    }
}
