﻿using ScreenSound.Interfaces;
using ScreenSound.Menus;

namespace ScreenSound.Modelos;

internal class Artista:IAvaliavel
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new();
    private List<Musica> musicas = new(); 

    public Artista(string nome =null, string bio =null)
    {
        Nome = nome;
        Bio = bio;
        FotoPerfil = "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png";
    }

    public string Nome { get; set; }
    public string FotoPerfil { get; set; }
    public string Bio { get; set; }
    public int Id { get; set; }
    public IEnumerable<Album> Albuns => albuns;
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(avaliacao => avaliacao.Nota);
        }
    }
    
    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        Console.WriteLine();
        foreach (var album in albuns)
        {
            Console.WriteLine($"Album: {album.Nome}");
            Console.WriteLine($"Duração Total - {album.DuracaoTotal} segundos");
        }
    }
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void AdicionarMusica(Musica musica) 
    {
        musicas.Add(musica);
    }
    public void ExibirMusicas()
    {
        Console.WriteLine($"Musicas do artista {Nome}");
        Console.WriteLine();
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
    }

    public override string ToString()
    {
        //esse método faz com que seja mostrado 
        return $@"Id: {Id}
            Nome: {Nome}
            Foto de Perfil: {FotoPerfil}
            Bio: {Bio}";
    }
}