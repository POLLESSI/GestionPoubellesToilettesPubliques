using GestionPoubellesToilettesPublique2.API.Dtos;
using Microsoft.AspNetCore.SignalR;

namespace GestionPoubellesToilettesPublique2.API.Hubs
{
    public class CanisiteHub : Hub
    {
        public async Task NotifyNewCanisite()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("receivecanisiteupdate");
            }
        }
        public async Task RefreshCanisite()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("notifynewcanisite");
            }
        }
        public async Task submit()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("canisite");
        }
        public async Task GetCanisite()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("canisite");
        }
    }
}
