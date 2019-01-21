using Estacionamento_.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Estacionamento_.DAO
{
    public class PJuridicaDAO : DbContext
    {
        public void Adiciona(PessoaJuridica pj)
        {
            using (var context = new EstacionamentoContext())
            {
                context.PJs.Add(pj);
                context.SaveChanges();
            }
        }

        public IList<PessoaJuridica> Lista()
        {
            using (var contexto = new EstacionamentoContext())
            {
                return contexto.PJs.ToList();
            }
        }

        public PessoaJuridica BuscaPorCNPJ(string cnpj)
        {
            using (var contexto = new EstacionamentoContext())
            {
                return contexto.PJs.Where(p => p.Cnpj.Equals(cnpj)).FirstOrDefault();
            }
        }

        public PessoaJuridica BuscaPorRazao(string razao)
        {
            using (var contexto = new EstacionamentoContext())
            {
                return contexto.PJs.Where(p => p.RazaoSocial.Equals(razao)).FirstOrDefault();
            }
        }

        public PessoaJuridica BuscaPorNomeFantasia(string fantasia)
        {
            using (var contexto = new EstacionamentoContext())
            {
                return contexto.PJs.Where(p => p.NomeFantasia.Equals(fantasia)).FirstOrDefault();
            }
        }

        public void Atualiza(PessoaJuridica pessoa)
        {
            using (var contexto = new EstacionamentoContext())
            {
                contexto.Entry(pessoa).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

    }
}