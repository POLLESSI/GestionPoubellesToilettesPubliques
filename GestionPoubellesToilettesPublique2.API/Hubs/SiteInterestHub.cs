using GestionPoubellesToilettesPublique2.API.Models;
using Microsoft.AspNetCore.SignalR;

namespace GestionPoubellesToilettesPublique2.API.Hubs
{
    public class SiteInterestHub : Hub
    {
        public async Task NotifyNewSiteInterest()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("receivesiteinterestupdate");
            }
        }
        public async Task RefreshSiteInterest()
        {
            if (Clients is not null)
            {
                await Clients.All.SendAsync("notifynewsiteinterest");
            }
        }
        public async Task submit()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("siteinterest");
        }
        public async Task GetSiteInterest()
        {
            if (Clients is not null)
                await Clients.All.SendAsync("siteinterest");
        }
    }
}
