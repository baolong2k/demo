using Ictshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Ictshop.Areas.Admin.Controllers
{
    public class LienHeAdminController : Controller
    {
        // GET: Admin/LienHeAdmin
        private Qlbanhang db = new Qlbanhang();
        public ActionResult Index(string searching)
        {
            return View(db.Contacts.Where(x => x.Name.Contains(searching) || searching == null ).ToList());
        }

        // GET: Admin/LienHeAdmin/Details/5
        public ActionResult Details(int? id)
        { 
            if(id==null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Contact con = db.Contacts.Find(id);
            if(con ==null)
            {
                return HttpNotFound();
            }
            return View(con);
        }

        // GET: Admin/LienHeAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/LienHeAdmin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/LienHeAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/LienHeAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/LienHeAdmin/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact con = db.Contacts.Find(id);
            if(con==null)
            {
                return HttpNotFound();
            }
            return View(con);
        }

        // POST: Admin/LienHeAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contact con = db.Contacts.Find(id);
            db.Contacts.Remove(con);
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
