using Estacionamento_.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estacionamento_.Controllers
{
    public class PessoaJuridicaController : Controller
    {
        // GET: PessoaJuridica
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Visualiza(int id, string cnpj, string razao)
        { // int id
            PJuridicaDAO dao = new PJuridicaDAO();

            //  PessoaFisica pessoa = dao.BuscaPorCpf(cpf);

            ViewBag.Id    = id;
            ViewBag.Cnpj  = cnpj;
            ViewBag.Razao = razao;

            return View();
        }

    }
}