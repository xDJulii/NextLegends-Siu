using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace TutorialBot.Modules

{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("siu")]
        public async Task Siu()
        {
            await ReplyAsync("siuuuuuuuuuuuuuuuuu");
        }
        [Command("invite")]
        public async Task Invite()
        {
            await ReplyAsync("Click this link to invite me. https://discord.com/oauth2/authorize?client_id=922853563833655316&scope=bot&permissions=274878240832");
        }
    }
}   
