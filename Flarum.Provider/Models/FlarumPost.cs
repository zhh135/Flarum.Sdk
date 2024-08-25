using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Flarum.Provider.Models
{
    public class FlarumPost
    {
        public string Number { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ContentType { get; set; }
        public string ContentHtml { get; set; }
        public bool RenderFailed { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
        public bool CanHide { get; set; }
        public bool CanFlag { get; set; }
        public bool IsApproved { get; set; }
        public bool CanApprove { get; set; }
        public bool CanReact { get; set; }
        public bool HasUpvoted { get; set; }
        public bool HasDownvoted { get; set; }
        public bool CanSeeVotes { get; set; }
        public int Votes { get; set; }
        public bool CanVote { get; set; }
        public bool SeeVoters { get; set; }
        public bool CanViewEditHistory { get; set; }
        public bool CanDeleteEditHistory { get; set; }
        public bool CanRollbackEditHistory { get; set; }
    }
}
