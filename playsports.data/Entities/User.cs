using System;
using System.Collections.Generic;

namespace playsports.data.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public ICollection<Attendance> Attendance { get; set; }

    }
}