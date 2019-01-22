using Estacionamento_.Models;
using Estacionamento_.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estacionamento_.Controllers
{
    public class PessoaFisicaController : Controller
    {
        PFisicaDAO dao = new PFisicaDAO();
        
        // GET: PessoaFisica
        public ActionResult Index()
        {
            var pessoas = dao.Lista().OrderBy(e => e.Nome);

            return View(pessoas);       
        }

        // Cadastro
        public ActionResult Cadastro()
        {
            ViewBag.Pessoa = new PessoaFisica();

            return View();
        }

        // Visualiza
        [Route("pessoasF/{id}", Name = "VisualizaPessoaF")]
        public ActionResult Visualiza(int id)
        {
            PessoaFisica pessoa = dao.BuscaId(id);

            ViewBag.Pessoa = pessoa;
            
            return View();
        }

        public ActionResult Busca()
        {
            PessoaFisica busca = new PessoaFisica();

            ViewBag.Busca = busca;

            return View();
        }

        public ActionResult Pesquisar(string cpf)
        {
            if (cpf == null)
            {
                return View("Busca");
            }
            else
            {
               // PessoaFisica pessoa = new PessoaFisica();

                // pessoa = dao.BuscaPorCpf(cpf);

                var pessoas = dao.Lista().OrderBy(e => e.Nome).Where(e => e.Cpf.Equals(cpf));

                return View(pessoas);
            }
            
        }
        
        public ActionResult Atualiza(PessoaFisica pessoa)
        { // int id

            if (ModelState.IsValid) // Verifica se o modelo obedece as regras de validação
            {
                dao.Atualiza(pessoa);

                return RedirectToAction("Index", "PessoaFisica");
            }
            else
            {
                ViewBag.PessoaF = pessoa;

                return View("Visualiza");
            }
        }

        [HttpPost] 
       // [ValidateAntiForgeryToken]
        public ActionResult Adiciona(PessoaFisica pessoa)
        {
            PessoaFisica verificaCpf = new PessoaFisica();
            PessoaFisica verificaRg  = new PessoaFisica();

            verificaCpf = dao.BuscaPorCpf(pessoa.Cpf);
            verificaRg  = dao.BuscaPorRg(pessoa.Rg);

            if (ModelState.IsValid && verificaCpf == null && verificaRg == null) // Verifica se o modelo obedece as regras de validação
            {
                dao.Adiciona(pessoa);

                return RedirectToAction("Index", "PessoaFisica");
            }
            else
            {
                if(verificaCpf != null)
                {
                    ViewBag.Pessoa = pessoa;
                    ViewBag.Retorno = "CPF já cadastrado!";

                    return View("Cadastro");
                }
                else if(verificaRg != null)
                {
                    ViewBag.Pessoa = pessoa;
                    ViewBag.Retorno = "RG já cadastrado!";

                    return View("Cadastro");
                }
                else
                {
                    ViewBag.Pessoa = pessoa;

                    return View("Cadastro");
                }
            }
        }




    }
}