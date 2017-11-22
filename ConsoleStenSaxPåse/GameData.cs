using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStenSaxPåse
{
    class GameData
    {
        public List<Player> Players { get; } = new List<Player>();
    }

    class Player
    {
        public int ID { get; }
        public string Name { get; set; }

        public Player(int id)
        {
            ID = id;
        }

        public void AskName()
        {
            Name = ConsoleIO.ReadLine(false, "Please enter the name of player " + (ID + 1) + ".");
        }
    }
}
