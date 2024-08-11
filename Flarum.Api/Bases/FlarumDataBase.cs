using System.Text.Json.Serialization;


namespace Flarum.Api.Bases
{
    public class FlarumDataBase
    {
        [JsonPropertyName("type")] public string Type { get; set; }

        [JsonPropertyName("id")] public string Id { get; set; }
    }
}
