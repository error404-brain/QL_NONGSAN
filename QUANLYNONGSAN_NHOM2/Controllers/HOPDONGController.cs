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
    public class HOPDONGController : Controller
    {
        // GET: HOPDONG
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Eror()
        {
            return View();
        }
        public ActionResult show_HD()
        {
            List<HOPDONG> list = new List<HOPDONG>();
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM HOPDONG  Order by MAHD";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var a = new HOPDONG()
                        {
                            MAHD = reader["MAHD"].ToString(),
                            MANS = reader["MANS"].ToString(),
                            MADT = reader["MADT"].ToString(),
                            SOLUONG = (int)reader["SOLUONG"],
                            NGAYKI = reader["NGAYKI"].ToString(),
                            NGAYHOANTAT = reader["NGAYHOANTAT"].ToString(),
                            TINHTRANG = reader["TINHTRANG"].ToString(),
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
        public ActionResult Detail_HD(string id)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM HOPDONG WHERE MAHD = @MAHD";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMAHD = new SqlParameter("@MAHD", id);
                    cmd.Parameters.Add(paraMAHD);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            var a = new HOPDONG()
                            {
                                MAHD = reader["MAHD"].ToString(),
                                MANS = reader["MANS"].ToString(),
                                MADT = reader["MADT"].ToString(),
                                SOLUONG = (int)reader["SOLUONG"],
                                NGAYKI = reader["NGAYKI"].ToString(),
                                NGAYHOANTAT = reader["NGAYHOANTAT"].ToString(),
                                TINHTRANG = reader["TINHTRANG"].ToString(),
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
        public ActionResult Update_HD(HOPDONG a)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "UPDATE HOPDONG SET MANS = @MANS, MADT = @MADT, SOLUONG = @SOLUONG, NGAYKI = @NGAYKI, NGAYHOANTAT = @NGAYHOANTAT, TINHTRANG = @TINHTRANG where MAHD = @MAHD";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMAHD = new SqlParameter("@MAHD", a.MAHD);
                    SqlParameter paraMANS = new SqlParameter("@MANS", a.MANS);
                    SqlParameter paraMADT = new SqlParameter("@MADT", a.MADT);
                    SqlParameter paraSOLUONG = new SqlParameter("@SODT", a.SOLUONG);
                    SqlParameter paraNGAYKI = new SqlParameter("@NGAYKI", a.NGAYKI);
                    SqlParameter paraNGAYHOANTAT = new SqlParameter("@NGAYHOANTAT", a.NGAYHOANTAT);
                    SqlParameter paraTINHTRANG= new SqlParameter("@TINHTRANG", a.TINHTRANG);


                    cmd.Parameters.Add(paraMAHD);
                    cmd.Parameters.Add(paraMANS);
                    cmd.Parameters.Add(paraMADT);
                    cmd.Parameters.Add(paraSOLUONG);
                    cmd.Parameters.Add(paraNGAYKI);
                    cmd.Parameters.Add(paraNGAYHOANTAT);
                    cmd.Parameters.Add(paraTINHTRANG);

                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return RedirectToAction("show_HD");
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
        public ActionResult Create_HD(HOPDONG a)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {


                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM HOPDONG WHERE MAHD = @MAHD";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;

                    if (string.IsNullOrEmpty(a.MAHD))
                    {
                        return View();
                    }

                    SqlParameter paraMAHD = new SqlParameter("@MAHD", a.MAHD);
                    SqlParameter paraMANS = new SqlParameter("@MANS", a.MANS);
                    SqlParameter paraMADT = new SqlParameter("@MADT", a.MADT);
                    SqlParameter paraSOLUONG = new SqlParameter("@SODT", a.SOLUONG);
                    SqlParameter paraNGAYKI = new SqlParameter("@NGAYKI", a.NGAYKI);
                    SqlParameter paraNGAYHOANTAT = new SqlParameter("@NGAYHOANTAT", a.NGAYHOANTAT);
                    SqlParameter paraTINHTRANG = new SqlParameter("@TINHTRANG", a.TINHTRANG);




                    cmd.Parameters.Add(paraMAHD);
                    cmd.Parameters.Add(paraMANS);
                    cmd.Parameters.Add(paraMADT);
                    cmd.Parameters.Add(paraSOLUONG);
                    cmd.Parameters.Add(paraNGAYKI);
                    cmd.Parameters.Add(paraNGAYHOANTAT);
                    cmd.Parameters.Add(paraTINHTRANG);

                    var reader = cmd.ExecuteReader();
                    if (reader == null || reader.HasRows)
                    {
                        return View();
                    }
                    reader.Close();
                    cmd.CommandText = "insert into HOPDONG(MAHD, MANS, MADT, SOLUONG, NGAYKI, NGAYHOANTAT, TINHTRANG) values (@MAHD,@MANS,@MADT,@SOLUONG,@NGAYKI,@NGAYHOANTAT,@TINHTRANG)";
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return RedirectToAction("show_HD");
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
        public ActionResult Delete_HD(string id)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "DELETE FROM HOPDONG WHERE MAHD = @MAHD";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMAHD = new SqlParameter("@MAHD", id);
                    cmd.Parameters.Add(paraMAHD);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return RedirectToAction("show_HD");
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
    }
}