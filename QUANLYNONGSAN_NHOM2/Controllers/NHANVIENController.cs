using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using QUANLYNONGSAN_NHOM2.Models;
using System.Configuration;
using System.Data;
using System.IO;
namespace QUANLYNONGSAN_NHOM2.Controllers
{
    public class NHANVIENController : Controller
    {
        // GET: NhanVien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Eror()
        {
            return View();
        }
        public ActionResult show_NV()
        {
            List<NHANVIEN> list = new List<NHANVIEN>();
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM NHANVIEN  Order by TENNV";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var a = new NHANVIEN()
                        {
                            MANV = reader["MANV"].ToString(),
                            TENNV = reader["TENNV"].ToString(),
                            EMAIL = reader["EMAIL"].ToString(),
                            SODT = reader["SODT"].ToString(),
                        };
                        list.Add(a);
                    }
                    return View(list);

                }
                catch (Exception exception)
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
        public ActionResult Detail_NV(string id)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM NHANVIEN WHERE MANV = @MANV";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMANV = new SqlParameter("@MANV", id);
                    cmd.Parameters.Add(paraMANV);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            var a = new NHANVIEN()
                            {
                                MANV = reader["MANV"].ToString(),
                                TENNV = reader["TENNV"].ToString(),
                                EMAIL= reader["EMAIL"].ToString(),
                                SODT = reader["SODT"].ToString(),
                               
                            };
                            return View(a);
                        }
                    }
                    return View();
                }
                catch (Exception exception)
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
        public ActionResult Update_NV(NHANVIEN a)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "UPDATE NHANVIEN SET TENNV = @TENNV, EMAIL = @EMAIL, SODT = @SODT, MATK = @MATK where MANV = @MANV";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMANV = new SqlParameter("@MANV", a.MANV);
                    SqlParameter paraTENNV = new SqlParameter("@TENNV", a.TENNV);
                    SqlParameter paraEMAIL = new SqlParameter("@EMAIL", a.EMAIL);
                    SqlParameter paraSODT = new SqlParameter("@SODT", a.SODT);


                    cmd.Parameters.Add(paraMANV);
                    cmd.Parameters.Add(paraTENNV);
                    cmd.Parameters.Add(paraEMAIL);
                    cmd.Parameters.Add(paraSODT);
                
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return RedirectToAction("show_NV");
                    }
                    return View();
                }
                catch (Exception exception)
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
        public ActionResult Delete_NV(string id)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "DELETE FROM NHANVIEN WHERE MANV = @MANV";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMANV = new SqlParameter("@MANV", id);
                    cmd.Parameters.Add(paraMANV);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return RedirectToAction("show_NV");
                    }
                    return RedirectToAction("Eror");
                }
                catch (Exception exception)
                {
                    return RedirectToAction("Eror");
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
        public ActionResult Create_NV(NHANVIEN a)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {


                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM NHANVIEN WHERE MANV = @MANV";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;

                    if (string.IsNullOrEmpty(a.MANV))
                    {
                        return View();
                    }

                    SqlParameter paraMANV = new SqlParameter("@MANV", a.MANV);
                    SqlParameter paraTENNV = new SqlParameter("@TENNV", a.TENNV);
                    SqlParameter paraEMAIL = new SqlParameter("@EMAIL", a.EMAIL);
                    SqlParameter paraSODT = new SqlParameter("@SODT", a.SODT);
                    SqlParameter paraTAIKHOAN = new SqlParameter("@TAIKHOAN", a.TAIKHOAN);
                    SqlParameter paraMATKHAU = new SqlParameter("@MATKHAU", a.MATKHAU);



                    cmd.Parameters.Add(paraMANV);
                    cmd.Parameters.Add(paraTENNV);
                    cmd.Parameters.Add(paraEMAIL);
                    cmd.Parameters.Add(paraSODT);
                    cmd.Parameters.Add(paraTAIKHOAN);
                    cmd.Parameters.Add(paraMATKHAU);

                    var reader = cmd.ExecuteReader();
                    if (reader == null || reader.HasRows)
                    {
                        return View();
                    }
                    reader.Close();
                    cmd.CommandText = "insert into NHANVIEN(MANV, TENNV, EMAIL, SODT, TAIKHOAN,MATKHAU) values (@MANV,@TENNV,@EMAIL,@SODT,@TAIKHOAN,@MATKHAU)";
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return RedirectToAction("show_NV");
                    }
                    return View();

                }
                catch (Exception exception)
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
        //public PartialViewResult _menu()
        //{
        //    List<NhanVien> list = new List<NhanVien>();
        //    using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QUANLYNONGSAN_NHOM2"].ConnectionString)) ;
        //    {
        //        try
        //        {

        //            return PartialView(list);
        //        }
        //        catch(Exception exception)
        //        {
        //            return PartialView();
        //        }
        //        finally
        //        {
        //            if(connect)
        //        }

        //    }
        //}


    }
}