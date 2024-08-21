using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Flarum.Api.Models.ResponseModel
{
    public class FlarumUserDto
    {
        [JsonPropertyName("username")] public string Username { get; set; }
        [JsonPropertyName("displayName")] public string DisplayName { get; set; }
        [JsonPropertyName("avatarUrl")] public string AvatarUrl { get; set; }
        [JsonPropertyName("slug")] public string Slug { get; set; }
        [JsonPropertyName("joinTime")] public DateTime JoinTime { get; set; }
        [JsonPropertyName("discussionCount")] public int DiscussionACount { get; set; }
        [JsonPropertyName("commentCount")] public int CommentCount { get; set; }
        [JsonPropertyName("canEdit")] public bool CanEdit { get; set; }
        [JsonPropertyName("canEditCredentials")] public bool CanEditCredentials { get; set; }
        [JsonPropertyName("canEditGroups")] public bool CanEditGroups { get; set; }
        [JsonPropertyName("canDelete")] public bool CanDelete { get; set; }
        [JsonPropertyName("lastSeenAt")] public DateTime LastSeenAt { get; set; }
        [JsonPropertyName("nearataTwoFactorCanEnable")] public bool NearataTwoFactorCanEnable { get; set; }
        [JsonPropertyName("canSuspend")] public bool CanSuspend { get; set; }

    }
}
