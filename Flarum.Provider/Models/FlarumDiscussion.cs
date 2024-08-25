using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Flarum.Provider.Models
{
    public class FlarumDiscussion
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Subscription { get; set; }
        public int CommentCount { get; set; }
        public int ParticipantCount { get; set; }
        public string ReplyTemplate { get; set; }
        public int LastPostNumber { get; set; }
        public int LastReadPostNumber { get; set; }
        public string Votes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastPostedAt { get; set; }
        public DateTime LastReadAt { get; set; }
        public DateTime? BestAnswerSetAt { get; set; }
        public DateTime? FrontDate { get; set; }
        public bool CanReply { get; set; }
        public bool CanRename { get; set; }
        public bool CanDelete { get; set; }
        public bool CanHide { get; set; }
        public bool IsApproved { get; set; }
        public bool HasApproved { get; set; }
        public bool HasUpvoted { get; set; }
        public bool HasDownvoted { get; set; }
        public bool CanTag { get; set; }
        public bool CanEditRecipients { get; set; }
        public bool CanEditUserRecipients { get; set; }
        public bool CanEditGroupRecipients { get; set; }
        public bool IsPrivateDiscusion { get; set; }
        public bool CanSeeReactions { get; set; }
        public bool IsLocked { get; set; }
        public bool CanLock { get; set; }
        public bool CanSplit { get; set; }
        public bool CanMerge { get; set; }
        public bool Front { get; set; }
        public bool CanSelectBestAnswer { get; set; }
        public bool IsSticky { get; set; }
        public bool CanViewWhoTypes { get; set; }
        public bool CanMarkUnread { get; set; }
        public bool CanManageReplyTemplates { get; set; }
    }
}
