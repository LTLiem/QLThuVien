using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLThuVien.Models;

namespace QLThuVien.Controllers
{
    public class QLDocGiaController : Controller
    {
        //
        // GET: /QLDocGia/
        
        public ActionResult ThemDocGia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createDocGia(FormCollection collection)
        {
            int t;
            ThuVienEntities data = new ThuVienEntities();
            docgia dg = new docgia();
            dg.ho = collection.GetValue("ho").AttemptedValue;
            dg.ten = collection.GetValue("ten").AttemptedValue;
            dg.gioiTinh = collection.GetValue("gioiTinh").AttemptedValue;
            dg.CMND = collection.GetValue("CMND").AttemptedValue;
            dg.MSSV = Convert.ToInt32(collection.GetValue("MSSV").AttemptedValue);
            dg.ngaySinh = Convert.ToDateTime(collection.GetValue("ngaySinh").AttemptedValue);
            dg.diaChi = collection.GetValue("diaChi").AttemptedValue;
            dg.maTheThuVien = Convert.ToInt32(collection.GetValue("maSoThe").AttemptedValue);
            dg.SDT = collection.GetValue("dienThoai").AttemptedValue;
            dg.anhDaidien = null;
            data.docgias.Add(dg);
            data.SaveChanges();
            return RedirectToAction("ThemDocGia");
        }
        
    }
}
