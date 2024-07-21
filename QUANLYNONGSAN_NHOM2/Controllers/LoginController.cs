using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using QUANLYNONGSAN_NHOM2.Models;
using System.Configuration;

namespace QUANLYNONGSAN_NHOM2.Controllers
{
    public class LoginController : Controller
    {
        //create account
        public ActionResult TAOKHOAN(KHACHHANG a)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM KHACHHANG where TAIKHOAN = @TAIKHOAN";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    SqlParameter paraTENKH = new SqlParameter("@TENKH", a.HOTEN);
                    SqlParameter paraGIOITINH = new SqlParameter("@GIOITINH", a.GIOITINH);
                    SqlParameter paraDIACHI = new SqlParameter("@DIACHI", a.DIACHI);
                    SqlParameter paraSODIENTHOAI = new SqlParameter("@SODIENTHOAI", a.SODT);
                    SqlParameter paraNGAYSINH = new SqlParameter("@NGAYSINH", a.NGAYSINH);
                    SqlParameter paraTAIKHOAN = new SqlParameter("@TAIKHOAN",a.TAIKHOAN);
                    SqlParameter paraMATKHAU = new SqlParameter("@MATKHAU", a.MATKHAU);
                    SqlParameter paraEMAIL = new SqlParameter("@EMAIL",a.EMAIL);

                    cmd.Parameters.Add(paraDIACHI);
                    cmd.Parameters.Add(paraEMAIL);
                    cmd.Parameters.Add(paraGIOITINH);
                    cmd.Parameters.Add(paraTENKH);
                    cmd.Parameters.Add(paraSODIENTHOAI);
                    cmd.Parameters.Add(paraNGAYSINH);
                    cmd.Parameters.Add(paraTAIKHOAN);
                    cmd.Parameters.Add(paraMATKHAU);

                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        ViewBag.ErrorMessage = "Đăng nhập thất bại. Vui lòng kiểm tra thông tin đăng nhập.";
                        return View();
                    }
                    reader.Close();
                    cmd.CommandText = "insert into KHACHHANG(HOTEN, DIACHI, SODT, EMAIL, NGAYSINH, GIOITINH, TAIKHOAN, MATKHAU) values (@TENKH, @DIACHI, @SODIENTHOAI, @EMAIL, @NGAYSINH, @GIOITINH, @TAIKHOAN, @MATKHAU)";
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return RedirectToAction("User_LOGIN");
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Đăng nhập thất bại. Vui lòng kiểm tra thông tin đăng nhập.";
                        return View();
                    }
                }
                catch
                {
                    ViewBag.ErrorMessage = "Đăng nhập thất bại. Vui lòng kiểm tra thông tin đăng nhập.";
                    return View();
                }
                finally
                {
                    if (connect.State != ConnectionState.Closed)
                    {
                        connect.Close();
                    }
                }
            }
          
            
        }


        // GET: Login
        public ActionResult User_LOGIN(string tk, string mk)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM KHACHHANG WHERE TAIKHOAN = @TAIKHOAN AND MATKHAU = @MATKHAU";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    SqlParameter paraTK = new SqlParameter("@TAIKHOAN", tk);
                    SqlParameter paraMk = new SqlParameter("@MATKHAU", mk);
                    cmd.Parameters.Add(paraTK);
                    cmd.Parameters.Add(paraMk);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            return RedirectToAction("main", "Home");
                        }
                    }
                    return View();
                }
                catch
                {
                    return View();
                }
                finally
                {
                    if (connect.State != ConnectionState.Closed)
                    {
                        connect.Close();
                    }
                }
            }
        }
    
    public ActionResult ADMIN_LOGIN(string tk , string mk)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM NHANVIEN WHERE TAIKHOAN = @TAIKHOAN AND MATKHAU = @MATKHAU";
                    SqlCommand cmd = new SqlCommand(sql,connect);
                    SqlParameter paraTK = new SqlParameter("@TAIKHOAN", tk);
                    SqlParameter paraMk = new SqlParameter("@MATKHAU",mk);
                    cmd.Parameters.Add(paraTK);
                    cmd.Parameters.Add(paraMk);

                    var reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        if(reader.HasRows)
                        {
                            return RedirectToAction("Admin","Home");
                        }
                    }
                    return View();
                }
                catch
                {
                    return View();
                }
                finally
                {
                    if(connect.State != ConnectionState.Closed)
                    {
                        connect.Close();
                    }
                }
            } 
        }
    }
}