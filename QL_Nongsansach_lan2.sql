USE [QL_NONGSANSACH_LAN3]
GO
/****** Object:  Table [dbo].[DOITAC]    Script Date: 09/11/2023 11:26:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOITAC](
	[MADT] [char](5) NOT NULL,
	[TENDT] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[DIENTHOAI] [nchar](10) NULL,
 CONSTRAINT [PK_DOITAC] PRIMARY KEY CLUSTERED 
(
	[MADT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOPDONG]    Script Date: 09/11/2023 11:26:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOPDONG](
	[MAHD] [char](5) NOT NULL,
	[MANS] [char](5) NULL,
	[MADT] [char](5) NULL,
	[SOLUONG] [int] NULL,
	[NGAYKI] [date] NULL,
	[NGAYHOANTAT] [date] NULL,
	[TINHTRANG] [nvarchar](50) NULL,
 CONSTRAINT [PK_HOPDONG] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 09/11/2023 11:26:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [char](5) NOT NULL,
	[HOTEN] [nvarchar](255) NULL,
	[DIACHI] [nvarchar](255) NULL,
	[SODT] [nvarchar](20) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[GIOITINH] [nchar](10) NULL,
	[TAIKHOAN] [varchar](50) NULL,
	[MATKHAU] [varchar](50) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAISANPHAM]    Script Date: 09/11/2023 11:26:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISANPHAM](
	[MALOAI] [nchar](10) NOT NULL,
	[TENLOAISP] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAISANPHAM] PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 09/11/2023 11:26:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [varchar](50) NOT NULL,
	[TENNV] [nvarchar](50) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[SODT] [nvarchar](50) NULL,
	[TAIKHOAN] [varchar](50) NULL,
	[MATKHAU] [varchar](50) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHASX]    Script Date: 09/11/2023 11:26:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHASX](
	[MANSX] [char](5) NOT NULL,
	[TENNSX] [nvarchar](20) NULL,
	[NOISANXUAT] [nvarchar](50) NULL,
	[DIENTHOAI] [nvarchar](20) NULL,
 CONSTRAINT [PK_NHASX] PRIMARY KEY CLUSTERED 
(
	[MANSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NONGSAN]    Script Date: 09/11/2023 11:26:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NONGSAN](
	[MANS] [char](5) NOT NULL,
	[TENNS] [nvarchar](20) NULL,
	[DONVITINH] [nvarchar](20) NULL,
	[GIA] [int] NULL,
	[MANSX] [char](5) NULL,
	[ANH] [nvarchar](255) NULL,
	[MALOAI] [nchar](10) NULL,
 CONSTRAINT [PK_NONGSAN] PRIMARY KEY CLUSTERED 
(
	[MANS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUMUA]    Script Date: 09/11/2023 11:26:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUA](
	[MAPM] [char](5) NOT NULL,
	[MAKH] [char](5) NULL,
	[MANS] [char](5) NULL,
	[SOLUONG] [int] NULL,
	[NGAYMUA] [date] NULL,
 CONSTRAINT [PK_PHIEUMUA] PRIMARY KEY CLUSTERED 
(
	[MAPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DOITAC] ([MADT], [TENDT], [DIACHI], [DIENTHOAI]) VALUES (N'DT01 ', N'Cửa hàng rau sạch Hoàng Lê', N'Số 46 Tất Miễn, Đông Thành, Ninh Bình', N'0802121XXX')
INSERT [dbo].[DOITAC] ([MADT], [TENDT], [DIACHI], [DIENTHOAI]) VALUES (N'DT02 ', N'Cửa hàng Ngô Thành Nam', N'241 Nguyễn Văn Trỗi, Phủ Lý, Hà Nam', N'0903100XXX')
INSERT [dbo].[DOITAC] ([MADT], [TENDT], [DIACHI], [DIENTHOAI]) VALUES (N'DT03 ', N'Bách Hóa Xanh', N'223/12 Nguyễn Văn Công, Gò Vấp, TP Hồ Chí Minh', N'0907121XXX')
INSERT [dbo].[DOITAC] ([MADT], [TENDT], [DIACHI], [DIENTHOAI]) VALUES (N'DT04 ', N'Lotte Mart', N'Số 2 Nguyễn Văn Lượng, TP Hồ Chí Minh', N'0891231XXX')
INSERT [dbo].[DOITAC] ([MADT], [TENDT], [DIACHI], [DIENTHOAI]) VALUES (N'DT05 ', N'Cửa hàng kinh doanh thực phẩm an toàn Vĩnh Yên', N'130 Vinh Yên, Vinh Phúc', N'0987567XXX')
GO
INSERT [dbo].[HOPDONG] ([MAHD], [MANS], [MADT], [SOLUONG], [NGAYKI], [NGAYHOANTAT], [TINHTRANG]) VALUES (N'HD01 ', N'NS01 ', N'DT05 ', 100, CAST(N'2023-09-05' AS Date), CAST(N'2023-10-11' AS Date), N'Đã hoàn thành')
INSERT [dbo].[HOPDONG] ([MAHD], [MANS], [MADT], [SOLUONG], [NGAYKI], [NGAYHOANTAT], [TINHTRANG]) VALUES (N'HD02 ', N'NS01 ', N'DT03 ', 50, CAST(N'2023-09-08' AS Date), CAST(N'2023-10-11' AS Date), N'Đã hoàn thành')
INSERT [dbo].[HOPDONG] ([MAHD], [MANS], [MADT], [SOLUONG], [NGAYKI], [NGAYHOANTAT], [TINHTRANG]) VALUES (N'HD03 ', N'NS02 ', N'DT02 ', 30, CAST(N'2023-09-07' AS Date), CAST(N'2023-10-12' AS Date), N'Đã hoàn thành')
INSERT [dbo].[HOPDONG] ([MAHD], [MANS], [MADT], [SOLUONG], [NGAYKI], [NGAYHOANTAT], [TINHTRANG]) VALUES (N'HD04 ', N'NS02 ', N'DT05 ', 50, CAST(N'2023-09-06' AS Date), CAST(N'2023-10-10' AS Date), NULL)
INSERT [dbo].[HOPDONG] ([MAHD], [MANS], [MADT], [SOLUONG], [NGAYKI], [NGAYHOANTAT], [TINHTRANG]) VALUES (N'HD05 ', N'NS03 ', N'DT01 ', 30, CAST(N'2023-09-10' AS Date), CAST(N'2023-10-11' AS Date), N'Đã hoàn thành')
INSERT [dbo].[HOPDONG] ([MAHD], [MANS], [MADT], [SOLUONG], [NGAYKI], [NGAYHOANTAT], [TINHTRANG]) VALUES (N'HD06 ', N'NS03 ', N'DT02 ', 20, CAST(N'2023-09-11' AS Date), CAST(N'2023-10-12' AS Date), N'Đã hoàn thành')
INSERT [dbo].[HOPDONG] ([MAHD], [MANS], [MADT], [SOLUONG], [NGAYKI], [NGAYHOANTAT], [TINHTRANG]) VALUES (N'HD07 ', N'NS03 ', N'DT03 ', 30, CAST(N'2023-09-11' AS Date), CAST(N'2023-10-09' AS Date), N'Đã hoàn thành')
INSERT [dbo].[HOPDONG] ([MAHD], [MANS], [MADT], [SOLUONG], [NGAYKI], [NGAYHOANTAT], [TINHTRANG]) VALUES (N'HD08 ', N'NS03 ', N'DT04 ', 30, CAST(N'2023-09-11' AS Date), CAST(N'2023-10-10' AS Date), N'Chưa hoàn thành')
INSERT [dbo].[HOPDONG] ([MAHD], [MANS], [MADT], [SOLUONG], [NGAYKI], [NGAYHOANTAT], [TINHTRANG]) VALUES (N'HD09 ', N'NS03 ', N'DT05 ', 20, CAST(N'2023-09-11' AS Date), CAST(N'2023-10-12' AS Date), N'Đã hoàn thành')
INSERT [dbo].[HOPDONG] ([MAHD], [MANS], [MADT], [SOLUONG], [NGAYKI], [NGAYHOANTAT], [TINHTRANG]) VALUES (N'HD10 ', N'NS04 ', N'DT03 ', 10, CAST(N'2023-09-11' AS Date), CAST(N'2023-10-11' AS Date), N'Chưa hoàn thành')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [DIACHI], [SODT], [EMAIL], [NGAYSINH], [GIOITINH], [TAIKHOAN], [MATKHAU]) VALUES (N'KH01 ', N'Nguyễn Văn An', N'1 Nguyễn Văn Công, TPHCM', N'0907140XXX', N'becon@gmail.com', CAST(N'2010-01-01' AS Date), N'Nam       ', N'annguyen0101', N'an2010')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [DIACHI], [SODT], [EMAIL], [NGAYSINH], [GIOITINH], [TAIKHOAN], [MATKHAU]) VALUES (N'KH02 ', N'Lê Văn Bình', N'8 Nguyễn Kiệm, TPHCM', N'0973321XXX', N'conmeo@gmail.com', CAST(N'2012-02-02' AS Date), N'Nam       ', N'binhle0202', N'binh2012')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [DIACHI], [SODT], [EMAIL], [NGAYSINH], [GIOITINH], [TAIKHOAN], [MATKHAU]) VALUES (N'KH03 ', N'Trần Văn Cao', N'10 Nguyễn Tuân', N'0937357XXX', N'meomay@gmail.com', CAST(N'2003-05-15' AS Date), N'Nam       ', N'vancao1505', N'cao2003')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [DIACHI], [SODT], [EMAIL], [NGAYSINH], [GIOITINH], [TAIKHOAN], [MATKHAU]) VALUES (N'KH04 ', N'Hồ Văn Dũng', N'140 Lê Trọng Tấn', N'0903268XXX', N'maymoc@gmail.com', CAST(N'2003-10-29' AS Date), N'Nam       ', N'dungho2910', N'dung2003')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [DIACHI], [SODT], [EMAIL], [NGAYSINH], [GIOITINH], [TAIKHOAN], [MATKHAU]) VALUES (N'KH05 ', N'Lê Thị Em', N'109 Lê Lợi', N'0865112XXX', N'moccau@gmail.com', CAST(N'2003-01-06' AS Date), N'Nữ        ', N'lethiem0601', N'em2003')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [DIACHI], [SODT], [EMAIL], [NGAYSINH], [GIOITINH], [TAIKHOAN], [MATKHAU]) VALUES (N'KH06 ', N'Ngô Thị Phúc', N'169 Dương Quảng Hàm', N'0902530XXX', N'cauca@gmail.com', CAST(N'2002-02-05' AS Date), N'Nữ        ', N'phucngo0502', N'phuc2002')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [DIACHI], [SODT], [EMAIL], [NGAYSINH], [GIOITINH], [TAIKHOAN], [MATKHAU]) VALUES (N'KH07 ', N'Huỳnh Văn Gia', N'223 Nguyễn Huệ', N'0978560XXX', N'caloc@gmail.com', CAST(N'2001-08-03' AS Date), N'Nam       ', N'huynhgia0308', N'gia2001')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [DIACHI], [SODT], [EMAIL], [NGAYSINH], [GIOITINH], [TAIKHOAN], [MATKHAU]) VALUES (N'KH08 ', N'Nguyễn Thị Huệ', N'418 Quang Trung', N'0937798XXX', N'locxuong@gmail.com', CAST(N'2005-04-09' AS Date), N'Nữ        ', N'nguyenhue0904', N'hue2005')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [DIACHI], [SODT], [EMAIL], [NGAYSINH], [GIOITINH], [TAIKHOAN], [MATKHAU]) VALUES (N'KH09 ', N'Trần Thị Linh', N'123 Trần Bá Giao', N'0921437XXX', N'xuongcot@gmail.com', CAST(N'2004-11-07' AS Date), N'Nữ        ', N'linhtran0711', N'linh2004')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTEN], [DIACHI], [SODT], [EMAIL], [NGAYSINH], [GIOITINH], [TAIKHOAN], [MATKHAU]) VALUES (N'KH10 ', N'Trần Gia Tuấn', N'594 Lê Đức Thọ', N'0840123XXX', N'cotloi@gmail.com', CAST(N'2004-09-09' AS Date), N'Nam       ', N'tuantran0909', N'tuan2004')
GO
INSERT [dbo].[LOAISANPHAM] ([MALOAI], [TENLOAISP]) VALUES (N'ML01      ', N'Trái cây')
INSERT [dbo].[LOAISANPHAM] ([MALOAI], [TENLOAISP]) VALUES (N'ML02      ', N'Thủy Sản')
INSERT [dbo].[LOAISANPHAM] ([MALOAI], [TENLOAISP]) VALUES (N'ML03      ', N'Sản phẩm chế biến')
INSERT [dbo].[LOAISANPHAM] ([MALOAI], [TENLOAISP]) VALUES (N'ML04      ', N'Rau Củ')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [EMAIL], [SODT], [TAIKHOAN], [MATKHAU]) VALUES (N'NV01', N'Lê Thị Thu Trang', N'trangle@gmail.com', N'0907111XXX', N'trangle0907', N'trang111')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [EMAIL], [SODT], [TAIKHOAN], [MATKHAU]) VALUES (N'NV02', N'Nguyễn Ngọc Nguyên', N'ngocnguyen@gmail.com', N'0901222XXX', N'nguyen0901', N'nguyen222')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [EMAIL], [SODT], [TAIKHOAN], [MATKHAU]) VALUES (N'NV03', N'Huỳnh Vũ Anh Hào', N'haohuynh@gmail.com', N'0865111XXX', N'haohuynh2910', N'hao2003')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [EMAIL], [SODT], [TAIKHOAN], [MATKHAU]) VALUES (N'NV04', N'Nguyễn Tiến Đạt', N'datnguyen@gmail.com', N'0123456XXX', N'nguyendat0123', N'dat333')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [EMAIL], [SODT], [TAIKHOAN], [MATKHAU]) VALUES (N'NV05', N'Nguyễn Quang Quí', N'quinguyen@gmail.com', N'0987654XXX', N'quinguyen0987', N'qui444')
GO
INSERT [dbo].[NHASX] ([MANSX], [TENNSX], [NOISANXUAT], [DIENTHOAI]) VALUES (N'NSX01', N'NNghiệp Mỹ Lợi', N'Xã Mỹ Lợi A, huyện Cái Bè', N'0865112XXX')
INSERT [dbo].[NHASX] ([MANSX], [TENNSX], [NOISANXUAT], [DIENTHOAI]) VALUES (N'NSX02', N'Rau Bình Nghị', N'Xã Bình Nghị, huyện Gò Công Đông', N'0973321XXX')
INSERT [dbo].[NHASX] ([MANSX], [TENNSX], [NOISANXUAT], [DIENTHOAI]) VALUES (N'NSX03', N'NNghiệp Mỹ Phong', N'Xã Mỹ Phong, xã Mỹ Tho', N'093735XXX')
INSERT [dbo].[NHASX] ([MANSX], [TENNSX], [NOISANXUAT], [DIENTHOAI]) VALUES (N'NSX04', N'DVụ NNghiệp Tăng Hòa', N'Xã Tăng Hòa, huyện Gò Công Đông', N'0902530XXX')
GO
INSERT [dbo].[NONGSAN] ([MANS], [TENNS], [DONVITINH], [GIA], [MANSX], [ANH], [MALOAI]) VALUES (N'NS01 ', N'Gạo', N'KG', 25000, N'NSX01', N'gao.jpg', N'ML03      ')
INSERT [dbo].[NONGSAN] ([MANS], [TENNS], [DONVITINH], [GIA], [MANSX], [ANH], [MALOAI]) VALUES (N'NS02 ', N'Dưa lưới', N'KG', 15000, N'NSX01', N'dualuoi.jpg', N'ML01      ')
INSERT [dbo].[NONGSAN] ([MANS], [TENNS], [DONVITINH], [GIA], [MANSX], [ANH], [MALOAI]) VALUES (N'NS03 ', N'Cà chua', N'KG', 13000, N'NSX01', N'cachua.jpg', N'ML04      ')
INSERT [dbo].[NONGSAN] ([MANS], [TENNS], [DONVITINH], [GIA], [MANSX], [ANH], [MALOAI]) VALUES (N'NS04 ', N'Cải bẹ xanh', N'KG', 8000, N'NSX02', N'cai.jpg', N'ML04      ')
INSERT [dbo].[NONGSAN] ([MANS], [TENNS], [DONVITINH], [GIA], [MANSX], [ANH], [MALOAI]) VALUES (N'NS05 ', N'Giá', N'KG', 10000, N'NSX02', N'gia.jpg', N'ML04      ')
INSERT [dbo].[NONGSAN] ([MANS], [TENNS], [DONVITINH], [GIA], [MANSX], [ANH], [MALOAI]) VALUES (N'NS06 ', N'Cà Rốt', N'KG', 18000, N'NSX03', N'carot.jpg', N'ML04      ')
INSERT [dbo].[NONGSAN] ([MANS], [TENNS], [DONVITINH], [GIA], [MANSX], [ANH], [MALOAI]) VALUES (N'NS07 ', N'Vú sữa', N'KG', 17000, N'NSX03', N'vusua.jpg', N'ML01      ')
INSERT [dbo].[NONGSAN] ([MANS], [TENNS], [DONVITINH], [GIA], [MANSX], [ANH], [MALOAI]) VALUES (N'NS08 ', N'Củ dền', N'KG', 9000, N'NSX03', N'cuden.jpg', N'ML04      ')
INSERT [dbo].[NONGSAN] ([MANS], [TENNS], [DONVITINH], [GIA], [MANSX], [ANH], [MALOAI]) VALUES (N'NS09 ', N'Dưa chuột', N'KG', 14000, N'NSX04', N'duachuot.jpg', N'ML04      ')
INSERT [dbo].[NONGSAN] ([MANS], [TENNS], [DONVITINH], [GIA], [MANSX], [ANH], [MALOAI]) VALUES (N'NS10 ', N'Hành', N'Kí', 20000, N'NSX04', N'hanh.jpg', N'ML04      ')
INSERT [dbo].[NONGSAN] ([MANS], [TENNS], [DONVITINH], [GIA], [MANSX], [ANH], [MALOAI]) VALUES (N'NS11 ', N'Tôm', N'KG', 100000, N'NSX01', N'tom.jgp', N'ML02      ')
INSERT [dbo].[NONGSAN] ([MANS], [TENNS], [DONVITINH], [GIA], [MANSX], [ANH], [MALOAI]) VALUES (N'NS13 ', N'Cà phê rang xay', N'KG', 70000, N'NSX04', N'caphe.jpg', N'ML03      ')
INSERT [dbo].[NONGSAN] ([MANS], [TENNS], [DONVITINH], [GIA], [MANSX], [ANH], [MALOAI]) VALUES (N'NS14 ', N'Xoài', N'KG', 20000, N'NSX03', N'xoai.jpg', N'ML01      ')
INSERT [dbo].[NONGSAN] ([MANS], [TENNS], [DONVITINH], [GIA], [MANSX], [ANH], [MALOAI]) VALUES (N'NS15 ', N'Mực', N'KG', 120000, N'NSX01', N'muc.jpg', N'ML02      ')
INSERT [dbo].[NONGSAN] ([MANS], [TENNS], [DONVITINH], [GIA], [MANSX], [ANH], [MALOAI]) VALUES (N'NS16 ', N'Thơm', N'KG', 15000, N'NSX02', N'thom.jpg', N'ML01      ')
GO
INSERT [dbo].[PHIEUMUA] ([MAPM], [MAKH], [MANS], [SOLUONG], [NGAYMUA]) VALUES (N'PM01 ', N'KH01 ', N'NS01 ', 10, CAST(N'2023-02-03' AS Date))
INSERT [dbo].[PHIEUMUA] ([MAPM], [MAKH], [MANS], [SOLUONG], [NGAYMUA]) VALUES (N'PM02 ', N'KH03 ', N'NS01 ', 5, CAST(N'2023-03-12' AS Date))
INSERT [dbo].[PHIEUMUA] ([MAPM], [MAKH], [MANS], [SOLUONG], [NGAYMUA]) VALUES (N'PM03 ', N'KH02 ', N'NS01 ', 10, CAST(N'2023-01-01' AS Date))
INSERT [dbo].[PHIEUMUA] ([MAPM], [MAKH], [MANS], [SOLUONG], [NGAYMUA]) VALUES (N'PM04 ', N'KH01 ', N'NS04 ', 2, CAST(N'2023-07-14' AS Date))
INSERT [dbo].[PHIEUMUA] ([MAPM], [MAKH], [MANS], [SOLUONG], [NGAYMUA]) VALUES (N'PM05 ', N'KH05 ', N'NS03 ', 1, CAST(N'2022-08-16' AS Date))
INSERT [dbo].[PHIEUMUA] ([MAPM], [MAKH], [MANS], [SOLUONG], [NGAYMUA]) VALUES (N'PM06 ', N'KH04 ', N'NS02 ', 5, CAST(N'2022-11-12' AS Date))
INSERT [dbo].[PHIEUMUA] ([MAPM], [MAKH], [MANS], [SOLUONG], [NGAYMUA]) VALUES (N'PM07 ', N'KH03 ', N'NS05 ', 3, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[PHIEUMUA] ([MAPM], [MAKH], [MANS], [SOLUONG], [NGAYMUA]) VALUES (N'PM08 ', N'KH07 ', N'NS08 ', 2, CAST(N'2023-10-11' AS Date))
INSERT [dbo].[PHIEUMUA] ([MAPM], [MAKH], [MANS], [SOLUONG], [NGAYMUA]) VALUES (N'PM09 ', N'KH09 ', N'NS10 ', 1, CAST(N'2023-10-09' AS Date))
INSERT [dbo].[PHIEUMUA] ([MAPM], [MAKH], [MANS], [SOLUONG], [NGAYMUA]) VALUES (N'PM10 ', N'KH06 ', N'NS09 ', 2, CAST(N'2023-10-10' AS Date))
INSERT [dbo].[PHIEUMUA] ([MAPM], [MAKH], [MANS], [SOLUONG], [NGAYMUA]) VALUES (N'PM11 ', N'KH08 ', N'NS03 ', 2, CAST(N'2023-11-10' AS Date))
INSERT [dbo].[PHIEUMUA] ([MAPM], [MAKH], [MANS], [SOLUONG], [NGAYMUA]) VALUES (N'PM12 ', N'KH07 ', N'NS01 ', 15, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[PHIEUMUA] ([MAPM], [MAKH], [MANS], [SOLUONG], [NGAYMUA]) VALUES (N'PM13 ', N'KH10 ', N'NS02 ', 5, CAST(N'2023-10-12' AS Date))
INSERT [dbo].[PHIEUMUA] ([MAPM], [MAKH], [MANS], [SOLUONG], [NGAYMUA]) VALUES (N'PM14 ', N'KH04 ', N'NS09 ', 3, CAST(N'2023-10-11' AS Date))
INSERT [dbo].[PHIEUMUA] ([MAPM], [MAKH], [MANS], [SOLUONG], [NGAYMUA]) VALUES (N'PM15 ', N'KH05 ', N'NS01 ', 20, CAST(N'2023-10-05' AS Date))
GO
ALTER TABLE [dbo].[HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_DOITAC_HOPDONG] FOREIGN KEY([MADT])
REFERENCES [dbo].[DOITAC] ([MADT])
GO
ALTER TABLE [dbo].[HOPDONG] CHECK CONSTRAINT [FK_DOITAC_HOPDONG]
GO
ALTER TABLE [dbo].[HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_NONGSAN_HOPDONG] FOREIGN KEY([MANS])
REFERENCES [dbo].[NONGSAN] ([MANS])
GO
ALTER TABLE [dbo].[HOPDONG] CHECK CONSTRAINT [FK_NONGSAN_HOPDONG]
GO
ALTER TABLE [dbo].[NONGSAN]  WITH CHECK ADD  CONSTRAINT [FK_NHASX_NONGSAN] FOREIGN KEY([MANSX])
REFERENCES [dbo].[NHASX] ([MANSX])
GO
ALTER TABLE [dbo].[NONGSAN] CHECK CONSTRAINT [FK_NHASX_NONGSAN]
GO
ALTER TABLE [dbo].[NONGSAN]  WITH CHECK ADD  CONSTRAINT [FK_NONGSAN_LOAISANPHAM] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAISANPHAM] ([MALOAI])
GO
ALTER TABLE [dbo].[NONGSAN] CHECK CONSTRAINT [FK_NONGSAN_LOAISANPHAM]
GO
ALTER TABLE [dbo].[PHIEUMUA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUA_KHACHHANG] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[PHIEUMUA] CHECK CONSTRAINT [FK_PHIEUMUA_KHACHHANG]
GO
ALTER TABLE [dbo].[PHIEUMUA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUA_NONGSAN] FOREIGN KEY([MANS])
REFERENCES [dbo].[NONGSAN] ([MANS])
GO
ALTER TABLE [dbo].[PHIEUMUA] CHECK CONSTRAINT [FK_PHIEUMUA_NONGSAN]
GO

GO
CREATE TRIGGER Insert_TAIKHOAN
ON KHACHHANG
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @MAKH CHAR(5);
    SET @MAKH = 'KKH' + CAST(CHECKSUM(NEWID()) % 1000000 AS VARCHAR(6));
    
    INSERT INTO KHACHHANG(MAKH, HOTEN, DIACHI, SODT, EMAIL, NGAYSINH, GIOITINH, TAIKHOAN, MATKHAU)
    SELECT @MAKH, HOTEN, DIACHI, SODT, EMAIL, NGAYSINH, GIOITINH, TAIKHOAN, MATKHAU
    FROM inserted;
END