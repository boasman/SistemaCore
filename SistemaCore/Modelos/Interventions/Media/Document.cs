using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCore.Modelos.Interventions.Media
{
    public class Document
    {
        [MaxLength(40)]
        public string id { get; set; }

        [MaxLength(250)]
        public string name { get; set; }
        public int createdAt { get; set; }
        public string uploadedBy { get; set; }
        [MaxLength(250)]
        public string path { get; set; }
        public string type { get; set; }
        public int offline { get; set; }
      
    }
}
