using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGiayPatin.ServiceReferenceUser;
using PagedList;

namespace WebGiayPatin.Controllers
{
    public class DefaultController : Controller
    {
        UserWedClient ussv = new UserWedClient();
        public ActionResult Index(int? page)
        {
            int pageSize = 6;
            int pageNum = (page ?? 1);
            ViewBag.page1 = page;
            var spmoi = ussv.FindAllSPMoi();
            var spnoibat = ussv.FindAllSPNoiBat();
            ViewBag.spnoibat = spnoibat;
            return View(spmoi.ToPagedList(pageNum, pageSize));
        }
        public ActionResult PLSanPham(int? page, string phanloai)
        {
            int pageSize = 6;
            int pageNum = (page ?? 1);
            ViewBag.page1 = page;
            ViewBag.phanloai = phanloai;
            var sp = ussv.FindAllSPPhanLoai(phanloai);
            return View(sp.ToPagedList(pageNum, pageSize));
        }
        public ActionResult Chitietsp(string masp)
        {
            var sp = ussv.FindSanPham(masp);
            string pl = ussv.FindPhanLoai(sp.MaLoai);
            ViewBag.tenloai = pl;
            return View(sp);
        }
        public ActionResult Timkiem(int? page, string timkiem)
        {
            int pageSize = 6;
            int pageNum = (page ?? 1);
            ViewBag.page1 = page;
            ViewBag.timkiem = timkiem;
            var sp = ussv.FindTimKiemCB(timkiem);
            return View(sp.ToPagedList(pageNum, pageSize));
        }
        public ActionResult Timkiemnangcao(int? page, string timkiemnc, string phanloai, int giatu, int giaden)
        {
            int pageSize = 6;
            int pageNum = (page ?? 1);
            ViewBag.page1 = page;
            ViewBag.timkiem = timkiemnc;
            ViewBag.phanloai = phanloai;
            ViewBag.giatu = giatu;
            ViewBag.giaden = giaden;
            var sp = ussv.FindTimKiemNC(timkiemnc, phanloai, giatu, giaden);
            return View(sp.ToPagedList(pageNum, pageSize));
        }
        public ActionResult Gioithieu()
        {
            return View();
        }
        public ActionResult Dichvu()
        {
            return View();
        }
        public ActionResult Khuyenmai(int? page)
        {
            int pageSize = 6;
            int pageNum = (page ?? 1);
            ViewBag.page1 = page;
            var sp = ussv.FindAllSPKhuyenMai();
            return View(sp.ToPagedList(pageNum, pageSize));
        }
    }
}
