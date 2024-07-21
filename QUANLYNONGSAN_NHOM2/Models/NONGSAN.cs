using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QUANLYNONGSAN_NHOM2.Models
{
    public class NONGSAN
    {
        public string MANS { get; set; }
        [Required(ErrorMessage = "Tên nông sản không được để trống")]
        public string TENNS { get; set; }
        public string DONVITINH { get; set; }
        [RegularExpression(@"^[1-9]\d*00$", ErrorMessage = "Giá phải là số dương và chia hết cho 1000. Vui lòng nhập lại giá")]
        public int GIA { get; set; }
        public string MANSX { get; set; }
        public string ANH { get; set; }
        public string MALOAI { get; set; }

        public LOAISP loai { get; set; }
    }
}