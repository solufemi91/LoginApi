﻿using LoginApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApi.Repository
{
    public interface ILoginRepository
    {
        IEnumerable<LoginDetails> GetLogin(LoginRequest loginRequest);
    }
}
