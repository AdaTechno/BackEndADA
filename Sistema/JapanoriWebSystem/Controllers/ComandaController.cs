using JapanoriWebSystem.Dados;
using JapanoriWebSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JapanoriWebSystem.Controllers
{
    public class ComandaController : Controller
    {
        acoesComanda ac = new acoesComanda();
        modelComanda db = new modelComanda();
       

        // GET: Comanda
        public ActionResult Consulta()
        {
            
            if ((Session["usuarioLogado"] == null) || (Session["senhaLogado"] == null))

            {
                return RedirectToAction("semAcesso", "Home");
            }
            else
            {
                ViewBag.usuarioLog = Session["usuarioLogado"];
                ModelState.Clear();

                return View(Tuple.Create<modelComanda, IEnumerable<modelComanda>>(new modelComanda(), ac.BuscarComanda()));
            }
        }
        
        [HttpPost]
        public ActionResult Consulta(modelComanda xpto)
        {
            
            if ((Session["usuarioLogado"] == null) || (Session["senhaLogado"] == null))

            {
                return RedirectToAction("semAcesso", "Home");
            }
            else
            {
                ViewBag.usuarioLog = Session["usuarioLogado"];


                ModelState.Clear();
                return View(Tuple.Create<modelComanda,IEnumerable<modelComanda>>(new modelComanda(), ac.selecionarBuscaComanda(xpto)));
            }
        }

        public ActionResult Inserir()
        {
            if ((Session["usuarioLogado"] == null) || (Session["senhaLogado"] == null))

            {
                return RedirectToAction("semAcesso", "Home");
            }
            else
            {

                ViewBag.usuarioLog = Session["usuarioLogado"];
                return View();
            }
        }

        public ActionResult Editar()
        {

            if ((Session["usuarioLogado"] == null) || (Session["senhaLogado"] == null))

            {
                return RedirectToAction("semAcesso", "Home");
            }
            else
            {

                ViewBag.usuarioLog = Session["usuarioLogado"];
                return View();
            }

        }

        public ActionResult Excluir()
        {

            if ((Session["usuarioLogado"] == null) || (Session["senhaLogado"] == null))

            {
                return RedirectToAction("semAcesso", "Home");
            }
            else
            {

                ViewBag.usuarioLog = Session["usuarioLogado"];
                return View();
            }

        }
    }
}