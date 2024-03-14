using GestionPoubellesToilettesPublique2.API.Dtos;
using Microsoft.AspNetCore.SignalR;

namespace GestionPoubellesToilettesPublique2.API.Hubs
{
    public class GarbageCanHub : Hub
    {
        public async Task NotifyNewGarbageCan()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("receivegarbagecanupdate");
            }
        }
        public async Task RefreshGarbageCan()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("notifynewgarbagecan");
            }
        }
        public async Task submit()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("garbagecan");
        }
        public async Task GetGarbageCan()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("garbagecan");
        }
    }
}
