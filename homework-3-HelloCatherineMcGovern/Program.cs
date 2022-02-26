using System;
using System.Collections.Generic;
using System.Linq;
// You need to add another using directive for LINQ. Put it here. Don't forget!

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prep Work: Copy and Paste list of data
            List<Game> games = new List<Game> {
                new Game {Name = "Counter-Strike: Global Offensive", Developer = "Valve", Genre = "Action", PeakPlayers = 620408, Price = 0.00M, ReleaseDate = DateTime.Parse("8/21/2012"), ReviewScore = "Very Positive"},
                new Game {Name = "Dota 2", Developer = "Valve", Genre = "Action", PeakPlayers = 840712, Price = 0.00M, ReleaseDate = DateTime.Parse("7/9/2013"), ReviewScore = "Very Positive"},
                new Game {Name = "PLAYERUNKNOWN'S BATTLEGROUNDS", Developer = "PUBG Corporation", Genre = "Action", PeakPlayers = 935918, Price = 29.99M, ReleaseDate = DateTime.Parse("12/21/2017"), ReviewScore = "Mixed"},
                new Game {Name = "Tom Clancy's Rainbow Six Siege", Developer = "Ubisoft", Genre = "Action", PeakPlayers = 137686, Price = 39.99M, ReleaseDate = DateTime.Parse("12/1/2015"), ReviewScore = "Very Positive"},
                new Game {Name = "Grand Theft Auto V", Developer = "Rockstar Games", Genre = "Action", PeakPlayers = 89756, Price = 29.99M, ReleaseDate = DateTime.Parse("4/14/2015"), ReviewScore = "Mixed"},
                new Game {Name = "RESIDENT EVIL 2 / BIOHAZARD RE:2", Developer = "CAPCOM Co., Ltd.", Genre = "Action", PeakPlayers = 74241, Price = 59.99M, ReleaseDate = DateTime.Parse("1/24/2019"), ReviewScore = "Overwhelmingly Positive"},
                new Game {Name = "Warframe", Developer = "Digital Extremes", Genre = "Action", PeakPlayers = 79181, Price = 0.0M, ReleaseDate = DateTime.Parse("3/25/2013"), ReviewScore = "Very Positive"},
                new Game {Name = "Rust", Developer = "Facepunch Studios", Genre = "Action", PeakPlayers = 64788, Price = 34.99M, ReleaseDate = DateTime.Parse("2/8/2018"), ReviewScore = "Very Positive"},
                new Game {Name = "Football Manager 2019", Developer = "Sports Interactive", Genre = "Simulation", PeakPlayers = 64139, Price = 49.99M, ReleaseDate = DateTime.Parse("11/2/2018"), ReviewScore = "Mostly Positive"},
                new Game {Name = "Team Fortress 2", Developer = "Valve", Genre = "Action", PeakPlayers = 62806, Price = 0.00M, ReleaseDate = DateTime.Parse("10/10/2007"), ReviewScore = "Very Positive"},
                new Game {Name = "MONSTER HUNTER: WORLD", Developer = "CAPCOM Co., Ltd.", Genre = "Action", PeakPlayers = 94455, Price = 59.99M, ReleaseDate = DateTime.Parse("8/9/2018"), ReviewScore = "Mixed"},
                new Game {Name = "Rocket League", Developer = "Psyonix, Inc.", Genre = "Racing", PeakPlayers = 55813, Price = 19.99M, ReleaseDate = DateTime.Parse("7/7/2015"), ReviewScore = "Very Positive"},
                new Game {Name = "Garry's Mod", Developer = "Facepunch Studios", Genre = "Simulation", PeakPlayers = 51230, Price = 9.99M, ReleaseDate = DateTime.Parse("11/29/2006"), ReviewScore = "Overwhelmingly Positive"},
                new Game {Name = "ARK: Survival Evolved", Developer = "Studio Wildcard", Genre = "Action", PeakPlayers = 51005, Price = 49.99M, ReleaseDate = DateTime.Parse("8/27/2017"), ReviewScore = "Mixed"},
                new Game {Name = "Path of Exile", Developer = "Grinding Gear Games", Genre = "Action", PeakPlayers = 39222, Price = 0.00M, ReleaseDate = DateTime.Parse("10/23/2013"), ReviewScore = "Very Positive"},
                new Game {Name = "Sid Meier's Civilization VI", Developer = "Firaxis Games", Genre = "Strategy", PeakPlayers = 38246, Price = 59.99M, ReleaseDate = DateTime.Parse("10/20/2016"), ReviewScore = "Mixed"},
                new Game {Name = "Terraria", Developer = "Re-Logic", Genre = "Action", PeakPlayers = 36420, Price = 9.99M, ReleaseDate = DateTime.Parse("5/16/2011"), ReviewScore = "Overwhelmingly Positive"},
                new Game {Name = "Sid Meier's Civilization V", Developer = "Firaxis Games", Genre = "Strategy", PeakPlayers = 35982, Price = 29.99M, ReleaseDate = DateTime.Parse("9/21/2010"), ReviewScore = "Overwhelmingly Positive"},
                new Game {Name = "Euro Truck Simulator 2", Developer = "SCS Software", Genre = "Simulation", PeakPlayers = 35153, Price = 19.99M, ReleaseDate = DateTime.Parse("10/12/2012"), ReviewScore = "Overwhelmingly Positive"},
                new Game {Name = "Ring of Elysium", Developer = "Aurora Software", Genre = "Action", PeakPlayers = 43183, Price = 0.00M, ReleaseDate = DateTime.Parse("9/19/2018"), ReviewScore = "Mostly Positive"},
            };



            // Question 1: Select the first game in the list.
            Console.WriteLine("Query 1");
            var query1MS2 = (from g in games
                             select g).Take(1);
            foreach (var g in query1MS2)
            {
                Console.WriteLine(g); //
            }
            Console.WriteLine();


            // 2. Select the first THREE games. Answer the following question:
            Console.WriteLine("Query 2");
            var query2MS = (from g in games
                            select g).Take(3);
            int query2mCount = 1;
            foreach (var g in query2MS)
            {
                Console.WriteLine($"{query2mCount}. {g}"); //
                query2mCount++;
            }
            //3. Select the 3 games after the first 4 games. 
            Console.WriteLine();
            Console.WriteLine("Query 3 -3 games after the first 4 games");
            var query3MS = (from g in games
                            select g).Skip(4).Take(3);
            int query3mCount = 4;
            foreach (var g in query3MS)
            {
                Console.WriteLine($"{query3mCount}. {g}"); //
                query3mCount++;
            }


            // Query #4
            //4. Select games with peak players over 100,000 in both Method and Query Syntax.
            Console.WriteLine(); //METHOD SYNTAX
            Console.WriteLine("Query 4 - peak players over 100,000 - Method Syntax");
            var query4MS = (from g in games
                            where g.PeakPlayers > 100000
                            select g);
            int query4mCount = 1;
            foreach (var g in query4MS)
            {
                Console.WriteLine($"{query4mCount}. {g}"); //
                query4mCount++;
            }

            Console.WriteLine(); //QUERY SYNTAX
            Console.WriteLine("Query 4 - peak players over 100,000 - Query Syntax");
            var query4QS = games.Where(g => g.PeakPlayers > 100000);
            int query4QSCount = 1;
            foreach (var g in query4MS)
            {
                Console.WriteLine($"{query4QSCount}. {g}"); //
                query4QSCount++;
            }

            //5. Select games with peak players over 
            //100,000 and a release date before January 1, 2013 
            //in both Method and Query Syntax.
            Console.WriteLine(); //METHOD SYNTAX
            Console.WriteLine("Query 5 - peak players over 100,000 + release date before January 1, 2013");
            Console.WriteLine("- Method Syntax");
            //Below bringing date into query - idea from here: https://social.msdn.microsoft.com/Forums/en-US/89a09617-803e-4d5e-befa-aa4c7c8d7de0/how-to-usepass-date-parameter-in-linq-query?forum=aspcsharp
            string ymd = "2013-01-01";
            System.DateTime myDate;
            DateTime.TryParse(ymd, out myDate);
            //Here ends the date/prep
            var query5MS = (from g in games
                            where g.PeakPlayers > 100000
                            where g.ReleaseDate < myDate
                            select g);

            int query5mCount = 1;
            foreach (var g in query5MS)
            {
                Console.WriteLine($"{query5mCount}. {g}"); //
                query5mCount++;
            }
            Console.WriteLine(); //QUERY SYNTAX
            Console.WriteLine("Query 5 - peak players over 100,000 + release date before January 1, 2013");
            Console.WriteLine("- Query Syntax");
            var query5QS = games.Where(g => g.PeakPlayers > 100000).Where(g => g.ReleaseDate < myDate);

            int query5QSCount = 1;
            foreach (var g in query5MS)
            {
                Console.WriteLine($"{query5QSCount}. {g}"); //
                query5QSCount++;
            }
            //#6
            //6. Select the first game with a release date before January 1, 2006 
            //using `.FirstOrDefault()`. 
            //If there are none, display "No top 20 games released before 1/1/2006".

            Console.WriteLine(); //METHOD SYNTAX
            Console.WriteLine("Query 6 - first game with a release date before January 1, 2006");
            Console.WriteLine("- Method Syntax");

            //Below bringing date into query
            string ymdQ6 = "2013-01-01";
            System.DateTime myDateQ6;
            DateTime.TryParse(ymdQ6, out myDateQ6);
            var query6MS = (from g in games
                            where g.ReleaseDate < myDateQ6
                            select g).FirstOrDefault();

            try
            {
                Console.WriteLine(query6MS); //
            }
            catch
            {
                Console.WriteLine("No top 20 games released before 1/1/2006");
            }


            //#7
            //7. Perform the same query as Question 6 above, but use the `.First()` method.
            //Question 6 => Select the first game with a release date before January 1, 2006 
            //using `.FirstOrDefault()`. 
            //If there are none, display "No top 20 games released before 1/1/2006".
            Console.WriteLine(); //METHOD SYNTAX
            Console.WriteLine("Query 7 - first game with a release date before January 1, 2006");
            Console.WriteLine("- Method Syntax and `.First()`method");

            //Below bringing date into query
            string ymdQ7 = "2013-01-01";
            System.DateTime myDateQ7;
            DateTime.TryParse(ymdQ7, out myDateQ7);
            var query7MS = (from g in games
                            where g.ReleaseDate < myDateQ6
                            select g).First();

            try
            {
                Console.WriteLine(query7MS); //
            }
            catch
            {
                Console.WriteLine("No top 20 games released before 1/1/2006");
            }

            //8. Select the game named “Rust”. Use the `.Single()` method 
            //to return just that one game.
            Console.WriteLine();
            Console.WriteLine("Query 8 - Select the game named “Rust”");
            var query8MS = (from g in games
                            where g.Name == "Rust"
                            select g).Single();

            Console.WriteLine(query8MS);
            Console.WriteLine();

            //9. Select all games ordered by 
            //genre A-Z and then peak players highest to lowest in 
            //both Method and Query Syntax.
            Console.WriteLine(); //METHOD SYNTAX
            Console.WriteLine("Query 9 - Select all games ordered by release date oldest to newest in both Method and Query Syntax.");
            Console.WriteLine("Method Syntax");

            var query9MS = (from g in games
                            orderby g.ReleaseDate
                            select g);
            int query9mCount = 1;
            // Console.WriteLine($"{g.g} -- {g.Count()}");
            foreach (var g in query9MS)
            {
                Console.WriteLine($"{query9mCount}. {g.Name} - {g.ReleaseDate.ToShortDateString()}");
                query9mCount++;
            }
            Console.WriteLine();
            Console.WriteLine("Query Syntax");
            var query9QS = games.OrderBy(g => g.ReleaseDate);
            int query9QSCount = 1;
            // Console.WriteLine($"{g.g} -- {g.Count()}");
            foreach (var g in query9QS)
            {
                Console.WriteLine($"{query9QSCount}. {g.Name} - {g.ReleaseDate.ToShortDateString()}");
                query9QSCount++;
            }
            //10. Select all games ordered by 
            //genre A-Z and then peak players highest to lowest in 
            //both Method and Query Syntax.
            Console.WriteLine(); //METHOD SYNTAX
            Console.WriteLine("Query 10 - all games ordered by genre A-Z and then peak players highest to lowest in ");
            Console.WriteLine("Method Syntax");

            var query10MS = (from g in games
                             orderby g.Genre
                             orderby g.PeakPlayers
                             select g);
            int query10mCount = 1;
            // Console.WriteLine($"{g.g} -- {g.Count()}");
            foreach (var g in query10MS)
            {
                Console.WriteLine($"{query10mCount}. {g.Name} - {g.Genre}, {g.PeakPlayers}");
                query10mCount++;
            }

            Console.WriteLine("Query Syntax");
            var query10QS = games.OrderBy(g => g.Genre).OrderBy(g => g.PeakPlayers);

            int query10QSCount = 1;
            // Console.WriteLine($"{g.g} -- {g.Count()}");
            foreach (var g in query10QS)
            {
                Console.WriteLine($"{query10QSCount}. {g.Name} - {g.Genre}, {g.PeakPlayers}");
                query10QSCount++;
            }

            //QUERY 11
            //11. Select just the game name (using projection) 
            //of all games that are free in both Method and Query Syntax.
            //.Select(m => new {m.FirstName, m.LastName}) - Projection;

            Console.WriteLine(); //METHOD SYNTAX
            Console.WriteLine("Query - 11 Select just the game name (using projection) of all games that are free in both Method and Query Syntax.");
            Console.WriteLine("METHOD SYNTAX");
            var query11MS = from g in games
                            where g.Price == 0
                            select new { g.Name };
            foreach (var g in query11MS)
            {
                Console.WriteLine($"{g.Name}");
            }

            Console.WriteLine();
            Console.WriteLine("QUERY SYNTAX");
            var query11QS = games.Where(g => g.Price == 0).Select(g => new { g.Name });
            foreach (var g in query11QS)
            {
                Console.WriteLine($"{g.Name}");
            }

            //QUERY 12
            //12. Select the game name and peak players of all games 
            //that are free in both Method 
            //and Query Syntax (using projection). Display the results.

            Console.WriteLine(); //METHOD SYNTAX
            Console.WriteLine("Query - 12 Select the game name and peak players of all games that are free");
            Console.WriteLine("METHOD SYNTAX");
            var query12MS = from g in games
                            where g.Price == 0
                            select new { g.Name, g.PeakPlayers };
            foreach (var g in query12MS)
            {
                Console.WriteLine($"{g.Name} - {g.PeakPlayers}");
            }

            Console.WriteLine();
            Console.WriteLine("QUERY SYNTAX");
            var query12QS = games.Where(g => g.Price == 0).Select(g => new { g.Name, g.PeakPlayers });
            foreach (var g in query12QS)
            {
                Console.WriteLine($"{g.Name} - {g.PeakPlayers}");
            }
            Console.WriteLine();

            //QUERY 13
            //Group the games by developer.
            // Print the results to the console in a similar format to below.
            Console.WriteLine(" QUERY 13 - Group the games by developer.");
            Console.WriteLine("METHOD SYNTAX");
            var query13MS = from g in games
                            group g by g.Developer;

            foreach (var group in query13MS)
            {
                Console.WriteLine();
                Console.WriteLine($"{group.Key} -- {group.Count()} Game(s)");
                foreach (var m in group)
                {
                    Console.WriteLine($"     {m.Name}, {m.Developer}, {m.PeakPlayers}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("QUERY SYNTAX");
            var query13QS = games.GroupBy(g => g.Developer);

            foreach (var group in query13QS)
            {
                Console.WriteLine();
                Console.WriteLine($"{group.Key} -- {group.Count()} Game(s)");
                foreach (var m in group)
                {
                    Console.WriteLine($"     {m.Name}, {m.Developer}, {m.PeakPlayers}");
                }
            }


        }
    }
}
