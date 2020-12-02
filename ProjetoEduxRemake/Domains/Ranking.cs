using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduxRemake.Domains
{
    public class Ranking
    {
        public Ranking()
        {
            IdRanking = Guid.NewGuid();
        }

        [Key]
        public Guid IdRanking { get; set; }

        public Guid IdTotal { get; set; }
        [ForeignKey("IdTotal")]
        public Total Total { get; set; }
    }
}
