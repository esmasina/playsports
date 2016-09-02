using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace playsports.data.Entities
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual Location Location { get; set;}
        public virtual ICollection<Attendance> Attendance { get; set; }

    }
}