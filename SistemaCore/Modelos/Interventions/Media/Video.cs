using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCore.Modelos.Interventions.Media
{
    public class Video
    {
        [MaxLength(40)]
        public string id { get; set; }

        [MaxLength(40)]
        public string name { get; set; }
        public int createdAt { get; set; }

        public string uploadedBy { get; set; }
        public int offline { get; set; }
        [MaxLength(1200)]
        public string path { get; set; }
    
    }
}
