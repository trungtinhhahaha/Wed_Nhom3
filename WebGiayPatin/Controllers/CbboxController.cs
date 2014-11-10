using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGiayPatin;
using WebGiayPatin.ServiceReferenceUser;

namespace WebGiayPatin.Controllers
{
    public class CbboxController : Controller
    {
        UserWedClient ussv = new UserWedClient();
        public ActionResult CbbDanhmuc() 
        {
            var pl = ussv.FindAllPhanLoai();
            return View(pl);
        }
        public ActionResult CbbDMuc(string phanloai) //Combobox Danh mục
        {
            if (phanloai == null)
                phanloai = "-1";
            ViewBag.phanloai = phanloai;
            var pl = ussv.FindAllPhanLoai();
            return View(pl);
        }
    }
}
