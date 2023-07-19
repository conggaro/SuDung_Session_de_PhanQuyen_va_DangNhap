using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoc_Session.Areas.Admin.Controllers
{
    public class TrangChu_AdminController : Controller
    {
        // GET: Admin/TrangChu_Admin
        public ActionResult View_TrangChu_Admin()
        {
            // tạo ViewBag tiêu đề
            ViewBag.tieu_de = $"Admin";

            // tạo ViewBag thông báo
            ViewBag.thong_bao = $"Đây là trang Admin";

            // nếu Session["PhanQuyen"]
            // là "admin"
            // thì mới cho truy cập trang admin
            if (Session["PhanQuyen"] == "admin")
            {
                return View();
            }

            // nếu Session["PhanQuyen"]
            // khác "admin"
            // thì bắt đăng nhập
            return RedirectToAction("View_DangNhap", "DangNhap", new { area = ""});
        }
    }
}