using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FamousFitnessModels.Models;

namespace FamousFitnessModels.Controllers
{
    public class FitnessMsController : Controller
    {
        private FitnessModelsDataEntities db = new FitnessModelsDataEntities();

        // GET: FitnessMs
        public ActionResult Index()
        {
            return View(db.FitnessMs.ToList());
        }

        // GET: FitnessMs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FitnessM fitnessM = db.FitnessMs.Find(id);
            if (fitnessM == null)
            {
                return HttpNotFound();
            }
            return View(fitnessM);
        }

        // GET: FitnessMs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FitnessMs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Photo,Name,BirthPlace,DateOfBirth,Height,Weight")] FitnessM fitnessM)
        {

            if (ModelState.IsValid)
            {
                db.FitnessMs.Add(fitnessM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            

            return View(fitnessM);
        }

        // GET: FitnessMs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FitnessM fitnessM = db.FitnessMs.Find(id);
            if (fitnessM == null)
            {
                return HttpNotFound();
            }
            return View(fitnessM);
        }

        // POST: FitnessMs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,Name,BirthPlace,DateOfBirth,Height,Weight")] FitnessM fitnessM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fitnessM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fitnessM);
        }

        // GET: FitnessMs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FitnessM fitnessM = db.FitnessMs.Find(id);
            if (fitnessM == null)
            {
                return HttpNotFound();
            }
            return View(fitnessM);
        }

        // POST: FitnessMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FitnessM fitnessM = db.FitnessMs.Find(id);
            db.FitnessMs.Remove(fitnessM);
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
