using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Capa_Datos;
using Microsoft.Ajax.Utilities;
using System.Windows;
using System.IO;

namespace PG_VETE_SMP.Controllers
{
    public class USUARIOController : Controller
    {
        private RH_VETE_SMPEntities db = new RH_VETE_SMPEntities();

        // GET: USUARIO
        public ActionResult Index()
        {
            var uSUARIO = db.USUARIO.Include(u => u.PERSONA).Include(u => u.TIPO_USUARIO);
            return View(uSUARIO.ToList());
        }

        public ActionResult Acceso()
        {

            return View("Acceso");

        }

        public ActionResult AccesoUsuario(USUARIO oUSUARIO)
        {
            
            var user = db.USUARIO.Find(oUSUARIO.NOMBRE_USUARIO);
            Session["NOMBRE_USUARIO"] = oUSUARIO.NOMBRE_USUARIO;
            Session["CONTRASENA"] = oUSUARIO.CONTRASENA;
            if (oUSUARIO.NOMBRE_USUARIO == user.NOMBRE_USUARIO)
            {
                if (oUSUARIO.CONTRASENA == user.CONTRASENA)
                {
                    
                    return View("../Home/Index");
                }
                else
                {
                    oUSUARIO.NOMBRE_USUARIO = "".ToString();
                    return View("Acceso");
                  
                }
            }
            else
            {
                return View("Acceso");
            }
        }

    }
}
