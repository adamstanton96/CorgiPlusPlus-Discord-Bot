using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorgiBot.Modules
{
    public class Ping : ModuleBase<SocketCommandContext>
    {
        [Command("ping!")]
        public async Task PingAsync()
        {
            List<string> pingResponses = new List<string>();
            pingResponses.Add("**Arf!**");    //0
            pingResponses.Add("**Woof!**");   //1
            pingResponses.Add("**Bork!**");   //2

            Random rnd = new Random();
            int index = rnd.Next(0, pingResponses.Count);

            await ReplyAsync(pingResponses[index]);
        }
    }
}
