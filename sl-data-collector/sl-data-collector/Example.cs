using System;
using SocketIo;
using SocketIo.SocketTypes;

namespace sl_data_collector
{
    public class Example
    {
        SocketIo.SocketIo Socket = Io.Create("127.0.0.1", 4533, 4533, SocketHandlerType.Tcp);
    }
}
