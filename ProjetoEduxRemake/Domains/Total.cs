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
        [NotMapped]
        public Curtida Curtida { get; set; }
        public Guid IdObjetivoAluno { get; set; }
        [ForeignKey("ObjetivoAluno")]
        [NotMapped]
        public ObjetivoAluno ObjetivoAluno { get; set; }
        public Guid IdDica { get; set; }
        [ForeignKey("Dica")]
        [NotMapped]
        public Dica Dica { get; set; }
    }
}
