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
    public class DIRECCIONController : Controller
    {
        private RH_VETE_SMPEntities db = new RH_VETE_SMPEntities();

        // GET: DIRECCION
        public ActionResult Index()
        {
            var dIRECCION = db.DIRECCION.Include(d => d.DISTRITO);
            return View(dIRECCION.ToList());
        }
        public ActionResult GuardarDireccion(Capa_Datos.DIRECCION direccion)
        {
            PERSONA Person = new PERSONA();
            db.DIRECCION.Add(direccion);
            db.SaveChanges();
            Person.ID_DIRECCION = direccion.ID_DIRECCION;
            var dIRECCION = db.DIRECCION.Include(d => d.DISTRITO);
            return RedirectToAction("../PERSONAs/Create");   
        }
        // GET: DIRECCION/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DIRECCION dIRECCION = db.DIRECCION.Find(id);
            if (dIRECCION == null)
            {
                return HttpNotFound();
            }
            return View(dIRECCION);
        }

        // GET: DIRECCION/Create
        public ActionResult Create()
        {
            ViewBag.ID_DISTRITO = new SelectList(db.DISTRITO, "ID_DISTRITO", "DESCRIPCION");
            return View();
        }

        // POST: DIRECCION/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_DIRECCION,ID_DISTRITO,OTRAS_SENAS")] DIRECCION dIRECCION)
        {
            if (ModelState.IsValid)
            {
                db.DIRECCION.Add(dIRECCION);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_DISTRITO = new SelectList(db.DISTRITO, "ID_DISTRITO", "DESCRIPCION", dIRECCION.ID_DISTRITO);
            return View(dIRECCION);
        }

        // GET: DIRECCION/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DIRECCION dIRECCION = db.DIRECCION.Find(id);
            if (dIRECCION == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_DISTRITO = new SelectList(db.DISTRITO, "ID_DISTRITO", "DESCRIPCION", dIRECCION.ID_DISTRITO);
            return View(dIRECCION);
        }

        // POST: DIRECCION/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_DIRECCION,ID_DISTRITO,OTRAS_SENAS")] DIRECCION dIRECCION)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dIRECCION).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_DISTRITO = new SelectList(db.DISTRITO, "ID_DISTRITO", "DESCRIPCION", dIRECCION.ID_DISTRITO);
            return View(dIRECCION);
        }

        // GET: DIRECCION/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DIRECCION dIRECCION = db.DIRECCION.Find(id);
            if (dIRECCION == null)
            {
                return HttpNotFound();
            }
            return View(dIRECCION);
        }

        // POST: DIRECCION/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DIRECCION dIRECCION = db.DIRECCION.Find(id);
            db.DIRECCION.Remove(dIRECCION);
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
