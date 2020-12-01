using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoEduxRemake.Domains;
using ProjetoEduxRemake.Interfaces;
using ProjetoEduxRemake.Repositories;

namespace ProjetoEduxRemake.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TotalController : ControllerBase
    {

        private readonly ITotal _totalRepository;

        public TotalController()
        {
            _totalRepository = new TotalRepository();
        }


        public List<Total> Get()
        {
            return _totalRepository.Listar();
        }
    }
}
