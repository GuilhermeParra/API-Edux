using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduxRemake.Domains
{
    public class Total
    {
        [Key]
        public Guid IdTotal { get; set; }
        public int TotalCurtida { get; set; }
        public int TotalNota { get; set; }
        public int TotalObjetivo { get; set; }
    }
}
