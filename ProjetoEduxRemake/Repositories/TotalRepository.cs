using ProjetoEduxRemake.Context;
using ProjetoEduxRemake.Domains;
using ProjetoEduxRemake.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduxRemake.Repositories
{
    public class TotalRepository : ITotal
    {
        private readonly EduxContext _context;

        public TotalRepository()
        {
            _context = new EduxContext();
        }

        /// <summary>
        /// Cadastra uma novo turma
        /// </summary>
        /// <param name="turma">Objeto a ser cadastrado</param>
        public void Adicionar(Total total)
        {
            try
            {


                _context.Totais.Add(total);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Busca uma turma pelo id
        /// </summary>
        /// <param name="id">Id de turma</param>
        /// <returns>A turma procurado</returns>
        public Total BuscarPorId(Guid id)
        {
            try
            {
                return _context.Totais.FirstOrDefault(a => a.IdTotal == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Altera uma turma
        /// </summary>
        /// <param name="turma">Objeto a ser alterado</param>
        public void Editar(Total total)
        {
            try
            {
                Total totalEdit = BuscarPorId(total.IdTotal);

                if (totalEdit == null)
                {
                    throw new Exception("Usuario nao encontrad");
                }

                totalEdit.TotalCurtida = total.TotalCurtida;

                _context.Totais.Update(totalEdit);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Mostra todos as turmas cadastrados
        /// </summary>
        /// <returns>Uma lista de turmas</returns>
        public List<Total> Listar()
        {
            try
            {


                return _context.Totais.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Remove uma turma
        /// </summary>
        /// <param name="id">Objeto de turma</param>
        public void Remover(Guid id)
        {
            try
            {
                Total totalEdit = BuscarPorId(id);

                if (totalEdit == null)
                {
                    throw new Exception("Usuario nao encontrad");
                }

                _context.Totais.Remove(totalEdit);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
