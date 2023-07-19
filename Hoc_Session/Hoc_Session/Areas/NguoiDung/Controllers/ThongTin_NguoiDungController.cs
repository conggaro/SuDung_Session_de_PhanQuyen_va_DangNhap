using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoc_Session.Areas.NguoiDung.Controllers
{
    public class ThongTin_NguoiDungController : Controller
    {
        // GET: NguoiDung/ThongTin_NguoiDung
        public ActionResult View_ThongTin_NguoiDung()
        {
            // tạo ViewBag tiêu đề
            ViewBag.tieu_de = $"Thông tin người dùng";

            // tạo ViewBag thông báo
            ViewBag.thong_bao = $"Đây là trang thông tin người dùng";

            if (Session["PhanQuyen"] == "nguoi_dung")
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