using GestionPoubellesToilettesPublique2.API.Dtos;
using Microsoft.AspNetCore.SignalR;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;

namespace GestionPoubellesToilettesPublique2.API.Hubs
{
    public class MapHub : Hub
    {
        public async Task NotifyNewMap()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("receivemapupdate");
            }
        }
        public async Task RefreshMap()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("notifynewmap");
            }
        }
        public async Task submit()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("map");
        } 
        public async Task GetMap()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("map");
        }
    }
}
