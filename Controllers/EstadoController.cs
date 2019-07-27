using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trabalho_das_Férias.Controllers
{
    public class EstadoController : Controller
    {
        // GET: Estado
        EstadoRepository repository = new EstadoRepository();
        public ActionResult Index()
        {
            List<Estado> estados = repository.ObterTodos("");
            ViewBag.Estados = estados;
            return View();
        }
        public ActionResult Cadastro(string nome, string sigla)
        {
            Estado estado = new Estado();
            estado.Nome = nome;
            estado.Sigla = sigla;
            int id = repository.Inserir(estado);
            return RedirectToAction("Index");
        }
    }
}