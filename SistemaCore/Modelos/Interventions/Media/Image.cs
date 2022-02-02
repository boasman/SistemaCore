using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCore.Modelos.Interventions.Media
{
    public class Image
    {
        [MaxLength(40)]
        public string id { get; set; }
        public Coordinates coordinates { get; set; }
        public int createdAt { get; set; }
        public int offline { get; set; }
        [MaxLength(1200)]
        public string  image { get; set; }

        [MaxLength(1200)]
        public string thumbnail { get; set; }
        [MaxLength(1200)]
        public string  caption { get; set; }        
        public string  type { get; set; }       
        public string  size { get; set; }
        public string  uploadedBy { get; set; }
    }
}
