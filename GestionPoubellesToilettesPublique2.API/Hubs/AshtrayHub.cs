using GestionPoubellesToilettesPublique2.API.Dtos;
using Microsoft.AspNetCore.SignalR;

namespace GestionPoubellesToilettesPublique2.API.Hubs
{
    public class AshtrayHub : Hub
    {
        public async Task NotifyNewAshtray()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("receiveashrayupdate");
            }
        }
        public async Task RefreshAshtray()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("notifynewashtray");
            }
        }
        public async Task submit()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("ashtray");
        }
        public async Task GetAshtray()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("ashtray");
        }
    }
}
