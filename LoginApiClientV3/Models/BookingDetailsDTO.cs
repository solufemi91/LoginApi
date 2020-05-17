using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApiClientV3.Models
{
    public class BookingDetailsDTO
    {
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
