using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApi.Models;

namespace MyApi.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
        
    }
}