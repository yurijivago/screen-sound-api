﻿
using System.Text.Json;
using System.Text.Json.Serialization;
namespace ScreenSoudAPI.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasPreferidas { get; set; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasPreferidas = new List<Musica>();
    }

    public void AdicionarMusicaFavorita(Musica musica)
    {
        ListaDeMusicasPreferidas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoridas [{Nome}]");
        foreach(var musica in ListaDeMusicasPreferidas)
        {
            Console.WriteLine($" - {musica.Artista}: {musica.Nome}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize( 
            new {
                nome = Nome,
                musicas = ListaDeMusicasPreferidas
            }
        );
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText( nomeDoArquivo, json );

        Console.WriteLine($"O arquivo {nomeDoArquivo} foi criado com sucesso!");
    }
}
