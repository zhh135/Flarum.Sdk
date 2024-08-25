using Flarum.Provider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flarum.Provider.Mappers
{
    public class PostDataToFlarumPostMapper
    {
        public static FlarumPost MapToFlarumPost(FlarumPost data)
        {
            return new FlarumPost
            {
                Number = data.Number,
                CreatedAt = data.CreatedAt,
                ContentType = data.ContentType,
                ContentHtml = data.ContentHtml,
                RenderFailed = data.RenderFailed,
                CanEdit = data.CanEdit,
                CanDelete = data.CanDelete,
                CanHide = data.CanHide,
                CanFlag = data.CanFlag,
                IsApproved = data.IsApproved,
                CanApprove = data.CanApprove,
                CanReact = data.CanReact,
                HasDownvoted = data.HasDownvoted,
                HasUpvoted = data.HasUpvoted,
                CanSeeVotes = data.CanSeeVotes,
                Votes = data.Votes,
                CanVote = data.CanVote,
                SeeVoters = data.SeeVoters,
                CanViewEditHistory = data.CanViewEditHistory,
                CanDeleteEditHistory = data.CanDeleteEditHistory,
                CanRollbackEditHistory = data.CanRollbackEditHistory
            };
        }
    }
}
