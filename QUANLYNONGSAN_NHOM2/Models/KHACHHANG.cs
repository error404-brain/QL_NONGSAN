using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QUANLYNONGSAN_NHOM2.Models
{
    public class KHACHHANG
    {
        public string MAKH { get; set; }
        [Required(ErrorMessage = "Họ tên không được để trống")]
        public string HOTEN { get; set; }
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Email không hợp lệ")]
        public string EMAIL { get; set; }
        public string DIACHI { get; set; }
        [RegularExpression(@"^0\d{9}$", ErrorMessage = "Số điện thoại không hợp lệ")]
        public string SODT { get; set; }

        public string NGAYSINH { get; set; }
        public string GIOITINH { get; set; }
        [Required(ErrorMessage = "Tài khoản không được để trống")]
        public string TAIKHOAN { get; set; }


        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string MATKHAU { get; set; }
        

    }
}