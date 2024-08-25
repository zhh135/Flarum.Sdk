using Flarum.Provider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flarum.Provider.Mappers
{
    public class TagDataToFlarumTagMapper
    {
        public static FlarumTag MapToFlarumTag(FlarumTag data)
        {
            return new FlarumTag
            {
                Name = data.Name,
                Description = data.Description,
                Slug = data.Slug,
                Color = data.Color,
                BackgroundUrl = data.BackgroundUrl,
                BackgroundMode = data.BackgroundMode,
                Icon = data.Icon,
                DiscussionCount = data.DiscussionCount,
                Position = data.Position,
                DefaultSort = data.DefaultSort,
                IsChild = data.IsChild,
                IsHidden = data.IsHidden,
                LastPostedAt = data.LastPostedAt,
                CanStartDiscussion = data.CanStartDiscussion,
                CanAddToDiscussion = data.CanAddToDiscussion,
                Subscription = data.Subscription,
                RichExcerpts = data.RichExcerpts,
                ExcerptLength = data.ExcerptLength,
                IsQnA = data.IsQnA,
                Reminders = data.Reminders,
                Template = data.Template
            };
        }
    }
}
