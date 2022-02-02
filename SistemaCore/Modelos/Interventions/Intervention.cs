using SistemaCore.Modelos.Interventions.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SistemaCore.Modelos
{
    public class Intervention
    {

        public string @case { get; set; }
        public string remote_phone { get; set; }
        public string type { get; set; }
        public string insured_name { get; set; }
    }
}
