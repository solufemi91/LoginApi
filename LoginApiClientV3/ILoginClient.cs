using LoginApiClientV3.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoginApiClientV3
{
    public interface ILoginClient
    {
        Task<LoginResponseDTO> PostValidUserAsync(LoginRequestDTO request);
    }
}
