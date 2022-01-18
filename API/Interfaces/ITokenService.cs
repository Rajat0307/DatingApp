using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService // in c# add I in interface name
    {
        string CreateToken(AppUser user);
    }
}