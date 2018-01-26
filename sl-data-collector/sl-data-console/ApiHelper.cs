using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using SlDataConsole.models;

namespace SlDataConsole
{
    class ApiHelper
    {
	    public ApiResponse GetInformation()
	    {
		    string json = string.Empty;
		    string url = @"http://api.sl.se/api2/realtimedeparturesV4.json?key=0a6c1b6c49f44bc8b36a3e4ed892940c&siteid=9206&timewindow=20&bus=false&train=false&tram=false";

		    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
		    request.AutomaticDecompression = DecompressionMethods.GZip;

		    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
		    using (Stream stream = response.GetResponseStream())
		    using (StreamReader reader = new StreamReader(stream))
		    {
			    json = reader.ReadToEnd();
		    }

		    return JsonConvert.DeserializeObject<ApiResponse>(json);

	    }

	    public string GetEvents(List<Departure> depatures, int direction)
	    {
		    List<Event> events = new List<Event>();
		    foreach (Departure d in depatures.Where(d => d.JourneyDirection == direction))
		    {
			    Event e = new Event();
			    e.Name = d.LineNumber + " " + d.Destination;
			    e.Value = d.DisplayTime;
			    events.Add(e);
		    }
		    return JsonConvert.SerializeObject(events);
	    }
	}
}
