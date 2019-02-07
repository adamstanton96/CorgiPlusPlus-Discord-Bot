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

    //Tells a joke from a predefined list of programming jokes... EDIT: They're bad jokes and I should feel bad...
    public class TellAJoke : ModuleBase<SocketCommandContext>
    {
        [Command("tell me a joke!")]
        public async Task TellAJokeAsync()
        {
            List<string> pingResponses = new List<string>();
            pingResponses.Add("**Arf!**");    //0
            pingResponses.Add("**Woof!**");   //1
            pingResponses.Add("**Bork!**");   //2

            List<Joke> jokeBook = new List<Joke>();
            jokeBook.Add(new Joke("How many programmers does it take to screw in a light bulb?", "None. It's a hardware problem! "));   //0
            jokeBook.Add(new Joke("There are 10 kinds of people in this world...", "Those who understand Binary and those who don't! "));   //1
            jokeBook.Add(new Joke("Why do Java developers wear glasses?", "Because they can't C too well! "));   //2

            Random rnd = new Random();
            int index = rnd.Next(0, pingResponses.Count);
            int jokeIndex = rnd.Next(0, jokeBook.Count);

            await ReplyAsync(jokeBook[jokeIndex].setup);
            await ReplyAsync(jokeBook[jokeIndex].punchline + pingResponses[index]);
        }
    }
}
