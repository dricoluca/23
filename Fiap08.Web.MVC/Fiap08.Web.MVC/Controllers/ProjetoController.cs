using Fiap08.Web.MVC.Models;
using Fiap08.Web.MVC.Units;
using Fiap08.Web.MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap08.Web.MVC.Controllers
{
    public class ProjetoController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var viewModel = new ProjetoViewModel();
            viewModel.Patrocinadores = 
                new SelectList(_unit.PatrocinadorRepository.Listar(),
                "PatrocinadorId","Nome");
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Cadastrar(Projeto projeto)
        {
            _unit.ProjetoRepository.Cadastrar(projeto);
            _unit.Salvar();
            TempData["msg"] = "Cadastrou!";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}