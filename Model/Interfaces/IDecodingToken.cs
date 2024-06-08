using Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interfaces
{
    public interface IDecodingToken
    {
        public JWTUserDto GetUserDto(string token);
    }
}
