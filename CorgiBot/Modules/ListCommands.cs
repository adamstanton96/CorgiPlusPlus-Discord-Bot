using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorgiBot.Modules
{
    //Provides the user with a list of available commands...
    public class ListCommands : ModuleBase<SocketCommandContext>
    {
        [Command("list commands!")]
        public async Task PingAsync()
        {
            EmbedBuilder embedBuilder = new EmbedBuilder();

            embedBuilder.AddField("Ping!", "Checks if Corgibot is active.");
            embedBuilder.AddField("List Commands!", "Prints the list of available commands.");
            embedBuilder.AddField("Introduce Yourself!", "Corgibot will introduce itself.");
            embedBuilder.AddField("Tell Me A Joke!", "Corgibot tells you a programming joke.");
            embedBuilder.AddField("Help! <query>", "Corgibot attempts to solve your programming query.");

            List<string> pingResponses = new List<string>();
            pingResponses.Add("**Arf!**");    //0
            pingResponses.Add("**Woof!**");   //1
            pingResponses.Add("**Bork!**");   //2

            Random rnd = new Random();
            int index = rnd.Next(0, pingResponses.Count);

            await ReplyAsync(pingResponses[index] + " Here's a list of Corgibot commands! To call a command just say 'Corgibot!' followed by the command!");
            await ReplyAsync("", false, embedBuilder.Build());
        }
    }
}