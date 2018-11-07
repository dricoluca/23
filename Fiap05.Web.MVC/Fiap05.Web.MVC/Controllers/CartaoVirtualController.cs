using Fiap05.Web.MVC.Models;
using Fiap05.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap05.Web.MVC.Controllers
{
    public class CartaoVirtualController : Controller
    {
        private FiapBankContext _context = new FiapBankContext();

        [HttpGet]
        public ActionResult Pesquisar(int numero)
        {
            var lista = _context.CartoesVirtuais
                .Where(c => c.CartaoRealId == numero).ToList();
            //Valores para o dropdown
            CarregarDropdown();
            //página listar, com a lista de cartões virtuais
            return View("Listar", lista);
        }

        private void CarregarDropdown()
        {
            var dropLista = _context.CartoesReais.ToList();
            ViewBag.listaCartao =
                new SelectList(dropLista, "CartaoRealId", "Numero");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _context.CartoesVirtuais
                            .Include("CartaoReal").ToList();
            //Valores para o dropdown
            CarregarDropdown();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Buscar todos os cartões reais do banco
            var lista = _context.CartoesReais.ToList();
            //Enviar para a página através da viewbag
            ViewBag.listaCartao = 
                new SelectList(lista, "CartaoRealId", "Numero");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(CartaoVirtual cartao)
        {
            _context.CartoesVirtuais.Add(cartao);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        }

    }
}