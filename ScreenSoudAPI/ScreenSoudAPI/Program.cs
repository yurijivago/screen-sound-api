using ScreenSoudAPI.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try {
        string apiAddress = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";
        string resposta = await client.GetStringAsync(apiAddress);

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        Console.WriteLine($"Temos {musicas.Count} músicas nessa lista");
        musicas[100].ExibirDetalhesDaMusica();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    

    
}