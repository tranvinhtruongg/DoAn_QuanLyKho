USE [DA_QLKK]
GO
/****** Object:  Table [dbo].[KHO]    Script Date: 7/24/2022 3:23:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[ID_NhanVien] [int] NULL,
	[SoLuongHang] [int] NOT NULL,
	[DiaDiem] [nvarchar](120) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIHANG]    Script Date: 7/24/2022 3:23:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIHANG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiHang] [nvarchar](50) NULL,
	[ID_KHO] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MATHANG]    Script Date: 7/24/2022 3:23:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MATHANG](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenMatHang] [nvarchar](50) NULL,
	[ViTri] [nvarchar](50) NULL,
	[SoLuongTon] [int] NULL,
	[ID_LH] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 7/24/2022 3:23:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten_NV] [nvarchar](50) NULL,
	[Gioitinh] [bit] NULL,
	[Email] [nvarchar](200) NULL,
	[Dienthoai] [nvarchar](10) NULL,
	[NamSinh] [date] NULL,
	[DiaChi] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 7/24/2022 3:23:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SoLuong] [int] NULL,
	[NgayLap] [date] NULL,
	[ID_NhanVien] [int] NULL,
	[ID_Kho] [int] NULL,
	[ID_MatHang] [int] NULL,
 CONSTRAINT [PK__PHIEUNHA__3214EC2703123479] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 7/24/2022 3:23:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUXUAT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [date] NULL,
	[ID_NhanVien] [int] NULL,
	[ID_Kho] [int] NULL,
	[SoLuong] [int] NULL,
	[ID_MatHang] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 7/24/2022 3:23:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TenDangNhap] [nvarchar](50) NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Quyen] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KHO] ON 

INSERT [dbo].[KHO] ([ID], [Ten], [ID_NhanVien], [SoLuongHang], [DiaDiem]) VALUES (2, N'Kho A', 1, 200, N'Bình Dương')
INSERT [dbo].[KHO] ([ID], [Ten], [ID_NhanVien], [SoLuongHang], [DiaDiem]) VALUES (4, N'Kho B', 5, 300, N'Tp HCM')
INSERT [dbo].[KHO] ([ID], [Ten], [ID_NhanVien], [SoLuongHang], [DiaDiem]) VALUES (5, N'Kho C', 3, 150, N'Đồng Nai')
SET IDENTITY_INSERT [dbo].[KHO] OFF
GO
SET IDENTITY_INSERT [dbo].[LOAIHANG] ON 

INSERT [dbo].[LOAIHANG] ([ID], [TenLoaiHang], [ID_KHO]) VALUES (1, N'Đồ gia dụng', 2)
INSERT [dbo].[LOAIHANG] ([ID], [TenLoaiHang], [ID_KHO]) VALUES (2, N'Điện tử', 2)
INSERT [dbo].[LOAIHANG] ([ID], [TenLoaiHang], [ID_KHO]) VALUES (3, N'Thời trang', 4)
INSERT [dbo].[LOAIHANG] ([ID], [TenLoaiHang], [ID_KHO]) VALUES (4, N'Đồng hồ', 5)
INSERT [dbo].[LOAIHANG] ([ID], [TenLoaiHang], [ID_KHO]) VALUES (5, N'Giày dép', 4)
INSERT [dbo].[LOAIHANG] ([ID], [TenLoaiHang], [ID_KHO]) VALUES (6, N'Điện thoại', 5)
INSERT [dbo].[LOAIHANG] ([ID], [TenLoaiHang], [ID_KHO]) VALUES (9, N'đồooo', 2)
SET IDENTITY_INSERT [dbo].[LOAIHANG] OFF
GO
SET IDENTITY_INSERT [dbo].[MATHANG] ON 

INSERT [dbo].[MATHANG] ([ID], [TenMatHang], [ViTri], [SoLuongTon], [ID_LH]) VALUES (1, N'Đồng hồ Casio', N'Dãy 2, kệ 5', 135, 4)
INSERT [dbo].[MATHANG] ([ID], [TenMatHang], [ViTri], [SoLuongTon], [ID_LH]) VALUES (2, N'Điện thoại Iphone 13', N'Dãy 1, kệ 3, tầng 1', 25, 6)
INSERT [dbo].[MATHANG] ([ID], [TenMatHang], [ViTri], [SoLuongTon], [ID_LH]) VALUES (3, N'Nồi cơm điện', N'Dãy 6, kệ 1, tầng 2', 20, 1)
INSERT [dbo].[MATHANG] ([ID], [TenMatHang], [ViTri], [SoLuongTon], [ID_LH]) VALUES (4, N'Áo thun', N'Dãy 1', 10, 3)
INSERT [dbo].[MATHANG] ([ID], [TenMatHang], [ViTri], [SoLuongTon], [ID_LH]) VALUES (5, N'Áo sơ mi', N'Dãy 3, kệ 6, tầng 2', 5, 3)
INSERT [dbo].[MATHANG] ([ID], [TenMatHang], [ViTri], [SoLuongTon], [ID_LH]) VALUES (6, N'Giày thể thao', N'Dãy 2, kệ 2', 13, 5)
INSERT [dbo].[MATHANG] ([ID], [TenMatHang], [ViTri], [SoLuongTon], [ID_LH]) VALUES (7, N'Ti vi Sony', N'Dãy 1', 10, 2)
INSERT [dbo].[MATHANG] ([ID], [TenMatHang], [ViTri], [SoLuongTon], [ID_LH]) VALUES (1008, N'đồng hồ hublot', N'dãy 4', NULL, 4)
INSERT [dbo].[MATHANG] ([ID], [TenMatHang], [ViTri], [SoLuongTon], [ID_LH]) VALUES (1009, N'đồng hồ điện tử', N'dãy 4', NULL, 4)
SET IDENTITY_INSERT [dbo].[MATHANG] OFF
GO
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([ID], [Ten_NV], [Gioitinh], [Email], [Dienthoai], [NamSinh], [DiaChi]) VALUES (1, N'Doãn Hoài Nam', 0, N'namdoan123@gmail.com', N'0323712806', CAST(N'1999-10-05' AS Date), N'Thị trấn Chơn Thành, Huyện Chơn Thành, Bình Phước')
INSERT [dbo].[NHANVIEN] ([ID], [Ten_NV], [Gioitinh], [Email], [Dienthoai], [NamSinh], [DiaChi]) VALUES (2, N'Cao Đức Minh', 0, N'minhcao20@gmail.com', N'0341645674', CAST(N'1998-12-04' AS Date), N'Xã Lâm Ca, Huyện Đình Lập, Lạng Sơn')
INSERT [dbo].[NHANVIEN] ([ID], [Ten_NV], [Gioitinh], [Email], [Dienthoai], [NamSinh], [DiaChi]) VALUES (3, N'Trần Vĩnh Trường', 0, N'truongtran@gmail.com', N'0346199599', CAST(N'1999-05-01' AS Date), N'Xã Long Hòa, Thị xã Gò Công, Tiền Giang')
INSERT [dbo].[NHANVIEN] ([ID], [Ten_NV], [Gioitinh], [Email], [Dienthoai], [NamSinh], [DiaChi]) VALUES (4, N'Phạm Văn Trường', 0, N'truongpham@gmail.com', N'0341981134', CAST(N'1995-08-22' AS Date), N'Phường Tân Lộc, Quận Thốt Nốt, Cần Thơ')
INSERT [dbo].[NHANVIEN] ([ID], [Ten_NV], [Gioitinh], [Email], [Dienthoai], [NamSinh], [DiaChi]) VALUES (5, N'Nguyễn Hồng Thắm', 1, N'thamnguyen@gmail.com', N'0378454497', CAST(N'1990-04-05' AS Date), N'Xã An Điền, Huyện Thạnh Phú, Bến Tre')
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
GO
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] ON 

INSERT [dbo].[PHIEUNHAP] ([ID], [SoLuong], [NgayLap], [ID_NhanVien], [ID_Kho], [ID_MatHang]) VALUES (1, NULL, CAST(N'2022-07-05' AS Date), 3, 2, 2)
INSERT [dbo].[PHIEUNHAP] ([ID], [SoLuong], [NgayLap], [ID_NhanVien], [ID_Kho], [ID_MatHang]) VALUES (2, NULL, CAST(N'2022-06-15' AS Date), 1, 4, 3)
INSERT [dbo].[PHIEUNHAP] ([ID], [SoLuong], [NgayLap], [ID_NhanVien], [ID_Kho], [ID_MatHang]) VALUES (3, NULL, CAST(N'2022-05-01' AS Date), 3, 2, 1)
INSERT [dbo].[PHIEUNHAP] ([ID], [SoLuong], [NgayLap], [ID_NhanVien], [ID_Kho], [ID_MatHang]) VALUES (4, NULL, CAST(N'2022-07-15' AS Date), 5, 5, 4)
INSERT [dbo].[PHIEUNHAP] ([ID], [SoLuong], [NgayLap], [ID_NhanVien], [ID_Kho], [ID_MatHang]) VALUES (5, NULL, CAST(N'2021-12-25' AS Date), 1, 2, 5)
INSERT [dbo].[PHIEUNHAP] ([ID], [SoLuong], [NgayLap], [ID_NhanVien], [ID_Kho], [ID_MatHang]) VALUES (6, 3, CAST(N'2022-09-15' AS Date), 3, 2, 3)
INSERT [dbo].[PHIEUNHAP] ([ID], [SoLuong], [NgayLap], [ID_NhanVien], [ID_Kho], [ID_MatHang]) VALUES (7, 25, CAST(N'2022-07-22' AS Date), 3, 3, 1)
INSERT [dbo].[PHIEUNHAP] ([ID], [SoLuong], [NgayLap], [ID_NhanVien], [ID_Kho], [ID_MatHang]) VALUES (8, 10, CAST(N'2022-07-23' AS Date), 3, 3, 1)
INSERT [dbo].[PHIEUNHAP] ([ID], [SoLuong], [NgayLap], [ID_NhanVien], [ID_Kho], [ID_MatHang]) VALUES (10, 5, CAST(N'2022-07-23' AS Date), 3, 3, 1)
INSERT [dbo].[PHIEUNHAP] ([ID], [SoLuong], [NgayLap], [ID_NhanVien], [ID_Kho], [ID_MatHang]) VALUES (11, 5, CAST(N'2022-07-23' AS Date), 3, 3, 1)
INSERT [dbo].[PHIEUNHAP] ([ID], [SoLuong], [NgayLap], [ID_NhanVien], [ID_Kho], [ID_MatHang]) VALUES (12, 4, CAST(N'2022-07-23' AS Date), 3, 3, 1)
INSERT [dbo].[PHIEUNHAP] ([ID], [SoLuong], [NgayLap], [ID_NhanVien], [ID_Kho], [ID_MatHang]) VALUES (13, 5, CAST(N'2022-07-24' AS Date), 3, 3, 1)
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] OFF
GO
SET IDENTITY_INSERT [dbo].[PHIEUXUAT] ON 

INSERT [dbo].[PHIEUXUAT] ([ID], [NgayLap], [ID_NhanVien], [ID_Kho], [SoLuong], [ID_MatHang]) VALUES (1, CAST(N'2022-07-30' AS Date), 3, 2, NULL, NULL)
INSERT [dbo].[PHIEUXUAT] ([ID], [NgayLap], [ID_NhanVien], [ID_Kho], [SoLuong], [ID_MatHang]) VALUES (2, CAST(N'2022-08-12' AS Date), 1, 4, NULL, NULL)
INSERT [dbo].[PHIEUXUAT] ([ID], [NgayLap], [ID_NhanVien], [ID_Kho], [SoLuong], [ID_MatHang]) VALUES (3, CAST(N'2022-09-03' AS Date), 2, 5, NULL, NULL)
SET IDENTITY_INSERT [dbo].[PHIEUXUAT] OFF
GO
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [TenNhanVien], [MatKhau], [Quyen]) VALUES (N'NV01', N'Cao Đức Minh', N'1', N'admin')
INSERT [dbo].[TAIKHOAN] ([TenDangNhap], [TenNhanVien], [MatKhau], [Quyen]) VALUES (N'NV02', N'Doãn Hoài Nam', N'2', N'user')
GO
ALTER TABLE [dbo].[KHO]  WITH CHECK ADD  CONSTRAINT [FK_KHO_NHANVIEN] FOREIGN KEY([ID_NhanVien])
REFERENCES [dbo].[NHANVIEN] ([ID])
GO
ALTER TABLE [dbo].[KHO] CHECK CONSTRAINT [FK_KHO_NHANVIEN]
GO
ALTER TABLE [dbo].[LOAIHANG]  WITH CHECK ADD  CONSTRAINT [FK_LOAIHANG_KHO] FOREIGN KEY([ID_KHO])
REFERENCES [dbo].[KHO] ([ID])
GO
ALTER TABLE [dbo].[LOAIHANG] CHECK CONSTRAINT [FK_LOAIHANG_KHO]
GO
ALTER TABLE [dbo].[MATHANG]  WITH CHECK ADD  CONSTRAINT [FK_MATHANG_LOAIHANG] FOREIGN KEY([ID_LH])
REFERENCES [dbo].[LOAIHANG] ([ID])
GO
ALTER TABLE [dbo].[MATHANG] CHECK CONSTRAINT [FK_MATHANG_LOAIHANG]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_MATHANG] FOREIGN KEY([ID_MatHang])
REFERENCES [dbo].[MATHANG] ([ID])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_MATHANG]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHANVIEN] FOREIGN KEY([ID_NhanVien])
REFERENCES [dbo].[NHANVIEN] ([ID])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUAT_NHANVIEN] FOREIGN KEY([ID_NhanVien])
REFERENCES [dbo].[NHANVIEN] ([ID])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK_PHIEUXUAT_NHANVIEN]
GO
