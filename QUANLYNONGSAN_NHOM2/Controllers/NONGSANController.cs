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
    public class NONGSANController : Controller
    {
        // GET: NONGSAN
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Eror()
        {
            return View();
        }

        public ActionResult find_MENU_USER(string find)
        {
            List<NONGSAN> list = new List<NONGSAN>();
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "select * from NONGSAN where TENNS like '%'+@TENNS+'%' ";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraTENTV = new SqlParameter("@TENNS", find);
                    cmd.Parameters.Add(paraTENTV);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            var a = new NONGSAN()
                            {
                                MANS = reader["MANS"].ToString(),
                                TENNS = reader["TENNS"].ToString(),
                                DONVITINH = reader["DONVITINH"].ToString(),
                                GIA = (int)reader["GIA"],
                                MANSX = reader["MANSX"].ToString(),
                                ANH = reader["ANH"].ToString(),
                                MALOAI = reader["MALOAI"].ToString(),
                            };
                            list.Add(a);
                        }
                    }
                    return View(list);
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


        public PartialViewResult _menu()
        {
            List<NONGSAN> list = new List<NONGSAN>();
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM NONGSAN";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var a = new NONGSAN()
                        {
                            MANS = reader["MANS"].ToString(),
                            TENNS = reader["TENNS"].ToString(),
                            DONVITINH = reader["DONVITINH"].ToString(),
                            GIA = (int)reader["GIA"],
                            MANSX = reader["MANSX"].ToString(),
                            ANH = reader["ANH"].ToString(),
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

        public ActionResult findInformation(string find)
        {
            List<NONGSAN> list = new List<NONGSAN>();
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "select * from NONGSAN where TENNS like '%'+@TENNS+'%' ";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraTENTV = new SqlParameter("@TENNS", find);
                    cmd.Parameters.Add(paraTENTV);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            var a = new NONGSAN()
                            {
                                MANS = reader["MANS"].ToString(),
                                TENNS = reader["TENNS"].ToString(),
                                DONVITINH = reader["DONVITINH"].ToString(),
                                GIA = (int)reader["GIA"],
                                MANSX = reader["MANSX"].ToString(),
                                ANH = reader["ANH"].ToString(),
                                MALOAI = reader["MALOAI"].ToString(),
                            };
                            list.Add(a);
                        }
                    }
                    return View(list);
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

        public ActionResult soft(string sx)
        {
            List<NONGSAN> list = new List<NONGSAN>();
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {

                    if (sx == "2")
                    {
                        connect.Open();
                        string sql = "SELECT * FROM NONGSAN Order by TENNS";
                        SqlCommand cmd = new SqlCommand(sql, connect);
                        cmd.CommandType = CommandType.Text;
                        SqlParameter parasx = new SqlParameter("@MANS", sx);
                        cmd.Parameters.Add(parasx);
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            if (reader.HasRows)
                            {
                                var a = new NONGSAN()
                                {
                                    MANS = reader["MANS"].ToString(),
                                    TENNS = reader["TENNS"].ToString(),
                                    DONVITINH = reader["DONVITINH"].ToString(),
                                    GIA = (int)reader["GIA"],
                                    MANSX = reader["MANSX"].ToString(),
                                    ANH = reader["ANH"].ToString(),
                                    MALOAI = reader["MALOAI"].ToString(),
                                };
                                list.Add(a);
                            }
                        }
                        return View(list);
                    }
                    else if (sx == "1")
                    {
                        connect.Open();
                        string sql = "SELECT * FROM NONGSAN Order by GIA";
                        SqlCommand cmd = new SqlCommand(sql, connect);
                        cmd.CommandType = CommandType.Text;
                        SqlParameter parasx = new SqlParameter("@MANS", sx);
                        cmd.Parameters.Add(parasx);
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            if (reader.HasRows)
                            {
                                var a = new NONGSAN()
                                {
                                    MANS = reader["MANS"].ToString(),
                                    TENNS = reader["TENNS"].ToString(),
                                    DONVITINH = reader["DONVITINH"].ToString(),
                                    GIA = (int)reader["GIA"],
                                    MANSX = reader["MANSX"].ToString(),
                                    ANH = reader["ANH"].ToString(),
                                    MALOAI = reader["MALOAI"].ToString(),
                                };
                                list.Add(a);
                            }
                        }
                        return View(list);
                    }
                    return View();
                }
                catch (Exception e)
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


        public ActionResult Update_NS(NONGSAN a, HttpPostedFileBase ANH)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "UPDATE NONGSAN SET TENNS = @TENNS, DONVITINH = @DONVITINH, GIA = @GIA, MANSX = @MANSX, ANH = @ANH, MALOAI = @MALOAI  where MANS = @MANS";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;

                    if (string.IsNullOrEmpty(a.MANS))
                    {
                        return View();
                    }
                    var fileName = ANH.FileName;
                    var path = Path.Combine(Server.MapPath("~/Image_NONGSAN"), fileName);
                    ANH.SaveAs(path);

                    SqlParameter paraMAS = new SqlParameter("@MANS", a.MANS);
                    SqlParameter paraTNS = new SqlParameter("@TENNS", a.TENNS);
                    SqlParameter paraDONVITINH = new SqlParameter("@DONVITINH", a.DONVITINH);
                    SqlParameter paraGIA = new SqlParameter("@GIA", a.GIA);
                    SqlParameter paraMASANXUAT = new SqlParameter("@MANSX", a.MANSX);
                    SqlParameter paraMALOAI = new SqlParameter("@MALOAI", a.MALOAI);
                    SqlParameter paraANh = new SqlParameter("@ANH", fileName);


                    cmd.Parameters.Add(paraMAS);
                    cmd.Parameters.Add(paraTNS);
                    cmd.Parameters.Add(paraDONVITINH);
                    cmd.Parameters.Add(paraGIA);
                    cmd.Parameters.Add(paraMASANXUAT);
                    cmd.Parameters.Add(paraMALOAI);
                    cmd.Parameters.Add(paraANh);

                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return RedirectToAction("show_NONGSAN");
                    }
                    return View();
                }
                catch(Exception exception)
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

        public ActionResult Delete_NS(string id)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "DELETE FROM NONGSAN WHERE MANS = @MANS";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMANS = new SqlParameter("@MANS", id);
                    cmd.Parameters.Add(paraMANS);
                    if(cmd.ExecuteNonQuery() > 0)
                    {
                        return RedirectToAction("show_NONGSAN");
                    }
                    return RedirectToAction("Eror");
                }                
                catch(Exception exception)
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

        public ActionResult Deatail_NS(string id)
        {
           
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM NONGSAN WHERE MANS = @MANS";
                    SqlCommand cmd = new SqlCommand(sql,connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMANS = new SqlParameter("@MANS",id);
                    cmd.Parameters.Add(paraMANS);
                    var reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        if(reader.HasRows)
                        {
                            var a = new NONGSAN()
                            {
                                MANS = reader["MANS"].ToString(),
                                TENNS = reader["TENNS"].ToString(),
                                DONVITINH = reader["DONVITINH"].ToString(),
                                GIA = (int)reader["GIA"],
                                MANSX = reader["MANSX"].ToString(),
                                ANH = reader["ANH"].ToString(),
                                MALOAI = reader["MALOAI"].ToString(),
                            };

                            return View(a);
                        }
                    }
                    return View();
                }
                catch(Exception exception)
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

        public ActionResult Create_NS(NONGSAN a, HttpPostedFileBase ANH)
        {
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
              
               
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM NONGSAN WHERE MANS = @MANS";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;

                    if(string.IsNullOrEmpty(a.MANS))
                    {
                        return View();
                    }
                    var fileName = ANH.FileName;
                    var path = Path.Combine(Server.MapPath("~/Image_NONGSAN"), fileName);
                    ANH.SaveAs(path);

                    SqlParameter paraMAS = new SqlParameter("@MANS", a.MANS);
                    SqlParameter paraTNS = new SqlParameter("@TENNS", a.TENNS);
                    SqlParameter paraDONVITINH = new SqlParameter("@DONVITINH", a.DONVITINH);
                    SqlParameter paraGIA = new SqlParameter("@GIA", a.GIA);
                    SqlParameter paraMASANXUAT = new SqlParameter("@MANSX", a.MANSX);
                    SqlParameter paraMALOAI = new SqlParameter("@MALOAI", a.MALOAI);
                    SqlParameter paraANh = new SqlParameter("@ANH", ANH.FileName);

                 

                    cmd.Parameters.Add(paraMAS);
                    cmd.Parameters.Add(paraTNS);
                    cmd.Parameters.Add(paraDONVITINH);
                    cmd.Parameters.Add(paraGIA);
                    cmd.Parameters.Add(paraMASANXUAT);
                    cmd.Parameters.Add(paraMALOAI);
                    cmd.Parameters.Add(paraANh);

                    var reader = cmd.ExecuteReader();
                    if (reader == null || reader.HasRows)
                    {
                        return View();
                    }
                    reader.Close();
                    cmd.CommandText = "insert into NONGSAN(MANS, TENNS, DONVITINH, GIA, MANSX, ANH, MALOAI) values (@MANS,@TENNS,@DONVITINH,@GIA,@MANSX,@ANH,@MALOAI)";
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return RedirectToAction("show_NONGSAN");
                    }
                    return View();

                }
                catch(Exception exception)
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

        public ActionResult show_NONGSAN()
        {
            List<NONGSAN> list = new List<NONGSAN>();
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM NONGSAN  Order by TENNS";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        var a = new NONGSAN()
                        {
                            MANS = reader["MANS"].ToString(),
                            TENNS = reader["TENNS"].ToString(),
                            DONVITINH = reader["DONVITINH"].ToString(),
                            GIA = (int)reader["GIA"],
                            MANSX = reader["MANSX"].ToString(),
                            MALOAI= reader["MALOAI"].ToString(),
                            ANH = reader["ANH"].ToString(),
                        };
                        list.Add(a);
                    }
                    return View(list);

                }
                catch(Exception exception)
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
