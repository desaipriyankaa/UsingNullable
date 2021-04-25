using System;
using System.Collections.Generic;
using System.Text;

namespace UsingNullable
{
    class PlayerCharacter
    {
        public string Name { get; set; }
        public Nullable<int> DaySinceLastLogin { get; set; }
        public Nullable<DateTime> DateOfBirth { get; set; }

        public PlayerCharacter()
        {
            DateOfBirth = null; 
            DaySinceLastLogin = null; 
        }
    }
}
