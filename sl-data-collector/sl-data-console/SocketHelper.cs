using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;
using Quobject.SocketIoClientDotNet.Client;
using SlDataConsole.models;

namespace SlDataConsole
{
    class SocketHelper : Hub
    {
   
        public void DispatchEvents(string northEvents, string southEvents)
        {
            Clients.All.broadcastNorthEvents(northEvents);
            Clients.All.broadcastSouthEvents(northEvents);
        }

    }
}
