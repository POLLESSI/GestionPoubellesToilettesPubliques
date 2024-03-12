using GestionPoubellesToilettesPublique2.API.Dtos;
using Microsoft.AspNetCore.SignalR;

namespace GestionPoubellesToilettesPublique2.API.Hubs
{
    public class SaveStreetHub : Hub
    {
        public async Task NotifyNewSaveStreet()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("receivepersonupdate");
            }
        }
        public async Task RefreshSaveStreet()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("notifynewsavestreet");
            }
        }
        public async Task submit()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("savestreet");
        }
        public async Task GetSaveStreet()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("savestreet");
        }
    }
}
