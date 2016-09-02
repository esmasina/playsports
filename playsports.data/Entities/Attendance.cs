using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace playsports.data.Entities
{
    public class Attendance
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int GameID { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual User User { get; set; }
        public virtual Game Game { get; set; }
    }
}