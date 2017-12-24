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
    
    public class Table_1Controller : Controller
    {
        //private Model1 db = new Model1();
        private ITable_1Repository db;
        public Table_1Controller()
        {
            this.db = new EFTable_1Repository();
        }
        public Table_1Controller(ITable_1Repository db)
        {
            this.db = db;
        }
        //GET: Table_1
        public ViewResult Index()
        {
            return View(db.Table_1.ToList());
        }
        //[AllowAnonymous]
        // GET: Table_1/Details/5
        public ViewResult Details(int? id)
        {
            if (id == null)
            {
                return View("Error");
            }
            Table_1 table_1 = db.Table_1.FirstOrDefault(a => a.Carid == id);
            if (table_1 == null)
            {
                return View("Error");
            }
            return View(table_1);
        }

        //// GET: Table_1/Create
        //[Authorize]
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Table_1/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Carid,cars,companyname,price")] Table_1 table_1)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Table_1.Add(table_1);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(table_1);
        //}

        // GET: Table_1/Edit/5
        //[Authorize]
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Table_1 table_1 = db.Table_1.Find(id);
        //    if (table_1 == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(table_1);
        //}

        //// POST: Table_1/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Authorize]
        //public ActionResult Edit([Bind(Include = "Carid,cars,companyname,price")] Table_1 table_1)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(table_1).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(table_1);
        //}

        //// GET: Table_1/Delete/5
        //[Authorize]
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Table_1 table_1 = db.Table_1.Find(id);
        //    if (table_1 == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(table_1);
        //}

        // POST: Table_1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ViewResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return View("Error");
            }

            Table_1 table_1 = db.Table_1.FirstOrDefault(a => a.Carid == id);

            if (table_1 == null)
            {
                return View("Error");
            }

            db.Delete(table_1);

            return View("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
