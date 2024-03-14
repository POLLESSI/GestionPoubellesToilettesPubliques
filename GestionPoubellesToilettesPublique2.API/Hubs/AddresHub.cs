using GestionPoubellesToilettesPublique2.API.Dtos;
using Microsoft.AspNetCore.SignalR;

namespace GestionPoubellesToilettesPublique2.API.Hubs
{
    public class AddresHub : Hub
    {
        public async Task NotifyNewAddres()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("receiveaddresupdate");
            }
        }
        public async Task RefreshAddres()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("notifynewaddres");
            }
        }
        public async Task submit()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("addres");
        }
        public async Task GetAddres()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("addres");
        }
    }
}
