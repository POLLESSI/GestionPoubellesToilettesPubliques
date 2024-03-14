using GestionPoubellesToilettesPublique2.API.Dtos;
using Microsoft.AspNetCore.SignalR;

namespace GestionPoubellesToilettesPublique2.API.Hubs
{
    public class IncivilityHub : Hub
    {
        public async Task NotifyNewIncivility()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("receiveincivilityupdate");
            }
        }
        public async Task RefreshIncivility()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("notifynewincivility");
            }
        }
        public async Task submit()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("incivility");
        }
        public async Task getIncivility()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("incivility");
        }
    }
}
