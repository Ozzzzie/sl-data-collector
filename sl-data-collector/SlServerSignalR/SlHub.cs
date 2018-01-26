using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SlServerSignalR
{
    public class SlHub : Hub
    {
        public void DispatchEvents()
        {
            ApiHelper ah = new ApiHelper();
            var departures = ah.GetInformation();
            var northEvents = ah.GetEvents(departures.ResponseData.Metros, 1);
            var southEvents = ah.GetEvents(departures.ResponseData.Metros, 2);
            Clients.All.broadcastNorthEvents(northEvents);
            Clients.All.broadcastSouthEvents(southEvents);
        }
    }
}