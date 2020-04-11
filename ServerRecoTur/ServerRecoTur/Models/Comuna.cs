using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServerRecoTur.Models
{
    public class Comuna
    {
        public int id { get; set; }
        [StringLength(30)]
        public string nombre { get; set; }
    }
}
