using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApi.Models
{
    public class FormDataRequest
    {
        public int LoginId { get; set; }
        public string Date { get; set; }

        public string Format { get; set; } = "yyyy-MM-dd";

        //public DateTime ParsedDate => DateTime.Parse(Date);

        public string FormattedDate => DateTime.Parse(Date).ToString(Format);
        public string EventName { get; set; }
        public string Description { get; set; }

        public string Location { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }
    }
}
