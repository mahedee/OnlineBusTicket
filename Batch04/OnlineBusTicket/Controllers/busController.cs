using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineBusTicket.Models;

namespace OnlineBusTicket.Controllers
{
    public class busController : Controller
    {
        private dbContext db = new dbContext();

        // GET: /bus/
        public ActionResult Index()
        {
            var bus = db.Bus.Include(b => b.objCompany);
            return View(bus.ToList());
        }

        // GET: /bus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bus bus = db.Bus.Find(id);
            if (bus == null)
            {
                return HttpNotFound();
            }
            return View(bus);
        }

        // GET: /bus/Create
        public ActionResult Create()
        {
            ViewBag.companyId = new SelectList(db.Company, "companyId", "companName");
            return View();
        }

        // POST: /bus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="busId,busNo,busCapacity,busStatus,companyId")] Bus bus)
        {
            if (ModelState.IsValid)
            {
                db.Bus.Add(bus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.companyId = new SelectList(db.Company, "companyId", "companName", bus.companyId);
            return View(bus);
        }

        // GET: /bus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bus bus = db.Bus.Find(id);
            if (bus == null)
            {
                return HttpNotFound();
            }
            ViewBag.companyId = new SelectList(db.Company, "companyId", "companName", bus.companyId);
            return View(bus);
        }

        // POST: /bus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="busId,busNo,busCapacity,busStatus,companyId")] Bus bus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.companyId = new SelectList(db.Company, "companyId", "companName", bus.companyId);
            return View(bus);
        }

        // GET: /bus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bus bus = db.Bus.Find(id);
            if (bus == null)
            {
                return HttpNotFound();
            }
            return View(bus);
        }

        // POST: /bus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bus bus = db.Bus.Find(id);
            db.Bus.Remove(bus);
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
