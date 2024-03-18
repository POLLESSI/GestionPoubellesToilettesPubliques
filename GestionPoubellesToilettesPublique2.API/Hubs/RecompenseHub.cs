using GestionPoubellesToilettesPublique2.API.Dtos;
using Microsoft.AspNetCore.SignalR;

namespace GestionPoubellesToilettesPublique2.API.Hubs
{
    public class RecompenseHub : Hub
    {
        public async Task NotifyNewRecompense()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("receiverecompenseupdate");
            }
        }
        public async Task RefreshRecompense()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("notifynewrecompense");
            }
        }
        public async Task submit()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("recompense");
        }
        public async Task GetRecompense()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("recompense");
        }
    }
}
