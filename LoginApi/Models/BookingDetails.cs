using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApi.Models
{
    public class BookingDetails
    {
        public int? LoginId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string EventName { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Location { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }
}
