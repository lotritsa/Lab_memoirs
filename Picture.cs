using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationMemoirs
{
    public partial class Picture
    {
        public int PictureId { get; set; }
        public string PictureAddDate { get; set; }
        public string PictureUrl { get; set; }
        public string PictureComment { get; set; }
        public int? PitureRate { get; set; }
    }
}
