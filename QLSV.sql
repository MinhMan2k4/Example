USE [master]
GO
/****** Object:  Database [QLSV]    Script Date: 2/11/2024 2:26:02 PM ******/
CREATE DATABASE [QLSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MANTRUONG\MSSQL\DATA\QLSV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MANTRUONG\MSSQL\DATA\QLSV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLSV] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLSV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLSV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLSV] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLSV] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLSV]
GO
USE [QLSV]
GO
/****** Object:  Sequence [dbo].[sinhvienSeq]    Script Date: 2/11/2024 2:26:03 PM ******/
CREATE SEQUENCE [dbo].[sinhvienSeq] 
 AS [bigint]
 START WITH 1100
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[tentaikhoan] [varchar](50) NOT NULL,
	[matkhau] [varchar](250) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[tentaikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDiem]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDiem](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](30) NULL,
	[ngaycapnhat] [datetime] NULL,
	[nguoicapnhat] [varchar](30) NULL,
	[masinhvien] [varchar](50) NOT NULL,
	[malophoc] [bigint] NOT NULL,
	[lanhoc] [int] NULL,
	[diemlan1] [float] NULL,
	[diemlan2] [float] NULL,
 CONSTRAINT [PK_tblDiem] PRIMARY KEY CLUSTERED 
(
	[masinhvien] ASC,
	[malophoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGiaoVien]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGiaoVien](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](30) NULL,
	[ngaycapnhat] [datetime] NULL,
	[nguoicapnhat] [varchar](30) NULL,
	[magiaovien] [int] IDENTITY(1,1) NOT NULL,
	[matkhau] [varchar](50) NULL,
	[ho] [nvarchar](10) NOT NULL,
	[tendem] [nvarchar](20) NULL,
	[ten] [nvarchar](10) NOT NULL,
	[gioitinh] [tinyint] NULL,
	[ngaysinh] [date] NULL,
	[dienthoai] [varchar](30) NULL,
	[email] [varchar](150) NULL,
	[diachi] [nvarchar](150) NULL,
 CONSTRAINT [PK_tblGiaoVien] PRIMARY KEY CLUSTERED 
(
	[magiaovien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLopHoc]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLopHoc](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](30) NULL,
	[ngaycapnhat] [datetime] NULL,
	[nguoicapnhat] [varchar](30) NULL,
	[malophoc] [bigint] IDENTITY(1,1) NOT NULL,
	[magiaovien] [int] NOT NULL,
	[mamonhoc] [int] NOT NULL,
	[daketthuc] [tinyint] NULL,
 CONSTRAINT [PK_tblLopHoc] PRIMARY KEY CLUSTERED 
(
	[malophoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMonHoc]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMonHoc](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](30) NULL,
	[ngaycapnhat] [datetime] NULL,
	[nguoicapnhat] [varchar](30) NOT NULL,
	[mamonhoc] [bigint] IDENTITY(1,1) NOT NULL,
	[tenmonhoc] [nvarchar](150) NOT NULL,
	[sotinchi] [int] NULL,
 CONSTRAINT [PK_tblMonHoc] PRIMARY KEY CLUSTERED 
(
	[mamonhoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSinhVien]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSinhVien](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](30) NULL,
	[ngaycapnhat] [datetime] NULL,
	[nguoicapnhat] [varchar](30) NULL,
	[masinhvien] [varchar](50) NOT NULL,
	[ho] [nvarchar](10) NOT NULL,
	[tendem] [nvarchar](20) NULL,
	[ten] [nvarchar](10) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [tinyint] NULL,
	[quequan] [nvarchar](150) NULL,
	[diachi] [nvarchar](150) NULL,
	[dienthoai] [varchar](30) NULL,
	[email] [varchar](150) NULL,
	[matkhau] [varchar](50) NULL,
 CONSTRAINT [PK_tblSinhVien] PRIMARY KEY CLUSTERED 
