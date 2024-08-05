using System.Text.Json.Serialization;

namespace Flarum.Api.Bases;

public class CodedResponseBase : ResponseBase
{
    [JsonPropertyName("code")] public int Code { get; set; }
}