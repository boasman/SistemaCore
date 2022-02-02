using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCore.Modelos
{
    public class ResponseLogin
    {
        public bool success { get; set; }
        public string access_token { get; set; }
        public User entity { get; set; }
        public bool expired { get; set; }
    }
}
