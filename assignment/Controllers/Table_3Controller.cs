using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using assignment.Models;

namespace assignment.Controllers
{
    
    public class Table_3Controller : Controller
    {
        private Model1 db = new Model1();

        // GET: Table_3
        public ActionResult Index()
        {
            var table_3 = db.Table_3.Include(t => t.Table_1);
            return View(table_3.ToList());
        }

        // GET: Table_3/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_3 table_3 = db.Table_3.Find(id);
            if (table_3 == null)
            {
                return HttpNotFound();
            }
            return View(table_3);
        }

        // GET: Table_3/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.carid = new SelectList(db.Table_1, "Carid", "cars");
            return View();
        }

        // POST: Table_3/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cars,carid,price,company")] Table_3 table_3)
        {
            if (ModelState.IsValid)
            {
                db.Table_3.Add(table_3);
               
                return RedirectToAction("Index");
            }

            ViewBag.carid = new SelectList(db.Table_1, "Carid", "cars", table_3.carid);
            return View(table_3);
        }

        // GET: Table_3/Edit/5
        [Authorize]
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_3 table_3 = db.Table_3.Find(id);
            if (table_3 == null)
            {
                return HttpNotFound();
            }
            ViewBag.carid = new SelectList(db.Table_1, "Carid", "cars", table_3.carid);
            return View(table_3);
        }

        // POST: Table_3/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cars,carid,price,company")] Table_3 table_3)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_3).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.carid = new SelectList(db.Table_1, "Carid", "cars", table_3.carid);
            return View(table_3);
        }

        // GET: Table_3/Delete/5
        [Authorize]
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_3 table_3 = db.Table_3.Find(id);
            if (table_3 == null)
            {
                return HttpNotFound();
            }
            return View(table_3);
        }

        // POST: Table_3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Table_3 table_3 = db.Table_3.Find(id);
            db.Table_3.Remove(table_3);
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
