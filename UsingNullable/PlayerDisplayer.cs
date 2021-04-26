﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UsingNullable
{
    class PlayerDisplayer
    {
        public static void write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("string is null or contains all whitespaces..");
            }
            else
            {
                Console.WriteLine(player.Name);
            }
        

            if (!player.DaySinceLastLogin.HasValue)
            {
                Console.WriteLine("No value for daySinceLastLogin");
            }
            else
            {
                Console.WriteLine(player.DaySinceLastLogin.Value);
            }

            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No date of birth specified");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }

            if (player.IsNoob == null)
            {
                Console.WriteLine("Player newbie status is unknown");
            }
            else if (player.IsNoob == true)
            {
                Console.WriteLine("Player is newbie");
            }
            else
            {
                Console.WriteLine("Player is experianced");
            }
        }
    }
}
