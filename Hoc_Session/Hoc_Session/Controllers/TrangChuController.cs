using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hoc_Session.Controllers
{
    public class TrangChuController : Controller
    {
        // GET: TrangChu
        public ActionResult View_TrangChu()
        {
            // tạo ViewBag tiêu đề
            ViewBag.tieu_de = $"Trang chủ ASP.NET MVC";

            // tạo ViewBag thông báo
            ViewBag.thong_bao = $"Đây là trang chủ";

            return View();
        }
    }
}