using CodeHollow.FeedReader;
using CodeHollow.FeedReader.Feeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAlert
{
    internal class MovieItem : FeedItem
    {
        public MovieItem(FeedItem item)
        {
            this.Author = item.Author;
            this.Content = item.Content;
            this.Description = item.Description;
            this.Id = item.Id;
            this.Link = item.Link;
            this.PublishingDate = item.PublishingDate;
            this.PublishingDateString = item.PublishingDateString;
            this.SpecificItem = item.SpecificItem;
            this.Title = item.Title;
        }

        public bool IsRead { get; set; }

        public bool IsDeleted { get; set; }
    }
}
