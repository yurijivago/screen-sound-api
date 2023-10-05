using ScreenSoudAPI.Modelos;
using System.Text.Json;
using ScreenSoudAPI.Filtros;

using (HttpClient client = new HttpClient())
{
    try {
        string apiAddress = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";
        string resposta = await client.GetStringAsync(apiAddress);

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //Console.WriteLine($"Temos {musicas.Count} músicas nessa lista");
        //musicas[100].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");

        /*var minhasMusicasPreferidas = new MusicasPreferidas("Lista do Yuri Jivago");
        minhasMusicasPreferidas.AdicionarMusicaFavorita(musicas[37]);
        minhasMusicasPreferidas.AdicionarMusicaFavorita(musicas[48]);
        minhasMusicasPreferidas.AdicionarMusicaFavorita(musicas[77]);
        minhasMusicasPreferidas.AdicionarMusicaFavorita(musicas[165]);
        minhasMusicasPreferidas.AdicionarMusicaFavorita(musicas[173]);*/

        //minhasMusicasPreferidas.ExibirMusicasFavoritas();
        //minhasMusicasPreferidas.GerarArquivoJson();

        musicas[173].ExibirDetalhesDaMusica();


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    

    
}