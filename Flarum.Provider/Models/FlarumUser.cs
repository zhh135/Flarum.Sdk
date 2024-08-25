using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Flarum.Provider.Models
{
    public class FlarumUser
    {
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string AvatarUrl { get; set; }
        public string Slug { get; set; }
        public DateTime JoinTime { get; set; }
        public int DiscussionACount { get; set; }
        public int CommentCount { get; set; }
        public bool CanEdit { get; set; }
        public bool CanEditCredentials { get; set; }
        public bool CanEditGroups { get; set; }
        public bool CanDelete { get; set; }
        public DateTime LastSeenAt { get; set; }
        public bool NearataTwoFactorCanEnable { get; set; }
        public bool CanSuspend { get; set; }
        public bool CanEditNickname { get; set; }
        public bool CanSpamblock { get; set; }
        public bool BlocksPd { get; set; }
        public bool CannotBeDirectMessaged { get; set; }
        public int Points { get; set; }
        public bool CanHaveVotingNotifications { get; set; }
        public bool CanMiserable { get; set; }
        public bool CanBeFollowed { get; set; }
        public int FollowingCount { get; set; }
        public int FollowerCount { get; set; }
        public string Bio { get; set; }
        public bool CanViewBio { get; set; }
        public bool CanEditBio { get; set; }
        public bool CanViewSocialProfile { get; set; }
        public bool CanEditSocialProfile { get; set; }
        public bool CanEditPolls { get; set; }
        public bool CanStartPolls { get; set; }
        public bool CanSelfEditPolls { get; set; }
        public bool CanVotePolls { get; set; }
        public bool Ignored { get; set; }
        public bool CanBeIgnored { get; set; }
        public bool BestAnswerCount { get; set; }
        public bool CanViewWarnings { get; set; }
        public bool CanManageWarnings { get; set; }
        public bool CanDeleteWarnings { get; set; }
        public bool VisibleWarningCount { get; set; }
    }
}
