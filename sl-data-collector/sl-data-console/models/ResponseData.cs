﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SlDataConsole
{
    class ResponseData
    {
		public string LatestUpdate { get; set; }
	    public List<Departure> Metros { get; set; }
	    public List<Departure> Buses { get; set; }
	
	}
}
