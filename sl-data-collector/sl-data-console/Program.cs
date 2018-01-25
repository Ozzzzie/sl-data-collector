using System;
using System.Threading;
using Microsoft.CSharp.RuntimeBinder;

namespace SlDataConsole
{
    class Program
    {
	    static void Main(string[] args)
	    {
		    Console.WriteLine("Hello World!");


		    ApiHelper ah = new ApiHelper();
		    ApiResponse ar = ah.GetInformation();

			SocketHelper sh = new SocketHelper();
		    sh.StartSocket();

		    while (true)
		    {
			    ar = ah.GetInformation();
				sh.DispatchEvents(ah.GetEvents(ar.ResponseData.Metros, 1), ah.GetEvents(ar.ResponseData.Metros, 2));
				Console.WriteLine(ah.GetEvents(ar.ResponseData.Metros, 1) + "  :::  " + ah.GetEvents(ar.ResponseData.Metros, 2));
				Thread.Sleep(20000);
		    }
	    }
    }
}
