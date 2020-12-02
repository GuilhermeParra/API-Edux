using ProjetoEduxRemake.Context;
using ProjetoEduxRemake.Domains;
using ProjetoEduxRemake.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduxRemake.Repositories
{
    public class RankingRepository : IRanking
    {
        private readonly EduxContext _context;

        public RankingRepository()
        {
            _context = new EduxContext();
        }


        public List<Ranking> Listar()
        {
            try
            {


                return _context.Rankings.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