(
	[masinhvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TaiKhoan] ([tentaikhoan], [matkhau]) VALUES (N'admin', N'admin')
GO
INSERT [dbo].[tblDiem] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [malophoc], [lanhoc], [diemlan1], [diemlan2]) VALUES (CAST(N'2024-10-26T09:24:24.253' AS DateTime), N'admin', CAST(N'2024-10-26T09:24:24.253' AS DateTime), N'admin', N'19SV1102', 1, 1, 0, 0)
INSERT [dbo].[tblDiem] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [malophoc], [lanhoc], [diemlan1], [diemlan2]) VALUES (CAST(N'2024-10-26T09:27:27.650' AS DateTime), N'admin', CAST(N'2024-10-26T09:27:27.650' AS DateTime), N'admin', N'19SV1102', 2, 1, 0, 0)
INSERT [dbo].[tblDiem] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [malophoc], [lanhoc], [diemlan1], [diemlan2]) VALUES (CAST(N'2024-10-26T13:13:27.840' AS DateTime), N'19SV1103', CAST(N'2024-10-26T13:13:27.840' AS DateTime), N'admin', N'19SV1103', 1, 1, 10, 0)
INSERT [dbo].[tblDiem] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [malophoc], [lanhoc], [diemlan1], [diemlan2]) VALUES (CAST(N'2024-10-26T16:08:46.997' AS DateTime), N'19SV1103', CAST(N'2024-10-26T16:08:46.997' AS DateTime), N'admin', N'19SV1103', 3, 1, 10, 0)
INSERT [dbo].[tblDiem] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [malophoc], [lanhoc], [diemlan1], [diemlan2]) VALUES (CAST(N'2024-10-26T13:13:27.863' AS DateTime), N'19SV1104', CAST(N'2024-10-26T13:13:27.863' AS DateTime), N'admin', N'19SV1104', 1, 1, 9, 0)
INSERT [dbo].[tblDiem] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [malophoc], [lanhoc], [diemlan1], [diemlan2]) VALUES (CAST(N'2024-10-26T09:29:42.090' AS DateTime), N'admin', CAST(N'2024-10-26T09:29:42.090' AS DateTime), N'admin', N'19SV1105', 1, 1, 0, 0)
INSERT [dbo].[tblDiem] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [malophoc], [lanhoc], [diemlan1], [diemlan2]) VALUES (CAST(N'2024-10-26T09:31:42.400' AS DateTime), N'admin', CAST(N'2024-10-26T09:31:42.400' AS DateTime), N'admin', N'19SV1106', 1, 1, 0, 0)
INSERT [dbo].[tblDiem] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [malophoc], [lanhoc], [diemlan1], [diemlan2]) VALUES (CAST(N'2024-11-01T14:27:55.110' AS DateTime), N'19SV1106', CAST(N'2024-11-01T14:27:55.110' AS DateTime), N'admin', N'19SV1106', 4, 1, 7, 0)
GO
SET IDENTITY_INSERT [dbo].[tblGiaoVien] ON 

INSERT [dbo].[tblGiaoVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [magiaovien], [matkhau], [ho], [tendem], [ten], [gioitinh], [ngaysinh], [dienthoai], [email], [diachi]) VALUES (CAST(N'2024-10-19T17:20:11.710' AS DateTime), N'data', CAST(N'2024-10-19T17:20:11.710' AS DateTime), N'admin', 1, N'123', N'Truong', N'Minh', N'M?n', 0, CAST(N'1985-06-15' AS Date), N'0123456789', N'man@gmail.com', N'123 Le Loi, Ha Noi')
INSERT [dbo].[tblGiaoVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [magiaovien], [matkhau], [ho], [tendem], [ten], [gioitinh], [ngaysinh], [dienthoai], [email], [diachi]) VALUES (CAST(N'2024-10-19T17:21:31.737' AS DateTime), N'admin', CAST(N'2024-11-01T19:31:08.960' AS DateTime), N'admin', 2, N'123', N'Phan', N'Minh', N'Tâm', 1, CAST(N'1985-06-15' AS Date), N'0123456789', N'tam@gmail.com', N'123 Le Loi, Ha Noi')
INSERT [dbo].[tblGiaoVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [magiaovien], [matkhau], [ho], [tendem], [ten], [gioitinh], [ngaysinh], [dienthoai], [email], [diachi]) VALUES (CAST(N'2024-10-19T17:28:55.803' AS DateTime), N'admin', CAST(N'2024-10-19T17:28:55.803' AS DateTime), N'admin', 3, N'123', N'Nguyễn', N'Thị', N'Linh', 0, CAST(N'1992-03-22' AS Date), N'0981234567', N'linhnguyen@gmail.com', N'789 Hoang Hoa Tham, HCM')
INSERT [dbo].[tblGiaoVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [magiaovien], [matkhau], [ho], [tendem], [ten], [gioitinh], [ngaysinh], [dienthoai], [email], [diachi]) VALUES (CAST(N'2024-10-19T17:28:55.803' AS DateTime), N'admin', CAST(N'2024-10-19T17:28:55.803' AS DateTime), N'admin', 4, N'123', N'Phạm', N'Hải', N'Nam', 1, CAST(N'1980-11-08' AS Date), N'0976543210', N'nampham@gmail.com', N'567 Phan Chu Trinh, Da Nang')
INSERT [dbo].[tblGiaoVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [magiaovien], [matkhau], [ho], [tendem], [ten], [gioitinh], [ngaysinh], [dienthoai], [email], [diachi]) VALUES (CAST(N'2024-10-19T17:28:55.803' AS DateTime), N'admin', CAST(N'2024-10-19T17:28:55.803' AS DateTime), N'admin', 5, N'123', N'Lê', N'Văn', N'Hoàng', 1, CAST(N'1995-07-17' AS Date), N'0912345678', N'hoangle@gmail.com', N'345 Tran Hung Dao, Hue')
SET IDENTITY_INSERT [dbo].[tblGiaoVien] OFF
GO
SET IDENTITY_INSERT [dbo].[tblLopHoc] ON 

