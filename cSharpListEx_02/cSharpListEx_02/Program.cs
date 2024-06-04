using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpListEx_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            // This Example shows how to add object to a list within the angel brackets
            List<Player> players = new List<Player>();

            //Player player1 = new Player("Mohammd");       // We will not use this way 
            //Player player2 = new Player("Ibrahim");
            //Player player3 = new Player("khalil");

            //players.Add(player1);
            //players.Add(player2);
            //players.Add(player3);


            players.Add(new Player("Mohammd"));         // this call anonymous object
            players.Add(new Player("Ibrahim"));         
            players.Add(new Player("khalil"));

            foreach (Player player in players)
            {
                Console.WriteLine(player);         //we can use Console.WriteLine(player.username); to get data but we use override tostring method below
            }

            Console.ReadKey();
        }
    }
    class Player
    {
        public string username;

        public Player (string username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return username;
        }
    }
}
