using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrimerTurno.DAL;
using PrimerTurno.Models;

namespace PrimerTurno.Controllers
{
    public class UsuariosController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Usuarios
        public ActionResult Index()
        {
            return View(db.Usuarios.ToList());
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // GET: Usuarios/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Usuario usuario = db.Personas.Find(id);
        //    if (usuario == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(usuario);
        //}

        // GET: Usuarios/Create        
        public ActionResult Crear()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear([Bind(Include = "DNI,Apellido,Nombre,TipoT,UsuarioNombre,Password")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Personas.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Usuario usuario = db.Personas.Find(id);
        //    if (usuario == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(usuario);
        //}

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "DNI,Apellido,Nombre,TipoT,UsuarioNombre,Password")] Usuario usuario)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(usuario).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(usuario);
        //}

        //// GET: Usuarios/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Usuario usuario = db.Personas.Find(id);
        //    if (usuario == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(usuario);
        //}

        //// POST: Usuarios/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Usuario usuario = db.Personas.Find(id);
        //    db.Personas.Remove(usuario);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool isValid(string usuario, string password)
        {
            bool isValid = false;
            Usuario user = db.Usuarios.Find(usuario);

            if (user != null && user.Password == password)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
