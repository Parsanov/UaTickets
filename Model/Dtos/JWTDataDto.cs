using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dtos
{
    public class JWTDataDto
    {
        public string token { get; set; }


        public override string ToString()
        {
            return token;
        }
    }
}
