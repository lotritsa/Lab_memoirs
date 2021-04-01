using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationMemoirs
{
    public partial class Series
    {
        public int SeriesId { get; set; }
        public string SeriesAddDate { get; set; }
        public int? SeriesRate { get; set; }
        public string SeriesPosterUrl { get; set; }
    }
}
