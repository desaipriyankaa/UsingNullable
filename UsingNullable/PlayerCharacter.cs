using System;
using System.Collections.Generic;
using System.Text;

namespace UsingNullable
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        public int? DaySinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNoob { get; set; }
    }
}
