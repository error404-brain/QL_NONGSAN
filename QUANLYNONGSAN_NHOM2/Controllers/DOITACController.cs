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
    public class DOITACController : Controller
    {
        // GET: DOITAC
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Eror()
        {
            return View();
        }
        public ActionResult show_DT()
        {
            List<DOITAC> list = new List<DOITAC>();
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM DOITAC  Order by TENDT";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var a = new DOITAC()
                        {
                            MADT = reader["MADT"].ToString(),
                            TENDT = reader["TENDT"].ToString(),
                            DIACHI = reader["DIACHI"].ToString(),
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
        public ActionResult Detail_DT(string id)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM DOITAC WHERE MADT = @MADT";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMADT = new SqlParameter("@MADT", id);
                    cmd.Parameters.Add(paraMADT);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            var a = new DOITAC()
                            {
                                MADT = reader["MADT"].ToString(),
                                TENDT = reader["TENDT"].ToString(),
                                DIACHI = reader["DIACHI"].ToString(),
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
        public ActionResult Update_DT(DOITAC a)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "UPDATE DOITAC SET TENDT = @TENDT, DIACHI = @DIACHI, DIENTHOAI = @DIENTHOAI where MADT = @MADT";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMADT = new SqlParameter("@MADT", a.MADT);
                    SqlParameter paraTENDT = new SqlParameter("@TENDT", a.TENDT);
                    SqlParameter paraDIACHI = new SqlParameter("@DIACHI", a.DIACHI);
                    SqlParameter paraDIENTHOAI = new SqlParameter("@DIENTHOAI", a.DIENTHOAI);


                    cmd.Parameters.Add(paraMADT);
                    cmd.Parameters.Add(paraTENDT);
                    cmd.Parameters.Add(paraDIACHI);
                    cmd.Parameters.Add(paraDIENTHOAI);

                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return RedirectToAction("show_DT");
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
        public ActionResult Delete_DT(string id)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "DELETE FROM DOITAC WHERE MADT = @MADT";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMADT = new SqlParameter("@MADT", id);
                    cmd.Parameters.Add(paraMADT);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return RedirectToAction("show_DT");
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
        public ActionResult Create_DT(DOITAC a)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {


                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM DOITAC WHERE MADT = @MADT";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;

                    if (string.IsNullOrEmpty(a.MADT))
                    {
                        return View();
                    }

                    SqlParameter paraMADT = new SqlParameter("@MADT", a.MADT);
                    SqlParameter paraTENDT = new SqlParameter("@TENDT", a.TENDT);
                    SqlParameter paraDIACHI = new SqlParameter("@DIACHI", a.DIACHI);
                    SqlParameter paraDIENTHOAI = new SqlParameter("@DIENTHOAI", a.DIENTHOAI);



                    cmd.Parameters.Add(paraMADT);
                    cmd.Parameters.Add(paraTENDT);
                    cmd.Parameters.Add(paraDIACHI);
                    cmd.Parameters.Add(paraDIENTHOAI);

                    var reader = cmd.ExecuteReader();
                    if (reader == null || reader.HasRows)
                    {
                        return View();
                    }
                    reader.Close();
                    cmd.CommandText = "insert into DOITAC(MADT, TENDT, DIACHI, DIENTHOAI) values (@MADT,@TENDT,@DIACHI,@DIENTHOAI)";
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return RedirectToAction("show_DT");
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