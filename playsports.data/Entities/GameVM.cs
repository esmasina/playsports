using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace playsports.data.Entities
{
    public class GameVM
    {
        public Game Game { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}