using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diiage.DungeonCrawlerBackEnd.WebApplication.Hubs
{
    public class HomeHub : Hub
    {
        public async Task SendMyEvent()
        {
            await Clients.All.SendAsync("MyEvent");
        }

    }
}
