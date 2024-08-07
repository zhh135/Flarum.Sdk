using System.Text.Json.Serialization;

namespace Flarum.Api.Bases
{
    public class ActualRequestBase
    {
        [JsonPropertyName("authenication")] public required string Token { get; set; }
    }
}
