using (HttpClient client = new HttpClient())
{
    try {
        string apiAddress = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";
        string resposta = await client.GetStringAsync(apiAddress);
        Console.WriteLine(resposta);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    

    
}