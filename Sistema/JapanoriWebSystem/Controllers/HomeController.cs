using JapanoriWebSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace JapanoriWebSystem.Controllers
{
    public class HomeController : Controller
    {
        //acoesLogin acLg = new acoesLogin();

        public ActionResult Login()
        {
            return View();
        }

        /*[HttpPost]
        public ActionResult Login(modelLogin verLogin)
        {
            /*acLg.TestarUsuario(verLogin);

            if (verLogin.usuario != null && verLogin.senha != null)
            {
                FormsAuthentication.SetAuthCookie(verLogin.usuario, false);
                Session["usuarioLogado"] = verLogin.usuario.ToString();
                Session["senhaLogado"] = verLogin.senha.ToString();

                if (verLogin.perm == "1")
                {
                    Session["tipoLogado1"] = verLogin.perm.ToString(); //=1;
                }
                else
                {
                    Session["tipoLogado2"] = verLogin.perm.ToString();//=2
                }


                return RedirectToAction("Hub", "Home");
            }

            else
            {
                ViewBag.msgLogar = "Usuário não encontrado. Verifique o nome do usuário e a senha";
                return View();

            }
            return View();
        }*/

        public ActionResult Hub()
        {
            /*if ((Session["usuarioLogado"] == null) || (Session["senhaLogado"] == null))

            {
                return RedirectToAction("semAcesso", "Home");
            }
            else
            {

                ViewBag.usuarioLog = Session["usuarioLogado"];
                return View();
            }*/
            return View();
        }

        public ActionResult Contact()
        {
            /*if ((Session["usuarioLogado"] == null) || (Session["senhaLogado"] == null))
            {
                return RedirectToAction("semAcesso", "Home");
            }
            else
            {
                if (Session["tipoLogado2"] == null)
                {
                    return RedirectToAction("semAcesso", "Home");
                }
                else
                {
                    ViewBag.Message = "Your contact page.";

                    return View();
                }
            }*/
            return View();
        }

        public ActionResult Logout()
        {
            /*Session["usuarioLogado"] = null;
            Session["senhaLogado"] = null;
            Session["tipoLogado1"] = null;
            Session["tipoLogado2"] = null;
            return RedirectToAction("Login", "Home");*/
            return RedirectToAction("Login", "Home");
        }

#pragma warning disable IDE1006 // Estilos de Nomenclatura
        public ActionResult semAcesso()
#pragma warning restore IDE1006 // Estilos de Nomenclatura
        {
            ViewBag.Message = "Você não pode acessar essa página";

            return View();
        }
    }
}