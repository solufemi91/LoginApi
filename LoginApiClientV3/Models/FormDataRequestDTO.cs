using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApiClientV3.Models
{
    public class FormDataRequestDTO
    {
        public int LoginId { get; set; }
        public string Date { get; set; }

        public DateTime ParsedDate => DateTime.Parse(Date);
        public string EventName { get; set; }
        public string Description { get; set; }

        public string Location { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }
    }
}
