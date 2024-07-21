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
    public class NHASXController : Controller
    {
        // GET: NHASX
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Eror()
        {
            return View();
        }

        public ActionResult show_NSXCD(string id)
        {
            List<NHASX> list = new List<NHASX>();
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT MANS, TENNS, DONVITINH, GIA, NHASX.MANSX, ANH from NHASX ,NONGSAN  where NHASX.MANSX = NONGSAN.MANSX AND NHASX.MANSX = @MANHASX";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMANS = new SqlParameter("@MANHASX", id);
                    cmd.Parameters.Add(paraMANS);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            var a = new NHASX();
                            a.MANSX = reader["MANSX"].ToString();
                            a.nong = new NONGSAN()
                            {
                                MANSX = a.MANSX,
                                MANS = reader["MANS"].ToString(),
                                TENNS = reader["TENNS"].ToString(),
                                DONVITINH = reader["DONVITINH"].ToString(),
                                GIA = (int)reader["GIA"],
                                ANH = reader["ANH"].ToString(),
                            };
                            list.Add(a);
                        }
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

        public PartialViewResult _menu()
        {
            List<NHASX> list = new List<NHASX>();
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM NHASX";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var a = new NHASX()
                        {
                            MANSX = reader["MANSX"].ToString(),
                            TENNSX = reader["TENNSX"].ToString(),
                            NOISANXUAT = reader["NOISANXUAT"].ToString(),
                            DIENTHOAI = reader["DIENTHOAI"].ToString(),
                        };
                        list.Add(a);
                    }
                    return PartialView(list);

                }
                catch (Exception exception)
                {
                    return PartialView();
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

        public ActionResult show_NSX()
        {
            List<NHASX> list = new List<NHASX>();
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM NHASX";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var a = new NHASX()
                        {
                            MANSX = reader["MANSX"].ToString(),
                            TENNSX = reader["TENNSX"].ToString(),
                            NOISANXUAT = reader["NOISANXUAT"].ToString(),
                            DIENTHOAI = reader["DIENTHOAI"].ToString(),
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
        public ActionResult Detail_NSX(string id)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM NHASX WHERE MANSX = @MANSX";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMANSX = new SqlParameter("@MANSX", id);
                    cmd.Parameters.Add(paraMANSX);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            var a = new NHASX()
                            {
                                MANSX = reader["MANSX"].ToString(),
                                TENNSX = reader["TENNSX"].ToString(),
                                NOISANXUAT = reader["NOISANXUAT"].ToString(),
                                DIENTHOAI = reader["DIENTHOAI"].ToString(),
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
        public ActionResult Update_NSX(NHASX a)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "UPDATE NHASX SET TENNSX = @TENNSX, NOISANXUAT = @NOISANXUAT, DIENTHOAI = @DIENTHOAI where MANSX = @MANSX";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMANSX = new SqlParameter("@MANSX", a.MANSX);
                    SqlParameter paraTENNSX = new SqlParameter("@TENNSX", a.TENNSX);
                    SqlParameter paraNOISANXUAT = new SqlParameter("@NOISANXUAT", a.NOISANXUAT);
                    SqlParameter paraDIENTHOAI = new SqlParameter("@DIENTHOAI", a.DIENTHOAI);


                    cmd.Parameters.Add(paraMANSX);
                    cmd.Parameters.Add(paraTENNSX);
                    cmd.Parameters.Add(paraNOISANXUAT);
                    cmd.Parameters.Add(paraDIENTHOAI);

                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return RedirectToAction("show_NSX");
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
        public ActionResult Delete_NSX(string id)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "DELETE FROM NHASX WHERE MANSX = @MANSX";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMANSX = new SqlParameter("@MANSX", id);
                    cmd.Parameters.Add(paraMANSX);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return RedirectToAction("show_NSX");
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
        public ActionResult Create_NSX(NHASX a)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {


                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM NHASX WHERE MANSX = @MANSX";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;

                    if (string.IsNullOrEmpty(a.MANSX))
                    {
                        return View();
                    }

                    SqlParameter paraMANSX = new SqlParameter("@MANSX", a.MANSX);
                    SqlParameter paraTENNSX = new SqlParameter("@TENNSX", a.TENNSX);
                    SqlParameter paraNOISANXUAT = new SqlParameter("@NOISANXUAT", a.NOISANXUAT);
                    SqlParameter paraDIENTHOAI = new SqlParameter("@DIENTHOAI", a.DIENTHOAI);



                    cmd.Parameters.Add(paraMANSX);
                    cmd.Parameters.Add(paraTENNSX);
                    cmd.Parameters.Add(paraNOISANXUAT);
                    cmd.Parameters.Add(paraDIENTHOAI);

                    var reader = cmd.ExecuteReader();
                    if (reader == null || reader.HasRows)
                    {
                        return View();
                    }
                    reader.Close();
                    cmd.CommandText = "insert into NHASX(MANSX, TENNSX, NOISANXUAT, DIENTHOAI) values (@MANSX,@TENNSX,@NOISANXUAT,@DIENTHOAI)";
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return RedirectToAction("show_NSX");
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
    }

}