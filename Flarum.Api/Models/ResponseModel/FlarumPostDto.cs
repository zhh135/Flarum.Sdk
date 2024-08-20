using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Flarum.Api.Models.ResponseModel
{
    public class FlarumPostDto
    {
        [JsonPropertyName("number")] public string Number { get; set; }
        [JsonPropertyName("createdAt")] public DateTime CreatedAt { get; set; }
        [JsonPropertyName("contentType")] public string ContentType { get; set; }
        [JsonPropertyName("contentHtml")] public string ContentHtml { get; set; }
        [JsonPropertyName("renderFailed")] public bool RenderFailed { get; set; }
        [JsonPropertyName("canEdit")] public bool CanEdit { get; set; }
        [JsonPropertyName("canDelete")] public bool CanDelete { get; set; }
        [JsonPropertyName("canHide")] public bool CanHide { get; set; }
        [JsonPropertyName("canFlag")] public bool CanFlag { get; set; }
        [JsonPropertyName("isApproved")] public bool IsApproved { get; set; }
    }
}
