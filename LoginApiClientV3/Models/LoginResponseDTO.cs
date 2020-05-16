using System;
using System.Collections.Generic;
using System.Text;

namespace LoginApiClientV3.Models
{
    public class LoginResponseDTO
    {
        public int LoginDetailsID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
