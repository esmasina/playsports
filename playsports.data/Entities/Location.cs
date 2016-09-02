using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;

namespace playsports.data.Entities
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DbGeography Coordinates { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}