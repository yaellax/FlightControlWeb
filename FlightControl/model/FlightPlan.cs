using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;


namespace FlightControl.model
{
    struct initial_location
    {
        int longitude;
        int latitude;
        string date_time;
    }
    struct segments
    {
        int longitude;
        int latitude;
        int timespan_seconds;
    }
    public class FlightPlan
    {




        public int passengers { get; set; }

        public string company_name { get; set; }
        //public segments[] haya { get; set; }
        //public initial_location location { get; set; }

    }


}

