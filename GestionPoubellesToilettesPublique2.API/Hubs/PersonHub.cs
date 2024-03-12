using GestionPoubellesToilettesPublique2.API.Dtos;
using Microsoft.AspNetCore.SignalR;

namespace GestionPoubellesToilettesPublique2.API.Hubs
{
    public class PersonHub : Hub
    {
        public async Task NotifyNewPerson()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("receivepersonupdate");
        }
        public async Task RefreshPerson()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("notifynewperson");
        }
        public async Task submit()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("person");
        }
        public async Task GetNPerson()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("person");
        }
    }
}
