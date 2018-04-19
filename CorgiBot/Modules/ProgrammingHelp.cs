using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorgiBot.Modules
{
    public class ProgrammingHelp : ModuleBase<SocketCommandContext>
    {
        [Command("help!")]
        public async Task ProgrammingHelpAsync([Remainder] string query)
        {
            await ReplyAsync("Hmm, Let me see...");
            query = query.Replace(" ", "+");
            await ReplyAsync("**Arf!** Maybe this will help: https://stackoverflow.com/search?q=" + query);
        }
    }
}
