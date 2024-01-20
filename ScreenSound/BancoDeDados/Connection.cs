using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.BancoDeDados;

internal class Connection
{
    private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    public SqlConnection ObterConexao()
    {
        return new SqlConnection(connectionString);
    }

    public IEnumerable<Artista> Listar()
    {
        var lista = new List<Artista>();
        using var conexao = ObterConexao();
        conexao.Open();

        string sql = "SELECT * FROM Artistas";
        SqlCommand comando = new SqlCommand(sql, conexao);
        using SqlDataReader leitor = comando.ExecuteReader();

        while(leitor.Read())
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
    }
}
