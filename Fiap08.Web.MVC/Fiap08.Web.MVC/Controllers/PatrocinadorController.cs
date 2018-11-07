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
    public class PatrocinadorController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var viewModel = new PatrocinadorViewModel();
            viewModel.Patrocinadores =
                _unit.PatrocinadorRepository.Listar();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Cadastrar(Patrocinador patrocinador)
        {
            _unit.PatrocinadorRepository.Cadastrar(patrocinador);
            _unit.Salvar();
            TempData["msg"] = "Cadastrou";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}