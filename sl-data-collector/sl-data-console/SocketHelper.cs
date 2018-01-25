using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using Newtonsoft.Json;
using SlDataConsole.models;
using SocketIo;
using SocketIo.SocketTypes;

namespace SlDataConsole
{
    class SocketHelper
    {
	    private SocketIo.SocketIo socket;
		public void StartSocket()
	    {
			socket = Io.Create("127.0.0.1", 4533, 4533, SocketHandlerType.Tcp);
	    }

	    public void CloseSocket()
	    {
		    socket.Close();
	    }

		public void DispatchEvents(string northEvents, string southEvents)
	    {/*
			socket.On("connect", () =>
			{*/
				socket.Emit("northbound", northEvents);
				socket.Emit("southbound", southEvents);
			//});
		}

	    
}
}
