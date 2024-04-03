using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DotnetMvcDbFirst.Context;

namespace DotnetMvcDbFirst.Controllers
{
    public class FormController : Controller
    {
        private workoutEntities db = new workoutEntities();

        // GET: Form
        public ActionResult Index()
        {
            return View(db.MVCFORMs.ToList());
        }

        // GET: Form/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MVCFORM mVCFORM = db.MVCFORMs.Find(id);
            if (mVCFORM == null)
            {
                return HttpNotFound();
            }
            return View(mVCFORM);
        }

        // GET: Form/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Form/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RollNo,Name,Gender,DOB,Class,Address,Transport,Football,Kabadi,Coco,Cricket,Comments,Photo")] MVCFORM mVCFORM)
        {
            if (ModelState.IsValid)
            {
                db.MVCFORMs.Add(mVCFORM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mVCFORM);
        }

        // GET: Form/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MVCFORM mVCFORM = db.MVCFORMs.Find(id);
            if (mVCFORM == null)
            {
                return HttpNotFound();
            }
            return View(mVCFORM);
        }

        // POST: Form/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RollNo,Name,Gender,DOB,Class,Address,Transport,Football,Kabadi,Coco,Cricket,Comments,Photo")] MVCFORM mVCFORM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mVCFORM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mVCFORM);
        }

        // GET: Form/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MVCFORM mVCFORM = db.MVCFORMs.Find(id);
            if (mVCFORM == null)
            {
                return HttpNotFound();
            }
            return View(mVCFORM);
        }

        // POST: Form/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MVCFORM mVCFORM = db.MVCFORMs.Find(id);
            db.MVCFORMs.Remove(mVCFORM);
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
