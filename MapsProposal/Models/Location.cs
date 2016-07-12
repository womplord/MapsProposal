using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapsProposal.Models
{
    public class Location
    {
        public int ID { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
    }
}