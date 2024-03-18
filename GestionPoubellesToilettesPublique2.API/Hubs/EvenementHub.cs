using GestionPoubellesToilettesPublique2.API.Dtos;
using Microsoft.AspNetCore.SignalR;

namespace GestionPoubellesToilettesPublique2.API.Hubs
{
    public class EvenementHub : Hub
    {
        public async Task NotifyNewEvenementUpdate()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("receiveevenement");
            }
        }
        public async Task RefreshEvenement()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("notifynewevenement");
            }
        }
        public async Task submit()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("evenement");
        }
        public async Task getEvenement()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("evenement");
        }
    }
}
