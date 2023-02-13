using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Capa_Datos;

namespace PG_VETE_SMP.Controllers
{
    public class PERSONAController : Controller
    {
        private RH_VETE_SMPEntities db = new RH_VETE_SMPEntities();

        // GET: PERSONA
        public ActionResult Index()
        {
            var pERSONA = db.PERSONA.Include(p => p.DIRECCION).Include(p => p.GENERO);
            return View(pERSONA.ToList());
        }

        // GET: PERSONA/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PERSONA pERSONA = db.PERSONA.Find(id);
            if (pERSONA == null)
            {
                return HttpNotFound();
            }
            return View(pERSONA);
        }

        // GET: PERSONA/Create
        public ActionResult Create()
        {
            ViewBag.ID_DIRECCION = new SelectList(db.DIRECCION, "ID_DIRECCION", "OTRAS_SENAS");
            ViewBag.ID_GENERO = new SelectList(db.GENERO, "ID_GENERO", "DESCRIPCION");
            return View();
        }

        // POST: PERSONA/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CEDULA,NOMBRE,APELLIDO_1,APELLIDO_2,FECHA_NACIMIENTO,ID_DIRECCION,ID_GENERO")] PERSONA pERSONA)
        {
            if (ModelState.IsValid)
            {
                db.PERSONA.Add(pERSONA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_DIRECCION = new SelectList(db.DIRECCION, "ID_DIRECCION", "OTRAS_SENAS", pERSONA.ID_DIRECCION);
            ViewBag.ID_GENERO = new SelectList(db.GENERO, "ID_GENERO", "DESCRIPCION", pERSONA.ID_GENERO);
            return View(pERSONA);
        }

        // GET: PERSONA/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PERSONA pERSONA = db.PERSONA.Find(id);
            if (pERSONA == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_DIRECCION = new SelectList(db.DIRECCION, "ID_DIRECCION", "OTRAS_SENAS", pERSONA.ID_DIRECCION);
            ViewBag.ID_GENERO = new SelectList(db.GENERO, "ID_GENERO", "DESCRIPCION", pERSONA.ID_GENERO);
            return View(pERSONA);
        }

        // POST: PERSONA/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CEDULA,NOMBRE,APELLIDO_1,APELLIDO_2,FECHA_NACIMIENTO,ID_DIRECCION,ID_GENERO")] PERSONA pERSONA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pERSONA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_DIRECCION = new SelectList(db.DIRECCION, "ID_DIRECCION", "OTRAS_SENAS", pERSONA.ID_DIRECCION);
            ViewBag.ID_GENERO = new SelectList(db.GENERO, "ID_GENERO", "DESCRIPCION", pERSONA.ID_GENERO);
            return View(pERSONA);
        }

        // GET: PERSONA/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PERSONA pERSONA = db.PERSONA.Find(id);
            if (pERSONA == null)
            {
                return HttpNotFound();
            }
            return View(pERSONA);
        }

        // POST: PERSONA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PERSONA pERSONA = db.PERSONA.Find(id);
            db.PERSONA.Remove(pERSONA);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
