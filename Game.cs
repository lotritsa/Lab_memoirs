using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationMemoirs
{
    public partial class Game
    {
        public int GameId { get; set; }
        public string GameAddDate { get; set; }
        public int? GameRate { get; set; }
        public string GamePosterUrl { get; set; }
        public string GamePlatform { get; set; }
        public string GameInfo { get; set; }
    }
}
