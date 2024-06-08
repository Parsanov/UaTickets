using Model.Dtos;
using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class DecodingTokenService : IDecodingToken
    {
        public JWTUserDto GetUserDto(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var tokenS = handler.ReadToken(token) as JwtSecurityToken;


            var nameid = tokenS.Claims.FirstOrDefault(c => c.Type == "nameid")?.Value;
            var UserName = tokenS.Claims.FirstOrDefault(c => c.Type == "UserName")?.Value;



            return new JWTUserDto
            {
                UserName = UserName,
                UserId = nameid
            };

        }
    }
}
