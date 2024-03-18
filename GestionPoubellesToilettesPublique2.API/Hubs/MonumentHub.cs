using GestionPoubellesToilettesPublique2.API.Dtos;
using Microsoft.AspNetCore.SignalR;

namespace GestionPoubellesToilettesPublique2.API.Hubs
{
    public class MonumentHub : Hub
    {
        public async Task NotifyNewMonument()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("receivemonumentupdate");
            }
        }
        public async Task RefreshMonument()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("notifynewmonument");
            }
        }
        public async Task submit()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("monument");
        }
        public async Task GetMonument()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("monument");
        }
    }
}
