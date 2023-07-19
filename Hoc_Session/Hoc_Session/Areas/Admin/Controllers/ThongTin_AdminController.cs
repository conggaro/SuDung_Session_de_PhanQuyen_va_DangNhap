using Hoc_Session.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoc_Session.Areas.Admin.Controllers
{
    public class ThongTin_AdminController : Controller
    {
        // GET: Admin/ThongTin_Admin
        public ActionResult View_ThongTin_Admin()
        {
            // tạo ViewBag tiêu đề
            ViewBag.tieu_de = $"Thông tinAdmin";

            // tạo ViewBag thông báo
            ViewBag.thong_bao = $"Đây là trang thông tin Admin";

            // tạo đối tượng db
            QuanLyMatHangEntities db = new QuanLyMatHangEntities();

            if (Session["PhanQuyen"] == "admin")
            {
                // tạo đối tượng dt
                // để hứng dữ liệu của Session["DoiTuong_DangNhap_ThanhCong"]
                var dt = Session["DoiTuong_DangNhap_ThanhCong"];

                return View(dt);
            }

            return RedirectToAction("View_DangNhap", "DangNhap", new { area = "" });
        }
    }
}