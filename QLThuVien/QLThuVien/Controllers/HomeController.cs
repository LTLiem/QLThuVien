using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLThuVien.Models;

namespace QLThuVien.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(nhanvien nv) //User
        {
            int MaLoaiNhanVien = 0;
            string TenLoaiNhanVien = "";
            string redirectPage = "";

            if (ModelState.IsValid)
            {
                using (ThuVienEntities TE = new ThuVienEntities())
                {
                    var v = TE.nhanvien.Where(a => (a.tenDangNhap.Equals(nv.tenDangNhap)
                                && a.matKhau.Equals(nv.matKhau))).FirstOrDefault();  
   
                    if (v != null)
                    {
                        Session["LogedUserID"] = v.maNhanVien.ToString();
                        Session["Username"] = v.tenDangNhap.ToString();
                        Session["Password "] = v.matKhau.ToString();

                        //ViewBag.LoginNotes ="<p>Để sử dụng chức năng của thư viện, vui lòng <a href=\"/Home/Login\">đăng nhập</a></p>"; 
                        MaLoaiNhanVien = Convert.ToInt32(v.LoaiNhanVien);
                        TenLoaiNhanVien = TE.loainhanvien.Where(i => i.id == MaLoaiNhanVien).FirstOrDefault().TenLoai;

                        switch (TenLoaiNhanVien)
                        {
                            case "Bien muc" :
                                redirectPage = "BienMucHome";
                                break;
                            case "Luu hanh":
                                redirectPage = "LuuHanhHome";
                                break;
                            case "QLDG":
                                redirectPage = "QLDocGiaHome";
                                break;
                        }
                        return RedirectToAction(redirectPage);
                    }
                    ViewBag.Message = "Mật khẩu hoặc tên đăng nhập không hợp lệ.";
                    return View(nv);
                }
            }
            return View(nv);
        }

        public ActionResult LuuHanhHome()
        {
            if(@Session["Username"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index");
        }
    }
}
