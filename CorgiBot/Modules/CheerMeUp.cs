using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorgiBot.Modules
{
    //Requests a ping from the bot to ensure it is running...
    public class CheerMeUp : ModuleBase<SocketCommandContext>
    {
        List<string> imageDir = new List<string>()
        {
            "media/dog1.jpg",
            "media/dog2.jpg",
            "media/dog3.jpg",
            "media/dog4.jpg",
            "media/dog5.jpg",
        };

        [Command("cheer me up!")]
        public async Task PingAsync()
        {
            List<string> pingResponses = new List<string>();
            pingResponses.Add("**Arf!**");    //0
            pingResponses.Add("**Woof!**");   //1
            pingResponses.Add("**Bork!**");   //2

            Random rnd = new Random();
            int index = rnd.Next(0, pingResponses.Count);
            int indexImg = rnd.Next(0, imageDir.Count);

            await SendFile(images[indexImg]);
            await ReplyAsync(pingResponses[index] + " I hope this puts a smile on your face!");
        }
    }
}