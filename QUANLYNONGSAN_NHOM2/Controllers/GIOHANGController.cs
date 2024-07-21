using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using QUANLYNONGSAN_NHOM2.Models;

namespace QUANLYNONGSAN_NHOM2.Controllers
{
    public class GIOHANGController : Controller
    {
        List<GIOHANG> list = new List<GIOHANG>();
        // GET: GIOHANG
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult ThemGioHang(string Id,string strURL)
        {
            var GioHang = LayGioHang();

            GIOHANG giohang = GioHang.Find(x => x.NONG.MANS.Trim() == Id);
            if (giohang != null)
            {
                giohang.SoLuong++;
            } else
            {
                giohang = new GIOHANG(Id);
                GioHang.Add(giohang);
            }
            return Redirect(strURL);
        }

        public ActionResult GioHang()
        {
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("main", "Home");
            }
            List<GIOHANG> giohang = LayGioHang();
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongThanhTien = TongThanhTien();
            return View(giohang);
           
        }

        public List<GIOHANG> LayGioHang()
        {
            var GioHang = Session["GioHang"] as List<GIOHANG>;
            if (GioHang == null)
            {
                GioHang = new List<GIOHANG>();
                Session["GioHang"] = GioHang;
            }
            return GioHang;
        }



        private int TongSoLuong()
        {
            int tongsoluong = 0;
            List<GIOHANG> listGioHang = Session["GioHang"] as List<GIOHANG>;
            if(listGioHang != null)
            {
                tongsoluong = listGioHang.Sum(sp => sp.SoLuong);
            }
            return tongsoluong;
        }

        private double TongThanhTien()
        {
            double tongthanhtien = 0;
            List<GIOHANG> list = Session["GioHang"] as List<GIOHANG>;
            if(list != null)
            {
                tongthanhtien = tongthanhtien + list.Sum(sp => sp.ThanhTien);
            }
            return tongthanhtien;
        }

        public ActionResult delete(string id)
        {
            var giohang = LayGioHang();
            GIOHANG sp = giohang.Find(s => s.NONG.MANS == id);
            if(sp != null)
            {
                if (sp.SoLuong > 1)
                {
                    sp.SoLuong--;
                    return RedirectToAction("GioHang", "GIOHANG");
                }
                else
                {
                    giohang.Remove(sp);
                    return RedirectToAction("GioHang", "GIOHANG");
                }
            }
            if(giohang.Count == 0)
            {
                return RedirectToAction("main","Home");
            }
            return RedirectToAction("GioHang", "GIOHANG");
        }

      
    }
}