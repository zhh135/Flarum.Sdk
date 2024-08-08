using System.Text.Json.Serialization;

namespace Flarum.Api.Bases
{
    public class ActualRequestBase
    {
        [JsonPropertyName("authenication")] public string Token { get; set; } = null;
    }
}
