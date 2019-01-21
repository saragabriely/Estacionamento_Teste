using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Estacionamento_.Models
{
    public class PessoaFisica
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int    IdPessoaF         { get; set; }

        [Required, StringLength(11)]
        public string Cpf               { get; set; }

        [Required, StringLength(50)]
        public string Nome              { get; set; }

        [Required, StringLength(9)]
        public string Rg                { get; set; }        

        public string Sexo              { get; set; }

        public string DataDeNascimento  { get; set; }
                
        public string Endereco          { get; set; }

        public string Numero            { get; set; }

        public string Complemento       { get; set; }

        public string Bairro            { get; set; }

        public string Cidade            { get; set; }

        public string Uf                { get; set; }

        public string Cep               { get; set; }

        public string Telefone          { get; set; }

        public string Email             { get; set; }
        
        public PessoaFisica() { }

    }
}