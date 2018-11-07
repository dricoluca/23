using Fiap05.Web.MVC.Models;
using Fiap05.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap05.Web.MVC.Controllers
{
    public class CartaoRealController : Controller
    {
        private FiapBankContext _context = new FiapBankContext();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_context.CartoesReais.ToList());
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(CartaoReal cartao)
        {
            _context.CartoesReais.Add(cartao);
            _context.SaveChanges();
            TempData["msg"] = "Cartão registrado!";
            return RedirectToAction("Cadastrar");
        }
    }
}