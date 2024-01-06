using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoEntityLayer
{
    public class InfoData
    {
        [Key]
        public int InfoId { get; set; }
       
        public string? External { get; set; }

    }
}
