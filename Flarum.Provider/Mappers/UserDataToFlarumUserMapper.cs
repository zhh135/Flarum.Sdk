using Flarum.Api.Models.ResponseModel;
using Flarum.Provider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flarum.Provider.Mappers
{
    public class UserDataToFlarumUserMapper
    {
        public static FlarumUser MapToFlarumUser(FlarumUserDto data)
        {
            return new FlarumUser
            {
                Username = data.Username,
                DisplayName = data.DisplayName,
                AvatarUrl = data.AvatarUrl,
                Slug = data.Slug,
                JoinTime = data.JoinTime,
                DiscussionACount = data.DiscussionACount,
                CommentCount = data.CommentCount,
                CanEdit = data.CanEdit,
                CanEditCredentials = data.CanEditCredentials,
                CanEditGroups = data.CanEditGroups,
                CanDelete = data.CanDelete,
                LastSeenAt = data.LastSeenAt,
                NearataTwoFactorCanEnable = data.NearataTwoFactorCanEnable,
                CanSuspend = data.CanSuspend,
                CanEditNickname = data.CanEditNickname,
                CanSpamblock = data.CanSpamblock,
                BlocksPd = data.BlocksPd,
                CannotBeDirectMessaged = data.CannotBeDirectMessaged,
                Points = data.Points,
                CanHaveVotingNotifications = data.CanHaveVotingNotifications,
                CanMiserable = data.CanMiserable,
                CanBeFollowed = data.CanBeFollowed,
                FollowerCount = data.FollowerCount,
                FollowingCount = data.FollowingCount,
                Bio = data.Bio,
                CanViewBio = data.CanViewBio,
                CanEditBio = data.CanEditBio,
                CanViewSocialProfile = data.CanViewSocialProfile,
                CanEditSocialProfile = data.CanEditSocialProfile,
                CanEditPolls = data.CanEditPolls,
                CanStartPolls = data.CanStartPolls,
                CanSelfEditPolls = data.CanSelfEditPolls,
                CanVotePolls = data.CanVotePolls,
                Ignored = data.Ignored,
                CanBeIgnored = data.CanBeIgnored,
                BestAnswerCount = data.BestAnswerCount,
                CanViewWarnings = data.CanViewWarnings,
                CanManageWarnings = data.CanManageWarnings,
                CanDeleteWarnings = data.CanDeleteWarnings,
                VisibleWarningCount = data.VisibleWarningCount
            };
        }
    }
}
