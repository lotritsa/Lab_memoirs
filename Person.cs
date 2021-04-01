using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationMemoirs
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string RegDate { get; set; }
    }
}
