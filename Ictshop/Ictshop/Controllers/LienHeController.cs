using Ictshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ictshop.Controllers
{
    public class LienHeController : Controller
    {
        // GET: LienHe
        public ActionResult Index()
        {
            return View();
        }

        // GET: LienHe/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LienHe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LienHe/Create
        [HttpPost]
        public ActionResult Create(Contact con)
        {
            Qlbanhang db = new Qlbanhang();
            try
            {
                // TODO: Add insert logic here
                db.Contacts.Add(con);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LienHe/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LienHe/Edit/5
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

        // GET: LienHe/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LienHe/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
