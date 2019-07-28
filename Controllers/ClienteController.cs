using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trabalho_das_Férias.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepository repository;

        public ClienteController()
        {
            repository = new ClienteRepository();
        }

        // GET: Cliente
        public ActionResult Index()
        {
            List<Cliente> clientes = repository.ObterTodos();
            ViewBag.Clientes = clientes;
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Store(int idCidade, string nome, string cpf, DateTime dataNascimento, int numero, string complemento, string logradouro, string cep)
        {
            Cliente cliente = new Cliente();
            cliente.IdCidade = idCidade;
            cliente.Nome = nome;
            cliente.Cpf = cpf;
            cliente.DataNascimento = dataNascimento;
            cliente.Numero = numero;
            cliente.Complemento = complemento;
            cliente.Logradouro = logradouro;
            cliente.Cep = cep;
            repository.Inserir(cliente);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            return View();
        }

        public ActionResult Apagar(int id)
        {
            repository.Apagar(id);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int idCidade, string nome, string cpf, DateTime dataNascimento, int numero, string complemento, string logradouro, string cep)
        {
            return View();
        }
    }
}