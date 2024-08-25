using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Flarum.Provider.Models
{
    public class FlarumTag
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public string Color { get; set; }
        public object BackgroundUrl { get; set; }
        public object BackgroundMode { get; set; }
        public string Icon { get; set; }
        public int DiscussionCount { get; set; }
        public int Position { get; set; }
        public object DefaultSort { get; set; }
        public bool IsChild { get; set; }
        public bool IsHidden { get; set; }
        public DateTime LastPostedAt { get; set; }
        public bool CanStartDiscussion { get; set; }
        public bool CanAddToDiscussion { get; set; }
        public object Subscription { get; set; }
        public object RichExcerpts { get; set; }
        public object ExcerptLength { get; set; }
        public bool IsQnA { get; set; }
        public bool Reminders { get; set; }
        public string Template { get; set; }
    }
}
