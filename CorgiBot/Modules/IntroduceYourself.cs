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
            await ReplyAsync("**Arf!** Hi everyone! I'm **Corgibot!** Want to ask me something, just say 'Corgibot!' followed by a command! For more informaion try 'Corgibot! list commands!'");
        }
    }
}