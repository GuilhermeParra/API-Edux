using ProjetoEduxRemake.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduxRemake.Interfaces
{
    interface ITotal
    {
        List<Total> Listar();
        Total BuscarPorId(Guid id);
        void Editar(Total total);
        void Adicionar(Total turma);
        void Remover(Guid id);
    }
}
