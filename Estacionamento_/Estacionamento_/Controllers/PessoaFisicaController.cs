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
        // GET: PessoaFisica
        public ActionResult Index()
        {
            PFisicaDAO dao = new PFisicaDAO();

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
        { // int id
            PFisicaDAO dao = new PFisicaDAO();

            PessoaFisica pessoa = dao.BuscaId(id);

            ViewBag.Pessoa = pessoa;
            
            return View();
        }
        
        public ActionResult Atualiza(PessoaFisica pessoa)
        { // int id

            if (ModelState.IsValid) // Verifica se o modelo obedece as regras de validação
            {
                PFisicaDAO dao = new PFisicaDAO();

                dao.Atualiza(pessoa);

                return RedirectToAction("Index", "PessoaFisica");
            }
            else
            {
                ViewBag.PessoaF = pessoa;

                return View("Visualiza");
            }
        }

        /*
         * 
         * 
         * [Route("produtos/{id}", Name = "VisualizaProduto")]
            public ActionResult Visualiza(int id)
            {
                ProdutosDAO dao = new ProdutosDAO();
                Produto produto = dao.BuscaPorId(id);
                ViewBag.Produto = produto;
                return View();
            }
         *
         *
        public ActionResult Form()
        {
            CategoriasDAO categoriasDAO = new CategoriasDAO();

            IList<CategoriaDoProduto> categorias = categoriasDAO.Lista();

            ViewBag.Categorias = categorias;

            ViewBag.Produto = new Produto();

            return View();
        } */

        [HttpPost] // Só aceita requisições enviadas pelo método POST
       // [ValidateAntiForgeryToken]
        public ActionResult Adiciona(PessoaFisica pessoa)
        {
            if (ModelState.IsValid) // Verifica se o modelo obedece as regras de validação
            {
                PFisicaDAO dao = new PFisicaDAO();

                dao.Adiciona(pessoa);

                return RedirectToAction("Index", "PessoaFisica");
            }
            else
            {
                ViewBag.PessoaF = pessoa;
                
                return View("Index");
            }
        }




    }
}