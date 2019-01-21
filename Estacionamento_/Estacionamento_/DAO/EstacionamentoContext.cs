using Estacionamento_.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Estacionamento_.DAO
{
    public class EstacionamentoContext : DbContext
    {
        public DbSet<PessoaFisica>   PFs { get; set; }

        public DbSet<PessoaJuridica> PJs { get; set; }

    }
}