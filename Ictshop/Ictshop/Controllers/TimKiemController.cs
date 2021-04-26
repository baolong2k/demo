using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;
using PagedList;
namespace Ictshop.Controllers
{
    public class TimKiemController : Controller
    {
        // GET: TimKiem
        private Qlbanhang db = new Qlbanhang();
        [HttpPost]
        public ActionResult KetQuaTimKiem(FormCollection f, int? page)
        {
            string tukhoa = f["txtFind"].ToString();
            ViewBag.TuKhoa = tukhoa;
            List<Sanpham> kqtk = db.Sanphams.Where(n => n.Tensp.Contains(tukhoa)).ToList();
            //phan trang
            int pageNumber = (page ?? 1);
            int pageSize = 3;
            if(kqtk.Count == 0)
            {
                ViewBag.ThongBao = "Khong thay sp nao";
                return View(db.Sanphams.OrderBy(n => n.Tensp).ToPagedList(pageNumber, pageSize));
            }
            tukhoa = "";
            return View(kqtk.OrderBy(n => n.Tensp).ToPagedList(pageNumber,pageSize));
        }
        [HttpGet]
        public ActionResult KetQuaTimKiem(string tukhoa, int? page)
        {
             
            List<Sanpham> kqtk = db.Sanphams.Where(n => n.Tensp.Contains(tukhoa)).ToList();
            //phan trang
            int pageNumber = (page ?? 1);
            int pageSize = 3;
            if (kqtk.Count == 0)
            {
                ViewBag.ThongBao = "Khong thay sp nao";
                return View(db.Sanphams.OrderBy(n => n.Tensp).ToPagedList(pageNumber, pageSize));
            }
            return View(kqtk.OrderBy(n => n.Tensp).ToPagedList(pageNumber, pageSize));
        }
    }
}