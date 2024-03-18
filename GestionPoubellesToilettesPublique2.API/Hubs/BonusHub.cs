using GestionPoubellesToilettesPublique2.API.Dtos;
using Microsoft.AspNetCore.SignalR;

namespace GestionPoubellesToilettesPublique2.API.Hubs
{
    public class BonusHub : Hub
    {
        public async Task NotifyNewBonus()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("receivebonusupdate");
            }
        }
        public async Task RefreshBonus()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("notifynewbonus");
            }
        }
        public async Task submit()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("bonus");
        }
        public async Task GetBonus()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("bonus");
        }
    }
}
