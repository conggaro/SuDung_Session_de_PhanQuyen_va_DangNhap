using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoc_Session.Areas.NguoiDung.Controllers
{
    public class TrangChu_NguoiDungController : Controller
    {
        // GET: NguoiDung/TrangChu_NguoiDung
        public ActionResult View_TrangChu_NguoiDung()
        {
            // tạo ViewBag tiêu đề
            ViewBag.tieu_de = $"Người dùng";

            // tạo ViewBag thông báo
            ViewBag.thong_bao = $"Đây là trang người dùng";

            // nếu Session["PhanQuyen"]
            // là "nguoi_dung"
            // thì có quyền sử dụng trang chủ người dùng
            if (Session["PhanQuyen"] == "nguoi_dung")
            {
                return View();
            }


            // nếu không viết new { area = ""}
            // thì trình biên dịch nó lại điều hướng kiểu
            // https://localhost:44391/NguoiDung/DangNhap/View_DangNhap
            // như thế là bị sai

            // nếu viết new { area = ""}
            // thì trình biên dịch điều hướng kiểu
            // https://localhost:44391/DangNhap/View_DangNhap
            // như thế này mới đúng

            // đấy là tác dụng của new { area = ""}

            // nếu Session["PhanQuyen"]
            // khác "nguoi_dung"
            // thì bắt đăng nhập
            return RedirectToAction("View_DangNhap", "DangNhap", new { area = ""});
        }
    }
}