using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApiClient
{
    public interface ILoginApiClient
    {
        Task<bool> PostValidUserAsync(string data);
    }
}
