using Estacionamento_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estacionamento_.DAO
{
    public class PFisicaDAO
    {
        private EstacionamentoContext db = new EstacionamentoContext();

        public void Adiciona(PessoaFisica pf)
        {
            using (var context = new EstacionamentoContext())
            {
                context.PFs.Add(pf);
                context.SaveChanges();
            }
        }

        public IEnumerable<PessoaFisica> Lista()
        {
            return db.PFs.ToList();
        }

        public PessoaFisica BuscaId(int id)
        {
            using (var contexto = new EstacionamentoContext())
            {
                PessoaFisica pessoa = db.PFs.FirstOrDefault(e => e.IdPessoaF == id);

                return pessoa;
            }
        }

        public PessoaFisica BuscaPorCpf(string cpf)
        {
            using (var contexto = new EstacionamentoContext())
            {
                return contexto.PFs.Where(p => p.Cpf.Equals(cpf)).FirstOrDefault();
            }
        }

        public PessoaFisica BuscaPorRg(string rg)
        {
            using (var contexto = new EstacionamentoContext())
            {
                return contexto.PFs.Where(p => p.Rg.Equals(rg)).FirstOrDefault();
            }
        }

        public PessoaFisica BuscaPorNome(string nome)
        {
            using (var contexto = new EstacionamentoContext())
            {
                return contexto.PFs.Where(p => p.Nome.Equals(nome)).FirstOrDefault();
            }
        }

        public void Atualiza(PessoaFisica pessoa)
        {
            using (var contexto = new EstacionamentoContext())
            {
                contexto.Entry(pessoa).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}