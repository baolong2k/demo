using Ictshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ictshop.Controllers
{
    public class TatCaSanPhamController : Controller
    {
        // GET: TatCaSanPham
        private Qlbanhang db = new Qlbanhang();
        public ActionResult Index()
        {
            return View(db.Sanphams.ToList());
        }
    }
}