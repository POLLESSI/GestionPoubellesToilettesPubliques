using GestionPoubellesToilettesPublique2.API.Dtos;
using Microsoft.AspNetCore.SignalR;

namespace GestionPoubellesToilettesPublique2.API.Hubs
{
    public class AvatarHub : Hub
    {
        public async Task NotifyNewAvatar()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("receiveavatarupdate");
            }
        }
        public async Task RefreshAvatar()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("notifynewavatar");
            }
        }
        public async Task submit()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("avatar");
        }
        public async Task GetAvatar()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("avatar");
        }
    }
}
