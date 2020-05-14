using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace FlightControl.model
{
    public class Flight
    {
        public int flight_id { get; set; }
        public int passengers { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public string company_name { get; set; }
        public string date_time { get; set; }
        public bool is_external { get; set; }

    }
}
