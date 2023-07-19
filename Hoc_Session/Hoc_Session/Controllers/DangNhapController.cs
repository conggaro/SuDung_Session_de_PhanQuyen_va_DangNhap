using Hoc_Session.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoc_Session.Controllers
{
    public class DangNhapController : Controller
    {
        // GET: DangNhap
        public ActionResult View_DangNhap()
        {
            return View();
        }

        // xử lý đăng nhập
        public ActionResult XuLy_DangNhap(string bien1, string bien2)
        {
            // tạo đối tượng db
            QuanLyMatHangEntities db = new QuanLyMatHangEntities();

            // tạo đối tượng query
            var dt_query = from item in db.TaiKhoan
                           where item.ten_tai_khoan == bien1 && item.mat_khau == bien2
                           select item;

            // tạo biến đếm
            int dem = dt_query.Count();

            // nếu đếm = 1
            // tức là đếm được 1 cái tài khoản hợp lệ
            if (dem == 1)
            {
                if (dt_query.ToList()[0].ten_tai_khoan == "admin")
                {
                    // thiết lập Session
                    // cho phân quyền
                    Session["PhanQuyen"] = "admin";

                    // thiết lập Session
                    // cho đối tượng đăng nhập thành công
                    Session["DoiTuong_DangNhap_ThanhCong"] = dt_query.ToList()[0];

                    // chuyển đến trang chủ Admin
                    // cùng với cái Session là "admin"

                    // vì bạn đã tạo thư mục Areas
                    // nên bạn phải có new { area = "Admin" }
                    // sản phẩm thu được
                    // là đường link
                    // như thế này
                    // https://localhost:44391/Admin/TrangChu_Admin/View_TrangChu_Admin
                    // phải đúng như này
                    // thì mới đăng nhập thành công
                    return RedirectToAction("View_TrangChu_Admin", "TrangChu_Admin", new { area = "Admin" });
                }
                else if (dt_query.ToList()[0].ten_tai_khoan != "admin")
                {
                    // nếu tên tài khoản
                    // khác "admin"
                    // thì chuyển đến trang người dùng
                    Session["PhanQuyen"] = "nguoi_dung";

                    // thiết lập Session
                    // cho đối tượng đăng nhập thành công
                    Session["DoiTuong_DangNhap_ThanhCong"] = dt_query.ToList()[0];

                    // chuyển đến trang chủ người dùng
                    // cùng với cái Session là "nguoi_dung"
                    return RedirectToAction("View_TrangChu_NguoiDung", "TrangChu_NguoiDung", new { area = "NguoiDung" });
                }
            }

            // nếu đăng nhập thất bại
            // thì chuyển đến trang đăng nhập
            return RedirectToAction("View_DangNhap", "DangNhap");
        }
    }
}