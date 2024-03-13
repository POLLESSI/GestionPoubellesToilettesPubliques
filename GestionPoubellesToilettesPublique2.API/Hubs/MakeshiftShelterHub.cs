using GestionPoubellesToilettesPublique2.API.Dtos;
using Microsoft.AspNetCore.SignalR;

namespace GestionPoubellesToilettesPublique2.API.Hubs
{
    public class MakeshiftShelterHub : Hub
    {
        public async Task NotifyNewMakeshiftShelter()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("receivemakeshiftshelter");
            }
        }
        public async Task RefreshMakeshiftShelter()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("notifynewmakeshiftshelter");
            }
        }
        public async Task submit()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("makeshiftshelter");
        }
        public async Task getMakeshiftShelter()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("makeshiftshelter");
        }
    }
}
