using GestionPoubellesToilettesPublique2.API.Dtos;
using Microsoft.AspNetCore.SignalR;

namespace GestionPoubellesToilettesPublique2.API.Hubs
{
    public class PublicToiletHub : Hub
    {
        public async Task NotifyNewPublicToilet()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("receivepublictoiletupdate");
            }
        }
        public async Task RefreshPublicToilet()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("notifynewpublictoilet");
            }
        }
        public async Task submit()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("publictoilet");
        }
        public async Task GetPublicToilet()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("publictoilet");
        }
    }
}
