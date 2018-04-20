using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorgiBot.Modules
{
    public class IntroduceYourself : ModuleBase<SocketCommandContext>
    {
        [Command("introduce yourself!")]
        public async Task IntroduceYourselfAsync()
        {
            List<string> pingResponses = new List<string>();
            pingResponses.Add("**Arf!**");    //0
            pingResponses.Add("**Woof!**");   //1
            pingResponses.Add("**Bork!**");   //2

            Random rnd = new Random();
            int index = rnd.Next(0, pingResponses.Count);

            await ReplyAsync(pingResponses[index] + " Hi everyone! I'm **Corgibot!** Want to ask me something, just say 'Corgibot!' followed by a command! For more informaion try 'Corgibot! list commands!'");
        }
    }
}