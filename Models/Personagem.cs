using System.Text.Json.Serialization;

namespace BlazorDbzPersonagem.Models;

public class Personagem
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string? Nome { get; set; }

    [JsonPropertyName("image")]
    public string? Imagem { get; set; }

    [JsonPropertyName("originPlanet")]
    public Planeta? Planeta { get; set; }

    [JsonPropertyName("transformations")]
    public List<Transformacao> Transformacoes { get; set; } = [];
}

public class Planeta
{
    [JsonPropertyName("name")]
    public string? Nome { get; set; }
}

public class Transformacao
{
    [JsonPropertyName("name")]
    public string? Nome { get; set; }
}
