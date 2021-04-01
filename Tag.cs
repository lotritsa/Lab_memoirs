using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationMemoirs
{
    public partial class Tag
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public string TagAddDate { get; set; }
        public int? TagRate { get; set; }
    }
}
