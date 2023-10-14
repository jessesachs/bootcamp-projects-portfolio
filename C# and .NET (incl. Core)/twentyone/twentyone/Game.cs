using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyone
{
    public abstract class Game
    {
        private List<player> _players = new List<player>();
        private Dictionary<player, int> _bets = new Dictionary<player, int>();
        public List<player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }

        public Dictionary<player, int> Bets { get {return _bets;} set {_bets = value;} }

        public abstract void Play(); //simply states that any class inhereting from this abstract (Game) class must have a Play method
        public virtual void ListPlayers() //virtual method inside of an abstract class means that this method gets inherited by an inherited class, but has the ability to override it
        {
            foreach (player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
