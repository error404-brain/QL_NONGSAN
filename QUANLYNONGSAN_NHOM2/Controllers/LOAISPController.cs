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
    public class LOAISPController : Controller
    {
        // GET: LOAISP
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _menuLoai()
        {

            List<LOAISP> list = new List<LOAISP>();
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM LOAISANPHAM  Order by TENLOAISP";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var a = new LOAISP();
                        a.MALOAI = reader["MALOAI"].ToString();
                        a.TENLOAI = reader["TENLOAISP"].ToString();
                        a.NS = new NONGSAN()
                        {
                            MALOAI = a.MALOAI,
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



        public ActionResult show_CD(string id)
        {
            List<LOAISP> list = new List<LOAISP>();
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT MANS, TENNS, DONVITINH, GIA, MANSX, ANH, NONGSAN.MALOAI,TENLOAISP from LOAISANPHAM ,NONGSAN  where LOAISANPHAM.MALOAI = NONGSAN.MALOAI AND LOAISANPHAM.MALOAI = @MALOAI";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMANS = new SqlParameter("@MALOAI", id);
                    cmd.Parameters.Add(paraMANS);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            var a = new LOAISP();
                            a.MALOAI = reader["MALOAI"].ToString();
                            a.TENLOAI = reader["TENLOAISP"].ToString();
                            a.NS = new NONGSAN()
                            {
                                MALOAI = a.MALOAI,
                                MANS = reader["MANS"].ToString(),
                                TENNS = reader["TENNS"].ToString(),
                                DONVITINH = reader["DONVITINH"].ToString(),
                                GIA = (int)reader["GIA"],
                                MANSX = reader["MANSX"].ToString(),
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

        public ActionResult show_LOAISP()
        {
            List<LOAISP> list = new List<LOAISP>();
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT MANS, TENNS, DONVITINH, GIA, MANSX, ANH, NONGSAN.MALOAI,TENLOAISP from LOAISANPHAM ,NONGSAN  where LOAISANPHAM.MALOAI = NONGSAN.MALOAI";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var a = new LOAISP();
                        a.MALOAI = reader["MALOAI"].ToString();
                        a.TENLOAI = reader["TENLOAISP"].ToString();
                        a.NS = new NONGSAN()
                        {
                            MALOAI = a.MALOAI,
                            MANS = reader["MANS"].ToString(),
                            TENNS = reader["TENNS"].ToString(),
                            DONVITINH = reader["DONVITINH"].ToString(),
                            GIA = (int)reader["GIA"],
                            MANSX = reader["MANSX"].ToString(),
                            ANH = reader["ANH"].ToString(),
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


    }
}