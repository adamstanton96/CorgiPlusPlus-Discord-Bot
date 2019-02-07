using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorgiBot.Modules
{
    //Returns a link to search results on stack overflow regarding the query...
    public class ProgrammingHelp : ModuleBase<SocketCommandContext>
    {
        [Command("help!")]
        public async Task ProgrammingHelpAsync([Remainder] string query)
        {
            List<string> pingResponses = new List<string>();
            pingResponses.Add("**Arf!**");    //0
            pingResponses.Add("**Woof!**");   //1
            pingResponses.Add("**Bork!**");   //2

            Random rnd = new Random();
            int index = rnd.Next(0, pingResponses.Count);

            await ReplyAsync("Hmm, Let me see...");
            query = query.Replace(" ", "+");
            await ReplyAsync(pingResponses[index] + " Maybe this will help: https://stackoverflow.com/search?q=" + query);
        }
    }
}
