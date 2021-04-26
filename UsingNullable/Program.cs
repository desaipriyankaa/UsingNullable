using System;

namespace UsingNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = "";// "    ";// null;// "Priyanka";
            player.DaySinceLastLogin = 22;

            PlayerDisplayer.write(player);
        }
    }
}
