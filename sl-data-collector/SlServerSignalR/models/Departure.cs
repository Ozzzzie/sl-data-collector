using System;
using System.Collections.Generic;
using System.Text;

namespace SlServerSignalR
{
    public class Departure
    {
	    public string LineNumber { get; set; }
		public string Destination { get; set; }
	    public string DisplayTime { get; set; }
		public int JourneyDirection { get; set; }
	}
}
