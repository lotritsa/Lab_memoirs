using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationMemoirs
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string BookAddDate { get; set; }
        public string BookRate { get; set; }
        public string BookCoverUrl { get; set; }
        public string BookAuthor { get; set; }
        public string BookInfo { get; set; }
    }
}
