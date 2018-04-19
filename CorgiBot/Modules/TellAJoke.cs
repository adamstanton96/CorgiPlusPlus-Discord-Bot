using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorgiBot.Modules
{
    public class Joke
    {
        public Joke(string setup, string punchline) { this.setup = setup; this.punchline = punchline; }
        public string setup;
        public string punchline;
    }

    public class TellAJoke : ModuleBase<SocketCommandContext>
    {
        [Command("tell me a joke!")]
        public async Task TellAJokeAsync()
        {
            List<Joke> jokeBook = new List<Joke>();
            jokeBook.Add(new Joke("How many programmers does it take to screw in a light bulb?", "None. It's a hardware problem! **Arf!**"));   //0
            jokeBook.Add(new Joke("There are 10 kinds of people in this world...", "Those who understand Binary and those who don't! **Arf!**"));   //1
            jokeBook.Add(new Joke("Why do Java developers wear glasses?", "Because they can't C too well! **Arf!**"));   //2
         
            Random rnd = new Random();
            int index = rnd.Next(0, jokeBook.Count);

            await ReplyAsync(jokeBook[index].setup);
            await ReplyAsync(jokeBook[index].punchline);
        }
    }
}
