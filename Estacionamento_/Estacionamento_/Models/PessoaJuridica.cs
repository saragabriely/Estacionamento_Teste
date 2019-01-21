using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estacionamento_.Models
{
    public class PessoaJuridica
    {
        [Key]
        public int    IdPessoaJ     { get; set; }

        [Required, Range(14, 14)]
        public string Cnpj          { get; set; }

        [Required, StringLength(50)]
        public string RazaoSocial   { get; set; }
        
        [Required, StringLength(50)]
        public string NomeFantasia  { get; set; }
        
        public string Endereco      { get; set; }

        public string Numero        { get; set; }

        public string Complemento   { get; set; }

        public string Bairro        { get; set; }

        public string Cidade        { get; set; }

        public string Uf            { get; set; }

        public string Cep           { get; set; }
        
        public string Telefone      { get; set; }

        public string Telefone2     { get; set; }
        
        public string Email         { get; set; }
        
    }

}