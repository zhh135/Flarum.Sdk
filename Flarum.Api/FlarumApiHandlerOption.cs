using System.Text.Json;
using System.Text.Json.Serialization;

using Flarum.Api.Extensions.JsonSerializer;


namespace Flarum.Api
{
    public class FlarumApiHandlerOption
    {
        public Dictionary<string, string> Cookies { get; } = new();

        public string? UserAgent { get; set; } = null;

        public FlarumApiHandlerOption()
        {
        }

        public JsonSerializerOptions JsonSerializerOptions =
        new(JsonSerializerOptions.Default)
        {
            NumberHandling = JsonNumberHandling.WriteAsString |
                             JsonNumberHandling.AllowReadingFromString,
            AllowTrailingCommas = true,
            Converters = { new NumberToStringConverter(), new JsonBooleanConverter() }
        };
    }
}
