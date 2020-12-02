using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public Guid IdCurtida { get; set; }
        [ForeignKey("Curtida")]
        public Curtida Curtida { get; set; }
        public Guid ObjetivoAluno { get; set; }
        [ForeignKey("ObjetivoAluno")]
        public ObjetivoAluno IdObjetivoAluno { get; set; }
        public Guid IdDica { get; set; }
        [ForeignKey("Dica")]
        public Dica Dica { get; set; }
    }
}
