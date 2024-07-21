using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace QUANLYNONGSAN_NHOM2.Models
{
    public class GIOHANG
    {
        public NONGSAN NONG { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien
        {
            get { return SoLuong * NONG.GIA; }
        }


        public GIOHANG(string MaNS)
        {
            NONG = new NONGSAN();
            NONG.MANS = MaNS;

            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["QL_NONGSANSACH_LAN2"].ConnectionString))
            {
                try
                {
                    connect.Open();
                    string sql = "SELECT * FROM NONGSAN WHERE MANS = @MANS";
                    SqlCommand cmd = new SqlCommand(sql, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlParameter paraMANS = new SqlParameter("@MANS", NONG.MANS);
                    cmd.Parameters.Add(paraMANS);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                         
                            NONG.TENNS = reader["TENNS"].ToString();
                            NONG.DONVITINH = reader["DONVITINH"].ToString();
                            NONG.GIA = (int)reader["GIA"];
                            NONG.MANSX = reader["MANSX"].ToString();
                            NONG.ANH = reader["ANH"].ToString();
                        }
                    }
                }
                catch
                {

                }
                finally
                {
                    connect.Close();
                }
                SoLuong = 1;
            }
        }
    }
}
                
                
               