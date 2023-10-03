﻿using ScreenSoudAPI.Modelos;

namespace ScreenSoudAPI.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select( generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($" - {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero))
            .Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> [{genero}]");
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($" ~ {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista) 
    {
        var musicasDoArtista = musicas.Where( musica => musica.Artista!.Equals(artista)).ToList();
        Console.WriteLine($"Lista das músicas: {artista}");
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($" => {musica.Nome}");
        }
    }
}
