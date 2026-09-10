using Guy_Beginning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guy_Beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, Club> clubs = new Dictionary<string, Club>();
           clubs.Add("76ers", new Club { Name = "76ers", State = "Pennsylvania", Founded = 1946, Coach = "Doc Rivers", Championships = 3 });
            clubs.Add("Warriors", new Club { Name = "Warriors", State = "California", Founded = 1946, Coach = "Steve Kerr", Championships = 7 });
            clubs.Add("lakers", new Club { Name = "Lakers", State = "California", Founded = 1947, Coach = "Darvin Ham", Championships = 17 });
            clubs.Add("boston celtics", new Club { Name = "Boston Celtics", State = "Massachusetts", Founded = 1946, Coach = "Joe Mazzulla", Championships = 17 });


            List <Player> players = new List <Player>();
            players.Add(new Player { Name = "Lebron James", team = "76ers", position = "Forward", points = 48000 });
            players.Add(new Player { Name = "Stephen Curry", team = "Warriors", position = "Guard", points = 20000 });
            players.Add(new Player() { Name = "Kevin Durant", team = "Nets", position = "Forward", points = 25000 });

            var clubswithCalifornia = clubs.values
                .where
        }
    }
}