INSERT [dbo].[tblLopHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [malophoc], [magiaovien], [mamonhoc], [daketthuc]) VALUES (CAST(N'2024-10-25T21:02:55.867' AS DateTime), N'admin', CAST(N'2024-10-25T21:02:55.867' AS DateTime), N'admin', 1, 1, 1, 0)
INSERT [dbo].[tblLopHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [malophoc], [magiaovien], [mamonhoc], [daketthuc]) VALUES (CAST(N'2024-10-25T21:02:55.867' AS DateTime), N'admin', CAST(N'2024-10-25T21:02:55.867' AS DateTime), N'admin', 2, 5, 2, 0)
INSERT [dbo].[tblLopHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [malophoc], [magiaovien], [mamonhoc], [daketthuc]) VALUES (CAST(N'2024-10-25T21:02:55.867' AS DateTime), N'admin', CAST(N'2024-10-25T21:02:55.867' AS DateTime), N'admin', 3, 2, 3, 0)
INSERT [dbo].[tblLopHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [malophoc], [magiaovien], [mamonhoc], [daketthuc]) VALUES (CAST(N'2024-11-01T14:24:04.863' AS DateTime), N'admin', CAST(N'2024-11-01T14:24:04.863' AS DateTime), N'admin', 4, 2, 3, 0)
INSERT [dbo].[tblLopHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [malophoc], [magiaovien], [mamonhoc], [daketthuc]) VALUES (CAST(N'2024-11-01T14:24:40.040' AS DateTime), N'admin', CAST(N'2024-11-01T14:24:40.040' AS DateTime), N'admin', 5, 3, 6, 0)
SET IDENTITY_INSERT [dbo].[tblLopHoc] OFF
GO
SET IDENTITY_INSERT [dbo].[tblMonHoc] ON 

INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-10-19T17:34:01.427' AS DateTime), N'admin', CAST(N'2024-10-25T17:51:33.577' AS DateTime), N'admin', 1, N'Lập trình Weba', 2)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-10-19T17:34:01.427' AS DateTime), N'admin', CAST(N'2024-10-19T17:34:01.427' AS DateTime), N'admin', 2, N'Kỹ thuật phần mềm', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-10-19T17:34:01.427' AS DateTime), N'admin', CAST(N'2024-10-19T17:34:01.427' AS DateTime), N'admin', 3, N'Phân tích thiết kế hệ thống', 4)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-10-19T17:34:01.427' AS DateTime), N'admin', CAST(N'2024-10-19T17:34:01.427' AS DateTime), N'admin', 4, N'Cơ sở dữ liệu', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-10-19T17:34:01.427' AS DateTime), N'admin', CAST(N'2024-10-19T17:34:01.427' AS DateTime), N'admin', 5, N'Trí tuệ nhân tạo', 4)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-10-25T17:52:58.377' AS DateTime), N'admin', CAST(N'2024-10-25T17:52:58.377' AS DateTime), N'admin', 6, N'Trí tuệ nhân tạo', 3)
SET IDENTITY_INSERT [dbo].[tblMonHoc] OFF
GO
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau]) VALUES (CAST(N'2024-10-19T17:46:08.637' AS DateTime), N'admin', CAST(N'2024-10-19T17:46:08.637' AS DateTime), N'admin', N'19SV1102', N'Trương', N'Minh', N'Mẫn', CAST(N'2000-01-12' AS Date), 1, N'a', N'a', N'a', N'a', N'123')
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau]) VALUES (CAST(N'2024-10-19T17:49:20.503' AS DateTime), N'admin', CAST(N'2024-10-19T17:49:20.503' AS DateTime), N'admin', N'19SV1103', N'Nguyễn', N'Văn', N'An', CAST(N'2000-02-15' AS Date), 1, NULL, NULL, NULL, NULL, N'123')
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau]) VALUES (CAST(N'2024-10-19T17:49:20.503' AS DateTime), N'admin', CAST(N'2024-10-19T17:49:20.503' AS DateTime), N'admin', N'19SV1104', N'Lê', N'', N'Hải', CAST(N'2000-03-22' AS Date), 0, N'a', N'a', N'44444444', N'a@gmail.com', N'123')
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau]) VALUES (CAST(N'2024-10-19T17:49:20.503' AS DateTime), N'admin', CAST(N'2024-10-19T17:49:20.503' AS DateTime), N'admin', N'19SV1105', N'Phạm', N'Quang', N'Sơn', CAST(N'2000-04-30' AS Date), 1, NULL, NULL, NULL, NULL, N'123')
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau]) VALUES (CAST(N'2024-10-19T17:49:20.503' AS DateTime), N'admin', CAST(N'2024-10-19T17:49:20.503' AS DateTime), N'admin', N'19SV1106', N'Tôn', N'Nhật', N'Bảo', CAST(N'2000-05-05' AS Date), 0, NULL, NULL, NULL, NULL, N'123')
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau]) VALUES (CAST(N'2024-10-24T22:37:03.507' AS DateTime), N'admin', CAST(N'2024-10-24T22:37:03.507' AS DateTime), N'admin', N'19SV1107', N'Trương', N'', N'Nam', CAST(N'2004-11-01' AS Date), 1, N'Đồng Nai', N'Tân Phú', N'00000000000', N'nam@gmail.com', N'123')
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau]) VALUES (CAST(N'2024-10-25T11:48:05.173' AS DateTime), N'admin', CAST(N'2024-10-25T11:48:05.173' AS DateTime), N'admin', N'19SV1108', N'Nguyen', N'', N'Thao', CAST(N'2004-11-01' AS Date), 0, N'a', N'a', N'55555555', N'thao@gmail.com', N'123')
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau]) VALUES (CAST(N'2024-10-26T13:31:39.827' AS DateTime), N'admin', CAST(N'2024-10-26T13:31:39.827' AS DateTime), N'admin', N'19SV1110', N'Bui', N'Duc', N'Hoa', CAST(N'2004-11-01' AS Date), 1, N'aa', N'aa', N'44324646', N'b1@gmail.com', N'123')
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhat], [nguoicapnhat], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau]) VALUES (CAST(N'2024-11-01T18:50:48.337' AS DateTime), N'admin', CAST(N'2024-11-01T18:50:48.337' AS DateTime), N'admin', N'19SV1159', N'Bui', N'Duc', N'Kiem', CAST(N'2000-11-11' AS Date), 1, N'a', N'a', N'55554', N'a', N'123')
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_ngaytao_1]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_nguoitao_1]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_ngaycapnhat_1]  DEFAULT (getdate()) FOR [ngaycapnhat]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_nguoicapnhat_1]  DEFAULT ('admin') FOR [nguoicapnhat]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_lanhoc]  DEFAULT ((1)) FOR [lanhoc]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_diemlan1]  DEFAULT ((0)) FOR [diemlan1]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_diemlan2]  DEFAULT ((0)) FOR [diemlan2]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_ngaycapnhat]  DEFAULT (getdate()) FOR [ngaycapnhat]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_nguoicapnhat]  DEFAULT ('admin') FOR [nguoicapnhat]
GO
ALTER TABLE [dbo].[tblGiaoVien] ADD  CONSTRAINT [DF_tblGiaoVien_matkhau]  DEFAULT ((123)) FOR [matkhau]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblDiem_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblDiem_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblDiem_ngaycapnhat]  DEFAULT (getdate()) FOR [ngaycapnhat]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblDiem_nguoicapnhat]  DEFAULT ('admin') FOR [nguoicapnhat]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_daketthuc]  DEFAULT ((0)) FOR [daketthuc]
GO
ALTER TABLE [dbo].[tblMonHoc] ADD  CONSTRAINT [DF_tblMonHoc_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblMonHoc] ADD  CONSTRAINT [DF_tblMonHoc_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblMonHoc] ADD  CONSTRAINT [DF_tblMonHoc_ngaycapnhat]  DEFAULT (getdate()) FOR [ngaycapnhat]
GO
ALTER TABLE [dbo].[tblMonHoc] ADD  CONSTRAINT [DF_tblMonHoc_nguoicapnhat]  DEFAULT ('admin') FOR [nguoicapnhat]
GO
ALTER TABLE [dbo].[tblSinhVien] ADD  CONSTRAINT [DF_tblSinhVien_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblSinhVien] ADD  CONSTRAINT [DF_tblSinhVien_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblSinhVien] ADD  CONSTRAINT [DF_tblSinhVien_ngaycapnhat]  DEFAULT (getdate()) FOR [ngaycapnhat]
GO
ALTER TABLE [dbo].[tblSinhVien] ADD  CONSTRAINT [DF_tblSinhVien_nguoicapnhat]  DEFAULT ('admin') FOR [nguoicapnhat]
GO
ALTER TABLE [dbo].[tblSinhVien] ADD  DEFAULT ('123') FOR [matkhau]
GO
ALTER TABLE [dbo].[tblDiem]  WITH CHECK ADD  CONSTRAINT [FK_tblDiem_tblLopHoc] FOREIGN KEY([malophoc])
REFERENCES [dbo].[tblLopHoc] ([malophoc])
GO
ALTER TABLE [dbo].[tblDiem] CHECK CONSTRAINT [FK_tblDiem_tblLopHoc]
GO
ALTER TABLE [dbo].[tblDiem]  WITH CHECK ADD  CONSTRAINT [FK_tblDiem_tblSinhVien] FOREIGN KEY([masinhvien])
REFERENCES [dbo].[tblSinhVien] ([masinhvien])
GO
ALTER TABLE [dbo].[tblDiem] CHECK CONSTRAINT [FK_tblDiem_tblSinhVien]
GO
ALTER TABLE [dbo].[tblLopHoc]  WITH CHECK ADD  CONSTRAINT [FK_tblDiem_tblGiaoVien] FOREIGN KEY([magiaovien])
REFERENCES [dbo].[tblGiaoVien] ([magiaovien])
GO
ALTER TABLE [dbo].[tblLopHoc] CHECK CONSTRAINT [FK_tblDiem_tblGiaoVien]
GO
ALTER TABLE [dbo].[tblLopHoc]  WITH CHECK ADD  CONSTRAINT [FK_tblDiem_tblMonHoc] FOREIGN KEY([malophoc])
REFERENCES [dbo].[tblMonHoc] ([mamonhoc])
GO
ALTER TABLE [dbo].[tblLopHoc] CHECK CONSTRAINT [FK_tblDiem_tblMonHoc]
GO
/****** Object:  StoredProcedure [dbo].[allLopHoc]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[allLopHoc]
    @tukhoa nvarchar(50)
as
begin
    SELECT 
        l.malophoc,
        CASE 
            WHEN LEN(TRIM(g.tendem)) > 0 
            THEN CONCAT(g.ho, ' ', TRIM(g.tendem), ' ', g.ten)
            ELSE CONCAT(g.ho, ' ', g.ten) 
        END AS gv,
        m.tenmonhoc
    FROM tblLopHoc l
        INNER JOIN tblGiaoVien g ON l.magiaovien = g.magiaovien
        INNER JOIN tblMonHoc m ON l.mamonhoc = m.mamonhoc
    WHERE 
        LOWER(m.tenmonhoc) LIKE '%' + LOWER(@tukhoa) + '%' OR
        LOWER(g.ten) LIKE '%' + LOWER(@tukhoa) + '%' OR
        LOWER(g.tendem) LIKE '%' + LOWER(@tukhoa) + '%' OR
        LOWER(CONCAT(g.ho, ' ', g.tendem, ' ', g.ten)) LIKE '%' + LOWER(@tukhoa) + '%';
end
GO
/****** Object:  StoredProcedure [dbo].[dangnhap]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[dangnhap]
	@loaitaikhoan varchar(10),
	@taikhoan varchar(50),
	@matkhau varchar(50)
as
begin
	if @loaitaikhoan = 'admin' 
			select * from TaiKhoan
			where tentaikhoan = @taikhoan
			and matkhau = @matkhau
		else if @loaitaikhoan = 'gv' 
			select * from tblGiaoVien
			where CONVERT(varchar(50),magiaovien) = @taikhoan
			and matkhau = @matkhau
		else
			select * from tblSinhVien
			where masinhvien = @taikhoan
			and matkhau = @matkhau;
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteGiaoVien]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteGiaoVien]
    @magiaovien int
AS
BEGIN
    DELETE FROM tblGiaoVien WHERE magiaovien = @magiaovien
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteLopHoc]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteLopHoc]
    @malophoc int
AS
BEGIN
    DELETE FROM tblLopHoc WHERE malophoc = @malophoc
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteMonHoc]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteMonHoc]
    @mamonhoc int
AS
BEGIN
    DELETE FROM tblMonHoc WHERE mamonhoc = @mamonhoc
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteSinhVien]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteSinhVien]
    @masinhvien NVARCHAR(50)
AS
BEGIN
    DELETE FROM tblsinhvien WHERE masinhvien = @masinhvien
END
GO
/****** Object:  StoredProcedure [dbo].[dkyhoc]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[dkyhoc]
    @masinhvien VARCHAR(50),
    @malophoc BIGINT
AS
BEGIN
    DECLARE @v_lanhoc INT,
            @v_mamonhoc INT,
			@v_dadangky int;

    -- Lấy mã môn học từ mã lớp học
    SELECT @v_mamonhoc = mamonhoc
    FROM tblLopHoc
    WHERE malophoc = @malophoc;

    -- Kiểm tra số lần học của sinh viên cho môn học đó
    SELECT @v_lanhoc = COUNT(*)
    FROM tblDiem d
    INNER JOIN tblLopHoc l ON d.malophoc = l.malophoc
    WHERE l.daketthuc =1
	and d.masinhvien = @masinhvien
      AND l.mamonhoc = @v_mamonhoc;

	  select @v_dadangky = COUNT(*)
	  from tblDiem d
	  inner join tblLopHoc l on d.malophoc = l.malophoc
	  where l.daketthuc = 0
	  and l.mamonhoc = @v_mamonhoc
	  and d.masinhvien = @masinhvien;

	  if @v_dadangky>0 return -1;

    -- Tăng số lần học lên 1
    SET @v_lanhoc = @v_lanhoc + 1;

    -- Chèn bản ghi mới vào bảng tblDiem
    INSERT INTO tblDiem(nguoitao, masinhvien, malophoc, lanhoc)
    VALUES (@masinhvien, @masinhvien, @malophoc, @v_lanhoc);

    -- Kiểm tra số hàng ảnh hưởng
    IF @@ROWCOUNT > 0 
        RETURN 1;
    ELSE 
        RETURN 0;
END;
GO
/****** Object:  StoredProcedure [dbo].[dsLopChuaDKy]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[dsLopChuaDKy]
	@masinhvien varchar(50)
as
begin
	select 
		l.malophoc,
		l.mamonhoc,
		m.tenmonhoc,
		m.sotinchi,
		case when len(g.tendem)>0 then concat(g.ho,' ',g.tendem,' ',g.ten)
		else concat (g.ho,' ',g.ten) end as giaovien
	from tblLopHoc l
	inner join tblGiaoVien g on l.magiaovien = g.magiaovien
	inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
	where l.daketthuc = 0
	and l.malophoc not in (select malophoc from tblDiem where masinhvien = @masinhvien);

end
GO
/****** Object:  StoredProcedure [dbo].[InsertGV]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertGV]
	@nguoitao varchar(30),
	@ho nvarchar(10),
	@tendem nvarchar(20),
	@ten nvarchar(10),
	@gioitinh tinyint,
	@ngaysinh date,
	@email varchar(150),
	@dienthoai varchar(30),
	@diachi nvarchar(150)
as
begin
	insert into tblGiaoVien
	(
		nguoitao,
		ho,tendem,ten,
		gioitinh,ngaysinh,
		dienthoai,email,diachi
	)values(
		@nguoitao,
		@ho,@tendem,@ten,
		@gioitinh,@ngaysinh,
		@dienthoai,@email,
		@diachi
		);
		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end
GO
/****** Object:  StoredProcedure [dbo].[insertLopHoc]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertLopHoc]
	@nguoitao varchar(30),
	@mamonhoc int,
	@magiaovien int
as
begin
	insert into tblLopHoc(nguoitao,mamonhoc,magiaovien)
	values (@nguoitao,@mamonhoc,@magiaovien);
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end
GO
/****** Object:  StoredProcedure [dbo].[insertMH]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertMH]
	@nguoitao varchar(30),
	@tenmonhoc nvarchar(150),
	@sotinchi int
as
begin
	insert into tblMonHoc
	(
		nguoitao,
		tenmonhoc,
		sotinchi
	)values(
		@nguoitao,
		@tenmonhoc,
		@sotinchi
	);
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end
GO
/****** Object:  StoredProcedure [dbo].[monDaDKy]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[monDaDKy]
    @masinhvien VARCHAR(50)
AS
BEGIN
    SELECT 
        l.malophoc,
        m.tenmonhoc,
        CASE 
            WHEN LEN(g.tendem) > 0 THEN CONCAT(g.ho, ' ', g.tendem, ' ', g.ten)
            ELSE CONCAT(g.ho, ' ', g.ten) 
        END AS giaovien,
        m.sotinchi,
        d.diemlan1,
        d.diemlan2
    FROM tblDiem d
    INNER JOIN tblLopHoc l ON d.malophoc = l.malophoc
    INNER JOIN tblMonHoc m ON l.mamonhoc = m.mamonhoc
    INNER JOIN tblGiaoVien g ON l.magiaovien = g.magiaovien
    WHERE l.daketthuc = 0
      AND d.masinhvien = @masinhvien;
END;
GO
/****** Object:  StoredProcedure [dbo].[selectAllGV]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[selectAllGV]
    @tukhoa NVARCHAR(50)
AS
BEGIN
    SELECT 
        magiaovien,
        CASE
            WHEN LEN(tendem) > 0 THEN CONCAT(ho, ' ', tendem, ' ', ten)
            ELSE CONCAT(ho, ' ', ten)
        END AS hoten,
        CASE 
            WHEN gioitinh = 1 THEN N'Nam'
            ELSE N'Nữ' 
        END AS gt,
        dienthoai,
        email,
        diachi
    FROM tblGiaoVien
    WHERE 
	lower(concat(ho,' ',tendem,' ',ten)) like '%'+lower(trim(@tukhoa))+'%'
	or lower(ho) like '%'+lower(trim(@tukhoa))+'%'
	or lower(tendem) like '%'+lower(trim(@tukhoa))+'%'
	or lower(ten) like '%'+lower(trim(@tukhoa))+'%'
	or dienthoai like '%'+lower(trim(@tukhoa))+'%'
	or CAST(magiaovien as varchar(30)) like '%'+lower(trim(@tukhoa))+'%'
	or lower(email) like '%'+lower(trim(@tukhoa))+'%'
	order by ten;
END
GO
/****** Object:  StoredProcedure [dbo].[selectAllMonHoc]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectAllMonHoc]
	@tukhoa nvarchar(30)
as
begin
	select 
		mamonhoc,
		tenmonhoc,
		sotinchi
	from tblMonHoc
	where mamonhoc like '%'+lower(trim(@tukhoa))+'%'
	or lower(tenmonhoc) like '%'+lower(trim(@tukhoa))+'%'
	order by tenmonhoc;
end
GO
/****** Object:  StoredProcedure [dbo].[SelectAllSinhVien]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectAllSinhVien]
	@tukhoa nvarchar(50)
AS
	select 
		masinhvien,
		case
			when LEN(tendem) >0 then
				CONCAT(ho,' ',tendem,' ',ten)
			else CONCAT(ho,' ',ten)
		end as hoten,
		CONVERT(varchar(10),ngaysinh,103) as ngaysinh,
		case
			when gioitinh = 1 then N'Nam'
			else N'Nữ'
		end as gioitinh,
		quequan,
		diachi,
		dienthoai,
		email
	from tblSinhvien
	where 
		lower (ho) like '%'+lower(trim(@tukhoa)) +'%'
		or lower(tendem) like '%'+lower(trim(@tukhoa)) +'%'
		or lower(ten) like '%'+lower(trim(@tukhoa)) +'%'
		or dienthoai like '%'+lower(trim(@tukhoa)) +'%'
		or lower(email) like '%'+lower(trim(@tukhoa)) +'%'
	order by ten;
GO
/****** Object:  StoredProcedure [dbo].[selectGV]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[selectGV]
	@magiaovien int
as
begin
	select 
	ho,
	tendem,
	ten,
	gioitinh,
	convert(varchar(10),ngaysinh,103) as ngaysinh,
	dienthoai, email,
	diachi
	from tblGiaoVien
	where magiaovien = @magiaovien;
end
GO
/****** Object:  StoredProcedure [dbo].[selectLopHoc]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectLopHoc]
	@malophoc bigint
as
begin
	select magiaovien,mamonhoc from tblLopHoc where malophoc = @malophoc
end
GO
/****** Object:  StoredProcedure [dbo].[selectMH]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectMH]
	@mamonhoc int
as
begin
	select
		tenmonhoc,
		sotinchi
	from tblMonHoc
	where mamonhoc = @mamonhoc;
end
GO
/****** Object:  StoredProcedure [dbo].[selectSV]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[selectSV]
	@masinhvien varchar(50)
as
begin
	select 
	ho,tendem,ten,convert(varchar(10),ngaysinh,103) as ngaysinh,
	gioitinh,
	quequan,diachi,dienthoai,email
	from tblSinhVien
	where masinhvien= @masinhvien;
end
GO
/****** Object:  StoredProcedure [dbo].[ThemMoiSV]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ThemMoiSV]
	@Ho nvarchar(10),
	@TenDem nvarchar(20),
	@Ten nvarchar(10),
	@Ngaysinh date,
	@Gioitinh tinyint,
	@Quequan nvarchar(150),
	@Diachi nvarchar(150),
	@Dienthoai varchar(30),
	@Email varchar(150)
AS
	BEGIN
		INSERT INTO tblSinhVien
		(
			masinhvien,
			ho,tendem,ten,
			ngaysinh,gioitinh,
			quequan,diachi,
			dienthoai,email
		)values(
			'19SV'+ CAST(next value for sinhvienSeq as varchar(30)),
			@Ho,@TenDem,@Ten,
			@Ngaysinh,
			@Gioitinh,
			@Quequan,@Diachi,
			@Dienthoai,@Email
		);
		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;


END
GO
/****** Object:  StoredProcedure [dbo].[tracuudiem]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[tracuudiem]
	@masinhvien varchar(50),
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(@tukhoa);
	select 
		m.mamonhoc,
		m.tenmonhoc,
		d.lanhoc,
		case when len(g.magiaovien) > 0 then concat(g.ho,' ',g.tendem,' ',g.ten)
		else concat(g.ho,' ',g.ten) end as giaovien,
		d.diemlan1,
		d.diemlan2
	from tblDiem d
	inner join tblLopHoc l on d.malophoc = l.malophoc
	inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
	inner join tblGiaoVien g on l.magiaovien = g.magiaovien
	where l.daketthuc = 1
	and d.masinhvien = @masinhvien
	and lower(m.tenmonhoc) like '%'+@tukhoa+'%';
end
GO
/****** Object:  StoredProcedure [dbo].[tracuulop]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[tracuulop]
	@magiaovien int,
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(@tukhoa);
	select 
	tb.malophoc,
	tb.mamonhoc,
	tb.tenmonhoc,
	tb.sotinchi,
	count(d.masinhvien) as siso
from 
(
	select 
	l.malophoc,
	l.mamonhoc,
	m.tenmonhoc,
	m.sotinchi
from tblLopHoc l
inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
where daketthuc = 0
and magiaovien = @magiaovien
and lower(m.mamonhoc) like '%'+@tukhoa+'%'
) as tb inner join tblDiem d on d.malophoc = tb.malophoc
group by tb.malophoc,tb.mamonhoc,tb.tenmonhoc,tb.sotinchi
select * from tblDiem where malophoc = 1
end



GO
/****** Object:  StoredProcedure [dbo].[updateGV]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateGV]
	@nguoicapnhat varchar(30),
	@magiaovien int,
	@ho nvarchar(10),
	@tendem nvarchar(20),
	@ten nvarchar(10),
	@gioitinh tinyint,
	@ngaysinh date,
	@dienthoai varchar(30),
	@email varchar(150),
	@diachi nvarchar(150)
as
begin
	update tblGiaoVien
	set
		nguoicapnhat = @nguoicapnhat,
		ngaycapnhat = getdate(),
		ho = @ho, tendem = @tendem, ten = @ten,
		gioitinh = @gioitinh, ngaysinh = @ngaysinh,
		dienthoai = @dienthoai, email = @email, diachi = @diachi
	where magiaovien = @magiaovien;
end

GO
/****** Object:  StoredProcedure [dbo].[updateLopHoc]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[updateLopHoc]
	@nguoicapnhat varchar(30),
	@malophoc int,
	@mamonhoc int,
	@magiaovien int
as
begin
	update tblLopHoc
	set nguoicapnhat = @nguoicapnhat,
		ngaycapnhat = GETDATE(),
		magiaovien = @magiaovien,
		mamonhoc = @mamonhoc
	where malophoc =@malophoc;
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end
GO
/****** Object:  StoredProcedure [dbo].[updateMH]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateMH]
	@nguoicapnhat varchar(30),
	@mamonhoc int,
	@tenmonhoc nvarchar(150),
	@sotinchi int
as
begin
	update tblMonHoc
	set 
		nguoicapnhat = @nguoicapnhat,
		ngaycapnhat = GETDATE(),
		tenmonhoc = @tenmonhoc,
		sotinchi = @sotinchi
	where mamonhoc =@mamonhoc;
	if @@ROWCOUNT > 0 begin return 1 end 
	else begin return 0 end;
end
GO
/****** Object:  StoredProcedure [dbo].[updateSV]    Script Date: 2/11/2024 2:26:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateSV]
    @masinhvien varchar(50),
    @ho nvarchar(10),
    @tendem nvarchar(20),
    @ten nvarchar(10),
    @ngaysinh date,
    @gioitinh tinyint,
    @quequan nvarchar(150),
    @diachi nvarchar(150),
    @dienthoai varchar(30),
    @email varchar(150)
AS
BEGIN
    UPDATE tblSinhVien
    SET
        ho = @ho,
        tendem = @tendem,
        ten = @ten,
        ngaysinh = @ngaysinh,
        gioitinh = @gioitinh,
        quequan = @quequan,
        diachi = @diachi,
        dienthoai = @dienthoai,
        email = @email
    WHERE masinhvien = @masinhvien;

    IF @@ROWCOUNT > 0 
    BEGIN 
        RETURN 1; 
    END
    ELSE 
    BEGIN 
        RETURN 0; 
    END
END;
GO
USE [master]
GO
ALTER DATABASE [QLSV] SET  READ_WRITE 
GO
