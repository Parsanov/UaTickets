﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dtos
{
    public class JWTUserDto
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string token { get; set; }
    }
}
