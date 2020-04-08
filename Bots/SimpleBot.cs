using Microsoft.Bot;
using Microsoft.Bot.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloBot.Bots
{
    public class SimpleBot : IBot
    {
        public async Task OnTurn(ITurnContext turnContext)
        {
            string input = turnContext.Activity.Text;
            await turnContext.SendActivity($"SimpleBot: {input}");

        }
    }
}
