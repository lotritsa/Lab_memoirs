using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationMemoirs
{
    public partial class Note
    {
        public int NotesId { get; set; }
        public string NoteContentType { get; set; }
        public int? NoteContentId { get; set; }
        public string NoteComment { get; set; }
        public string NoteAddDate { get; set; }
        public int? NoteRate { get; set; }
    }
}
