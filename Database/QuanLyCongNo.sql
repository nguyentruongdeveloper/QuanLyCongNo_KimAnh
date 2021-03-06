USE [QuanLyCongNo]
GO
/****** Object:  Table [dbo].[tbl_Chi_Tiet_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Chi_Tiet_Dich_Vu](
	[Auto_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Chung_Tu_ID] [bigint] NULL,
	[Dich_Vu_ID] [int] NULL,
	[Xe_ID] [int] NULL,
	[So_Luong] [decimal](18, 2) NULL,
	[Don_Gia] [decimal](18, 4) NULL,
	[Thanh_Tien] [decimal](18, 4) NULL,
	[Dia_Chi_Lay] [nvarchar](500) NULL,
	[Dia_Chi_Do] [nvarchar](500) NULL,
	[Created] [datetime] NULL,
	[Created_By] [nvarchar](250) NULL,
	[Last_Updated] [datetime] NULL,
	[Last_Updated_By] [nvarchar](250) NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_tbl_Chi_Tiet_Dich_Vu] PRIMARY KEY CLUSTERED 
(
	[Auto_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[view_Chi_Tiet_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_Chi_Tiet_Dich_Vu]
AS
SELECT A.Auto_ID, A.Chung_Tu_ID, A.Dich_Vu_ID, A.Xe_ID, A.So_Luong, A.Don_Gia, A.Thanh_Tien, A.Dia_Chi_Lay, A.Dia_Chi_Do, A.Created, A.Created_By, A.Last_Updated, A.Last_Updated_By, A.Deleted 
FROM dbo.tbl_Chi_Tiet_Dich_Vu AS A
WHERE
	(deleted = 0)

GO
/****** Object:  Table [dbo].[tbl_Khach_Hang]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Khach_Hang](
	[Auto_ID] [int] IDENTITY(1,1) NOT NULL,
	[Ma_Khach_Hang] [varchar](50) NULL,
	[Ten_Khach_Hang] [nvarchar](250) NULL,
	[Dia_Chi] [nvarchar](250) NULL,
	[So_Dien_Thoai] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[Created] [datetime] NULL,
	[Created_By] [nvarchar](250) NULL,
	[Last_Updated] [datetime] NULL,
	[Last_Updated_By] [nvarchar](250) NULL,
	[Deleted] [bit] NULL,
	[Ma_So_Thue] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_KhachHang] PRIMARY KEY CLUSTERED 
(
	[Auto_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[view_Khach_Hang]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_Khach_Hang]
AS
SELECT A.Auto_ID, A.Ma_Khach_Hang, A.Ten_Khach_Hang, A.Dia_Chi, A.So_Dien_Thoai, A.Email, A.Created, A.Created_By, A.Last_Updated, A.Last_Updated_By, A.Deleted, A.Ma_So_Thue 
FROM dbo.tbl_Khach_Hang AS A
WHERE
	(deleted = 0)

GO
/****** Object:  Table [dbo].[tbl_Chung_Tu_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Chung_Tu_Dich_Vu](
	[Auto_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Khach_Hang_ID] [int] NULL,
	[Nhan_Vien_ID] [int] NULL,
	[Dien_Giai] [nvarchar](250) NULL,
	[TongTien] [decimal](18, 4) NULL,
	[Created] [datetime] NULL,
	[Created_By] [nvarchar](250) NULL,
	[Last_Updated] [datetime] NULL,
	[Last_Updated_By] [nvarchar](250) NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_tbl_Chung_Tu_Dich_Vu] PRIMARY KEY CLUSTERED 
(
	[Auto_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[view_Chung_Tu_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[view_Chung_Tu_Dich_Vu]
AS
SELECT A.Auto_ID, A.Khach_Hang_ID, A.Nhan_Vien_ID, A.Dien_Giai, A.TongTien, A.Created, A.Created_By, A.Last_Updated, A.Last_Updated_By, A.Deleted 
FROM dbo.tbl_Chung_Tu_Dich_Vu AS A
WHERE
	(deleted = 0)




GO
/****** Object:  Table [dbo].[tbl_Cong_No_Dau_Ky_Khach_Hang]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Cong_No_Dau_Ky_Khach_Hang](
	[Auto_ID] [int] IDENTITY(1,1) NOT NULL,
	[Khach_Hang_ID] [int] NULL,
	[Tien_No] [decimal](18, 4) NULL,
	[Dien_Giai] [nvarchar](255) NULL,
	[Deleted] [bit] NULL,
	[Created] [datetime] NULL,
	[Created_By] [nvarchar](255) NULL,
	[Last_Updated] [datetime] NULL,
	[Last_Updated_By] [nvarchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[view_Cong_No_Dau_Ky_Khach_Hang]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[view_Cong_No_Dau_Ky_Khach_Hang]
AS
SELECT A.Auto_ID, A.Khach_Hang_ID, A.Tien_No, A.Dien_Giai, A.Deleted, A.Created, A.Created_By, A.Last_Updated, A.Last_Updated_By ,
b.Ma_Khach_Hang,b.Ten_Khach_Hang
FROM dbo.tbl_Cong_No_Dau_Ky_Khach_Hang AS A left join view_Khach_Hang as B on a.Khach_Hang_ID = b.Auto_ID
WHERE
	(A.deleted = 0)


GO
/****** Object:  Table [dbo].[tbl_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Dich_Vu](
	[Auto_ID] [int] IDENTITY(1,1) NOT NULL,
	[Ma_Dich_Vu] [varchar](50) NULL,
	[Ten_Dich_Vu] [nvarchar](255) NULL,
	[Dien_Giai] [nvarchar](255) NULL,
	[Created] [datetime] NULL,
	[Created_By] [nvarchar](250) NULL,
	[Last_Updated] [datetime] NULL,
	[Last_Updated_By] [nvarchar](250) NULL,
	[Deleted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Auto_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[view_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[view_Dich_Vu]
AS
SELECT A.Auto_ID, A.Ma_Dich_Vu, A.Ten_Dich_Vu, A.Dien_Giai, A.Created, A.Created_By, A.Last_Updated, A.Last_Updated_By, A.Deleted 
FROM dbo.tbl_Dich_Vu AS A
WHERE
	(deleted = 0)




GO
/****** Object:  Table [dbo].[tbl_Dieu_Khoan_Thanh_Toan]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Dieu_Khoan_Thanh_Toan](
	[Auto_ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDieuKhoan] [nvarchar](250) NULL,
	[Created] [datetime] NULL,
	[Created_By] [nvarchar](250) NULL,
	[Last_Updated] [datetime] NULL,
	[Last_Updated_By] [nvarchar](250) NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_tbl_DieuKhoanThanhToan] PRIMARY KEY CLUSTERED 
(
	[Auto_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[view_Dieu_Khoan_Thanh_Toan]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[view_Dieu_Khoan_Thanh_Toan]
AS
SELECT A.Auto_ID, A.TenDieuKhoan, A.Created, A.Created_By, A.Last_Updated, A.Last_Updated_By, A.Deleted 
FROM dbo.tbl_Dieu_Khoan_Thanh_Toan AS A
WHERE
	(deleted = 0)




GO
/****** Object:  Table [dbo].[tbl_Loai_Thu_Chi]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Loai_Thu_Chi](
	[Auto_ID] [int] IDENTITY(1,1) NOT NULL,
	[Ma_Loai] [varchar](50) NULL,
	[Ten_Loai] [nvarchar](250) NULL,
	[Created] [datetime] NULL,
	[Created_By] [nvarchar](250) NULL,
	[Last_Updated] [datetime] NULL,
	[Last_Updated_By] [nvarchar](250) NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_tbl_LoaiThuChi] PRIMARY KEY CLUSTERED 
(
	[Auto_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[view_Loai_Thu_Chi]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[view_Loai_Thu_Chi]
AS
SELECT A.Auto_ID, A.Ma_Loai, A.Ten_Loai, A.Created, A.Created_By, A.Last_Updated, A.Last_Updated_By, A.Deleted 
FROM dbo.tbl_Loai_Thu_Chi AS A
WHERE
	(deleted = 0)




GO
/****** Object:  Table [dbo].[tbl_Nhan_Vien]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Nhan_Vien](
	[Auto_ID] [int] IDENTITY(1,1) NOT NULL,
	[Ma_Nhan_Vien] [varchar](50) NULL,
	[Ten_Nhan_Vien] [nvarchar](250) NULL,
	[So_Dien_Thoai] [varchar](50) NULL,
	[Dia_Chi] [nvarchar](250) NULL,
	[Created] [datetime] NULL,
	[Created_By] [nvarchar](250) NULL,
	[Last_Updated] [datetime] NULL,
	[Last_Updated_By] [nvarchar](250) NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_tbl_NhanVien] PRIMARY KEY CLUSTERED 
(
	[Auto_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[view_Nhan_Vien]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[view_Nhan_Vien]
AS
SELECT A.Auto_ID, A.Ma_Nhan_Vien, A.Ten_Nhan_Vien, A.So_Dien_Thoai, A.Dia_Chi, A.Created, A.Created_By, A.Last_Updated, A.Last_Updated_By, A.Deleted 
FROM dbo.tbl_Nhan_Vien AS A
WHERE
	(deleted = 0)




GO
/****** Object:  Table [dbo].[tbl_Noi_Dung_Thu_Chi]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Noi_Dung_Thu_Chi](
	[Auto_ID] [int] IDENTITY(1,1) NOT NULL,
	[Loai_Thu_Chi_ID] [int] NULL,
	[Noi_Dung] [nvarchar](250) NULL,
	[Created] [datetime] NULL,
	[Created_By] [nvarchar](250) NULL,
	[Last_Updated] [datetime] NULL,
	[Last_Updated_By] [nvarchar](250) NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_tbl_NoiDungThuChi] PRIMARY KEY CLUSTERED 
(
	[Auto_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[view_Noi_Dung_Thu_Chi]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_Noi_Dung_Thu_Chi]
AS
SELECT        A.Auto_ID, A.Loai_Thu_Chi_ID, A.Noi_Dung, A.Created, A.Created_By, A.Last_Updated, A.Last_Updated_By, A.Deleted, B.Ten_Loai AS Expr1, B.Ten_Loai
FROM            dbo.tbl_Noi_Dung_Thu_Chi AS A LEFT OUTER JOIN
                         dbo.view_Loai_Thu_Chi AS B ON A.Loai_Thu_Chi_ID = B.Auto_ID
WHERE        (A.Deleted = 0)

GO
/****** Object:  Table [dbo].[tbl_Tai_Khoan]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Tai_Khoan](
	[Auto_ID] [int] IDENTITY(1,1) NOT NULL,
	[Nhan_Vien_ID] [int] NULL,
	[Tai_Khoan] [nvarchar](50) NULL,
	[Mat_Khau] [varchar](50) NULL,
	[Created] [datetime] NULL,
	[Created_By] [nvarchar](250) NULL,
	[Last_Updated] [datetime] NULL,
	[Last_Updated_By] [nvarchar](250) NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_tbl_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[Auto_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[view_Tai_Khoan]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[view_Tai_Khoan]
AS
SELECT A.Auto_ID, A.Nhan_Vien_ID, A.Tai_Khoan, A.Mat_Khau, A.Created, A.Created_By, A.Last_Updated, A.Last_Updated_By, A.Deleted 
FROM dbo.tbl_Tai_Khoan AS A
WHERE
	(deleted = 0)




GO
/****** Object:  Table [dbo].[tbl_Xe]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Xe](
	[Auto_ID] [int] IDENTITY(1,1) NOT NULL,
	[So_Xe] [varchar](50) NULL,
	[Ten_Xe] [nvarchar](250) NULL,
	[Trong_Tai] [nvarchar](255) NULL,
	[Created] [datetime] NULL,
	[Created_By] [nvarchar](250) NULL,
	[Last_Updated] [datetime] NULL,
	[Last_Updated_By] [nvarchar](250) NULL,
	[Deleted] [bit] NULL,
	[Ghi_Chu] [nvarchar](250) NULL
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[view_Xe]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[view_Xe]
AS
SELECT A.Auto_ID, A.So_Xe, A.Ten_Xe, A.Trong_Tai, A.Created, A.Created_By, A.Last_Updated, A.Last_Updated_By, A.Deleted, A.Ghi_Chu 
FROM dbo.tbl_Xe AS A
WHERE
	(deleted = 0)




GO
/****** Object:  StoredProcedure [dbo].[sp_del_Chi_Tiet_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_del_Chi_Tiet_Dich_Vu]
	@Auto_ID int,
	@Last_Updated_By nvarchar(200)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Chi_Tiet_Dich_Vu SET
		deleted = 1,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END


GO
/****** Object:  StoredProcedure [dbo].[sp_del_Chung_Tu_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_del_Chung_Tu_Dich_Vu]
	@Auto_ID int,
	@Last_Updated_By nvarchar(200)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Chung_Tu_Dich_Vu SET
		deleted = 1,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_del_Cong_No_Dau_Ky_Khach_Hang]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_del_Cong_No_Dau_Ky_Khach_Hang]
	@Auto_ID int,
	@Last_Updated_By nvarchar(200)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Cong_No_Dau_Ky_Khach_Hang SET
		deleted = 1,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_del_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_del_Dich_Vu]
	@Auto_ID int,
	@Last_Updated_By nvarchar(200)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Dich_Vu SET
		deleted = 1,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_del_Dieu_Khoan_Thanh_Toan]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_del_Dieu_Khoan_Thanh_Toan]
	@Auto_ID int,
	@Last_Updated_By nvarchar(200)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Dieu_Khoan_Thanh_Toan SET
		deleted = 1,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END


GO
/****** Object:  StoredProcedure [dbo].[sp_del_Khach_Hang]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_del_Khach_Hang]
	@Auto_ID int,
	@Last_Updated_By nvarchar(200)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Khach_Hang SET
		deleted = 1,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_del_Loai_Thu_Chi]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_del_Loai_Thu_Chi]
	@Auto_ID int,
	@Last_Updated_By nvarchar(200)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Loai_Thu_Chi SET
		deleted = 1,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_Nhan_Vien]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_del_Nhan_Vien]
	@Auto_ID int,
	@Last_Updated_By nvarchar(200)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Nhan_Vien SET
		deleted = 1,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_Noi_Dung_Thu_Chi]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_del_Noi_Dung_Thu_Chi]
	@Auto_ID int,
	@Last_Updated_By nvarchar(200)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Noi_Dung_Thu_Chi SET
		deleted = 1,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_Tai_Khoan]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_del_Tai_Khoan]
	@Auto_ID int,
	@Last_Updated_By nvarchar(200)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Tai_Khoan SET
		deleted = 1,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END


GO
/****** Object:  StoredProcedure [dbo].[sp_del_Xe]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_del_Xe]
	@Auto_ID int,
	@Last_Updated_By nvarchar(200)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Xe SET
		deleted = 1,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END


GO
/****** Object:  StoredProcedure [dbo].[sp_ins_Chung_Tu_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ins_Chung_Tu_Dich_Vu]
	@Khach_Hang_ID int,
	@Nhan_Vien_ID int,
	@Dien_Giai nvarchar(250),
	@TongTien decimal,
	@Last_Updated_By nvarchar(250)
AS
BEGIN
	
	INSERT INTO tbl_Chung_Tu_Dich_Vu
	(
		
		Khach_Hang_ID,
		Nhan_Vien_ID,
		Dien_Giai,
		TongTien,
		deleted,
		Created,
		Created_By,
		Last_Updated,
		Last_Updated_By
	)
	VALUES
	(
		
		@Khach_Hang_ID,
		@Nhan_Vien_ID,
		@Dien_Giai,
		@TongTien,
		0,
		getdate(),
		@Last_Updated_By,
		getdate(),
		@Last_Updated_By
	)

	
END




GO
/****** Object:  StoredProcedure [dbo].[sp_ins_Cong_No_Dau_Ky_Khach_Hang]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ins_Cong_No_Dau_Ky_Khach_Hang]
	@KhachHang_ID int,
	@Tien_No decimal,
	@Dien_Giai nvarchar(255),
	@Last_Updated_By nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;

	declare @Auto_ID int
	set @Auto_ID = (next value for dbo.Seq_ID)

	INSERT INTO tbl_Cong_No_Dau_Ky_Khach_Hang
	(
		Auto_ID,
		KhachHang_ID,
		Tien_No,
		Dien_Giai,
		deleted,
		Created,
		Created_By,
		Last_Updated,
		Last_Updated_By
	)
	VALUES
	(
		@Auto_ID,
		@KhachHang_ID,
		@Tien_No,
		@Dien_Giai,
		0,
		getdate(),
		@Last_Updated_By,
		getdate(),
		@Last_Updated_By
	)

	SELECT @Auto_ID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ins_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ins_Dich_Vu]
	@Ma_Dich_Vu varchar(50),
	@Ten_Dich_Vu nvarchar(255),
	@Dien_Giai nvarchar(255),
	@Last_Updated_By nvarchar(250)
AS
BEGIN
	

	INSERT INTO tbl_Dich_Vu
	(
		
		Ma_Dich_Vu,
		Ten_Dich_Vu,
		Dien_Giai,
		deleted,
		Created,
		Created_By,
		Last_Updated,
		Last_Updated_By
	)
	VALUES
	(
		
		@Ma_Dich_Vu,
		@Ten_Dich_Vu,
		@Dien_Giai,
		0,
		getdate(),
		@Last_Updated_By,
		getdate(),
		@Last_Updated_By
	)

	
END




GO
/****** Object:  StoredProcedure [dbo].[sp_ins_Dieu_Khoan_Thanh_Toan]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ins_Dieu_Khoan_Thanh_Toan]
	@TenDieuKhoan nvarchar(250),
	@Last_Updated_By nvarchar(250)
AS
BEGIN
	

	INSERT INTO tbl_Dieu_Khoan_Thanh_Toan
	(
		
		TenDieuKhoan,
		deleted,
		Created,
		Created_By,
		Last_Updated,
		Last_Updated_By
	)
	VALUES
	(
		
		@TenDieuKhoan,
		0,
		getdate(),
		@Last_Updated_By,
		getdate(),
		@Last_Updated_By
	)

	
END




GO
/****** Object:  StoredProcedure [dbo].[sp_ins_Khach_Hang]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ins_Khach_Hang]
	@Ma_Khach_Hang varchar(50),
	@Ten_Khach_Hang nvarchar(250),
	@Dia_Chi nvarchar(250),
	@So_Dien_Thoai varchar(20),
	@Email varchar(50),
	@Last_Updated_By nvarchar(250),
	@Ma_So_Thue varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	declare @Auto_ID int
	set @Auto_ID = (next value for dbo.Seq_ID)

	INSERT INTO tbl_Khach_Hang
	(
		Auto_ID,
		Ma_Khach_Hang,
		Ten_Khach_Hang,
		Dia_Chi,
		So_Dien_Thoai,
		Email,
		Ma_So_Thue,
		deleted,
		Created,
		Created_By,
		Last_Updated,
		Last_Updated_By
	)
	VALUES
	(
		@Auto_ID,
		@Ma_Khach_Hang,
		@Ten_Khach_Hang,
		@Dia_Chi,
		@So_Dien_Thoai,
		@Email,
		@Ma_So_Thue,
		0,
		getdate(),
		@Last_Updated_By,
		getdate(),
		@Last_Updated_By
	)

	SELECT @Auto_ID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ins_Loai_Thu_Chi]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ins_Loai_Thu_Chi]
	@Ma_Loai varchar(50),
	@Ten_Loai nvarchar(250),
	@Last_Updated_By nvarchar(250)
AS
BEGIN
	

	INSERT INTO tbl_Loai_Thu_Chi
	(
	
		Ma_Loai,
		Ten_Loai,
		deleted,
		Created,
		Created_By,
		Last_Updated,
		Last_Updated_By
	)
	VALUES
	(
		
		@Ma_Loai,
		@Ten_Loai,
		0,
		getdate(),
		@Last_Updated_By,
		getdate(),
		@Last_Updated_By
	)

	
END




GO
/****** Object:  StoredProcedure [dbo].[sp_ins_Nhan_Vien]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ins_Nhan_Vien]
	@Ma_Nhan_Vien varchar(50),
	@Ten_Nhan_Vien nvarchar(250),
	@So_Dien_Thoai varchar(50),
	@Dia_Chi nvarchar(250),
	@Last_Updated_By nvarchar(250)
AS
BEGIN
	

	INSERT INTO tbl_Nhan_Vien
	(
		
		Ma_Nhan_Vien,
		Ten_Nhan_Vien,
		So_Dien_Thoai,
		Dia_Chi,
		deleted,
		Created,
		Created_By,
		Last_Updated,
		Last_Updated_By
	)
	VALUES
	(
		
		@Ma_Nhan_Vien,
		@Ten_Nhan_Vien,
		@So_Dien_Thoai,
		@Dia_Chi,
		0,
		getdate(),
		@Last_Updated_By,
		getdate(),
		@Last_Updated_By
	)

	
END




GO
/****** Object:  StoredProcedure [dbo].[sp_ins_Noi_Dung_Thu_Chi]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ins_Noi_Dung_Thu_Chi]
	@Loai_Thu_Chi_ID int,
	@Noi_Dung nvarchar(250),
	@Last_Updated_By nvarchar(250)
AS
BEGIN
	

	INSERT INTO tbl_Noi_Dung_Thu_Chi
	(
	
		Loai_Thu_Chi_ID,
		Noi_Dung,
		deleted,
		Created,
		Created_By,
		Last_Updated,
		Last_Updated_By
	)
	VALUES
	(
		
		@Loai_Thu_Chi_ID,
		@Noi_Dung,
		0,
		getdate(),
		@Last_Updated_By,
		getdate(),
		@Last_Updated_By
	)

	
END




GO
/****** Object:  StoredProcedure [dbo].[sp_ins_Tai_Khoan]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ins_Tai_Khoan]
	@Nhan_Vien_ID int,
	@Tai_Khoan nvarchar(50),
	@Mat_Khau varchar(50),
	@Last_Updated_By nvarchar(250)
AS
BEGIN
	

	INSERT INTO tbl_Tai_Khoan
	(
		
		Nhan_Vien_ID,
		Tai_Khoan,
		Mat_Khau,
		deleted,
		Created,
		Created_By,
		Last_Updated,
		Last_Updated_By
	)
	VALUES
	(
		
		@Nhan_Vien_ID,
		@Tai_Khoan,
		@Mat_Khau,
		0,
		getdate(),
		@Last_Updated_By,
		getdate(),
		@Last_Updated_By
	)

	
END




GO
/****** Object:  StoredProcedure [dbo].[sp_ins_Xe]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ins_Xe]
	@So_Xe varchar(50),
	@Ten_Xe nvarchar(250),
	@Trong_Tai nvarchar(255),
	@Last_Updated_By nvarchar(250),
	@Ghi_Chu nvarchar(250)
AS
BEGIN
	

	INSERT INTO tbl_Xe
	(
		
		So_Xe,
		Ten_Xe,
		Trong_Tai,
		Ghi_Chu,
		deleted,
		Created,
		Created_By,
		Last_Updated,
		Last_Updated_By
	)
	VALUES
	(
		
		@So_Xe,
		@Ten_Xe,
		@Trong_Tai,
		@Ghi_Chu,
		0,
		getdate(),
		@Last_Updated_By,
		getdate(),
		@Last_Updated_By
	)

	
END




GO
/****** Object:  StoredProcedure [dbo].[sp_sel_Get_Chi_Tiet_Dich_Vu_By_ID]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_sel_Get_Chi_Tiet_Dich_Vu_By_ID]
	@Auto_ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM view_Chi_Tiet_Dich_Vu
	WHERE
		Auto_ID = @Auto_ID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sel_Get_Chung_Tu_Dich_Vu_By_ID]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sel_Get_Chung_Tu_Dich_Vu_By_ID]
	@Auto_ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM view_Chung_Tu_Dich_Vu
	WHERE
		Auto_ID = @Auto_ID
END




GO
/****** Object:  StoredProcedure [dbo].[sp_sel_Get_Cong_No_Dau_Ky_Khach_Hang_By_ID]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_sel_Get_Cong_No_Dau_Ky_Khach_Hang_By_ID]
	@Auto_ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM view_Cong_No_Dau_Ky_Khach_Hang
	WHERE
		Auto_ID = @Auto_ID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sel_Get_Dich_Vu_By_ID]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sel_Get_Dich_Vu_By_ID]
	@Auto_ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM view_Dich_Vu
	WHERE
		Auto_ID = @Auto_ID
END




GO
/****** Object:  StoredProcedure [dbo].[sp_sel_Get_Dieu_Khoan_Thanh_Toan_By_ID]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sel_Get_Dieu_Khoan_Thanh_Toan_By_ID]
	@Auto_ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM view_Dieu_Khoan_Thanh_Toan
	WHERE
		Auto_ID = @Auto_ID
END




GO
/****** Object:  StoredProcedure [dbo].[sp_sel_Get_Khach_Hang_By_ID]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_sel_Get_Khach_Hang_By_ID]
	@Auto_ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM view_Khach_Hang
	WHERE
		Auto_ID = @Auto_ID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sel_Get_Loai_Thu_Chi_By_ID]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sel_Get_Loai_Thu_Chi_By_ID]
	@Auto_ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM view_Loai_Thu_Chi
	WHERE
		Auto_ID = @Auto_ID
END




GO
/****** Object:  StoredProcedure [dbo].[sp_sel_Get_Nhan_Vien_By_ID]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sel_Get_Nhan_Vien_By_ID]
	@Auto_ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM view_Nhan_Vien
	WHERE
		Auto_ID = @Auto_ID
END




GO
/****** Object:  StoredProcedure [dbo].[sp_sel_Get_Noi_Dung_Thu_Chi_By_ID]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sel_Get_Noi_Dung_Thu_Chi_By_ID]
	@Auto_ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM view_Noi_Dung_Thu_Chi
	WHERE
		Auto_ID = @Auto_ID
END




GO
/****** Object:  StoredProcedure [dbo].[sp_sel_Get_Tai_Khoan_By_ID]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sel_Get_Tai_Khoan_By_ID]
	@Auto_ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM view_Tai_Khoan
	WHERE
		Auto_ID = @Auto_ID
END




GO
/****** Object:  StoredProcedure [dbo].[sp_sel_Get_Xe_By_ID]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sel_Get_Xe_By_ID]
	@Auto_ID int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM view_Xe
	WHERE
		Auto_ID = @Auto_ID
END




GO
/****** Object:  StoredProcedure [dbo].[sp_sel_List_Chi_Tiet_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_sel_List_Chi_Tiet_Dich_Vu]
AS
BEGIN
	SELECT * FROM view_Chi_Tiet_Dich_Vu
	ORDER BY Auto_ID DESC
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sel_List_Chung_Tu_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sel_List_Chung_Tu_Dich_Vu]
AS
BEGIN
	SELECT * FROM view_Chung_Tu_Dich_Vu
	ORDER BY Auto_ID DESC
END




GO
/****** Object:  StoredProcedure [dbo].[sp_sel_List_Cong_No_Dau_Ky_Khach_Hang]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_sel_List_Cong_No_Dau_Ky_Khach_Hang]
AS
BEGIN
	SELECT * FROM view_Cong_No_Dau_Ky_Khach_Hang
	ORDER BY Auto_ID DESC
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sel_List_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sel_List_Dich_Vu]
AS
BEGIN
	SELECT * FROM view_Dich_Vu
	ORDER BY Auto_ID DESC
END




GO
/****** Object:  StoredProcedure [dbo].[sp_sel_List_Dieu_Khoan_Thanh_Toan]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sel_List_Dieu_Khoan_Thanh_Toan]
AS
BEGIN
	SELECT * FROM view_Dieu_Khoan_Thanh_Toan
	ORDER BY Auto_ID DESC
END




GO
/****** Object:  StoredProcedure [dbo].[sp_sel_List_Khach_Hang]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_sel_List_Khach_Hang]
AS
BEGIN
	SELECT * FROM view_Khach_Hang
	ORDER BY Auto_ID DESC
END

GO
/****** Object:  StoredProcedure [dbo].[sp_sel_List_Loai_Thu_Chi]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sel_List_Loai_Thu_Chi]
AS
BEGIN
	SELECT * FROM view_Loai_Thu_Chi
	ORDER BY Auto_ID DESC
END




GO
/****** Object:  StoredProcedure [dbo].[sp_sel_List_Nhan_Vien]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sel_List_Nhan_Vien]
AS
BEGIN
	SELECT * FROM view_Nhan_Vien
	ORDER BY Auto_ID DESC
END




GO
/****** Object:  StoredProcedure [dbo].[sp_sel_List_Noi_Dung_Thu_Chi]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sel_List_Noi_Dung_Thu_Chi]
AS
BEGIN
	SELECT * FROM view_Noi_Dung_Thu_Chi
	ORDER BY Auto_ID DESC
END




GO
/****** Object:  StoredProcedure [dbo].[sp_sel_List_Tai_Khoan]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sel_List_Tai_Khoan]
AS
BEGIN
	SELECT * FROM view_Tai_Khoan
	ORDER BY Auto_ID DESC
END




GO
/****** Object:  StoredProcedure [dbo].[sp_sel_List_Xe]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_sel_List_Xe]
AS
BEGIN
	SELECT * FROM view_Xe
	ORDER BY Auto_ID DESC
END




GO
/****** Object:  StoredProcedure [dbo].[sp_upd_Chi_Tiet_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_upd_Chi_Tiet_Dich_Vu]
	@Auto_ID bigint,
	@Chung_Tu_ID bigint,
	@Dich_Vu_ID int,
	@Xe_ID int,
	@So_Luong decimal,
	@Don_Gia decimal,
	@Thanh_Tien decimal,
	@Dia_Chi_Lay nvarchar(500),
	@Dia_Chi_Do nvarchar(500),
	@Last_Updated_By nvarchar(250)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Chi_Tiet_Dich_Vu SET
		Chung_Tu_ID = @Chung_Tu_ID,
		Dich_Vu_ID = @Dich_Vu_ID,
		Xe_ID = @Xe_ID,
		So_Luong = @So_Luong,
		Don_Gia = @Don_Gia,
		Thanh_Tien = @Thanh_Tien,
		Dia_Chi_Lay = @Dia_Chi_Lay,
		Dia_Chi_Do = @Dia_Chi_Do,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END




GO
/****** Object:  StoredProcedure [dbo].[sp_upd_Chung_Tu_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_upd_Chung_Tu_Dich_Vu]
	@Auto_ID bigint,
	@Khach_Hang_ID int,
	@Nhan_Vien_ID int,
	@Dien_Giai nvarchar(250),
	@TongTien decimal,
	@Last_Updated_By nvarchar(250)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Chung_Tu_Dich_Vu SET
		Khach_Hang_ID = @Khach_Hang_ID,
		Nhan_Vien_ID = @Nhan_Vien_ID,
		Dien_Giai = @Dien_Giai,
		TongTien = @TongTien,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END




GO
/****** Object:  StoredProcedure [dbo].[sp_upd_Cong_No_Dau_Ky_Khach_Hang]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_upd_Cong_No_Dau_Ky_Khach_Hang]
	@Auto_ID int,
	@KhachHang_ID int,
	@Tien_No decimal,
	@Dien_Giai nvarchar(255),
	@Last_Updated_By nvarchar(255)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Cong_No_Dau_Ky_Khach_Hang SET
		KhachHang_ID = @KhachHang_ID,
		Tien_No = @Tien_No,
		Dien_Giai = @Dien_Giai,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_upd_Dich_Vu]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_upd_Dich_Vu]
	@Auto_ID int,
	@Ma_Dich_Vu varchar(50),
	@Ten_Dich_Vu nvarchar(255),
	@Dien_Giai nvarchar(255),
	@Last_Updated_By nvarchar(250)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Dich_Vu SET
		Ma_Dich_Vu = @Ma_Dich_Vu,
		Ten_Dich_Vu = @Ten_Dich_Vu,
		Dien_Giai = @Dien_Giai,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END




GO
/****** Object:  StoredProcedure [dbo].[sp_upd_Dieu_Khoan_Thanh_Toan]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_upd_Dieu_Khoan_Thanh_Toan]
	@Auto_ID int,
	@TenDieuKhoan nvarchar(250),
	@Last_Updated_By nvarchar(250)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Dieu_Khoan_Thanh_Toan SET
		TenDieuKhoan = @TenDieuKhoan,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END




GO
/****** Object:  StoredProcedure [dbo].[sp_upd_Khach_Hang]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_upd_Khach_Hang]
	@Auto_ID int,
	@Ma_Khach_Hang varchar(50),
	@Ten_Khach_Hang nvarchar(250),
	@Dia_Chi nvarchar(250),
	@So_Dien_Thoai varchar(20),
	@Email varchar(50),
	@Last_Updated_By nvarchar(250),
	@Ma_So_Thue varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Khach_Hang SET
		Ma_Khach_Hang = @Ma_Khach_Hang,
		Ten_Khach_Hang = @Ten_Khach_Hang,
		Dia_Chi = @Dia_Chi,
		So_Dien_Thoai = @So_Dien_Thoai,
		Email = @Email,
		Ma_So_Thue = @Ma_So_Thue,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_upd_Loai_Thu_Chi]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_upd_Loai_Thu_Chi]
	@Auto_ID int,
	@Ma_Loai varchar(50),
	@Ten_Loai nvarchar(250),
	@Last_Updated_By nvarchar(250)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Loai_Thu_Chi SET
		Ma_Loai = @Ma_Loai,
		Ten_Loai = @Ten_Loai,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END




GO
/****** Object:  StoredProcedure [dbo].[sp_upd_Nhan_Vien]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_upd_Nhan_Vien]
	@Auto_ID int,
	@Ma_Nhan_Vien varchar(50),
	@Ten_Nhan_Vien nvarchar(250),
	@So_Dien_Thoai varchar(50),
	@Dia_Chi nvarchar(250),
	@Last_Updated_By nvarchar(250)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Nhan_Vien SET
		Ma_Nhan_Vien = @Ma_Nhan_Vien,
		Ten_Nhan_Vien = @Ten_Nhan_Vien,
		So_Dien_Thoai = @So_Dien_Thoai,
		Dia_Chi = @Dia_Chi,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END




GO
/****** Object:  StoredProcedure [dbo].[sp_upd_Noi_Dung_Thu_Chi]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_upd_Noi_Dung_Thu_Chi]
	@Auto_ID int,
	@Loai_Thu_Chi_ID int,
	@Noi_Dung nvarchar(250),
	@Last_Updated_By nvarchar(250)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Noi_Dung_Thu_Chi SET
		Loai_Thu_Chi_ID = @Loai_Thu_Chi_ID,
		Noi_Dung = @Noi_Dung,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END




GO
/****** Object:  StoredProcedure [dbo].[sp_upd_Tai_Khoan]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_upd_Tai_Khoan]
	@Auto_ID int,
	@Nhan_Vien_ID int,
	@Tai_Khoan nvarchar(50),
	@Mat_Khau varchar(50),
	@Last_Updated_By nvarchar(250)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Tai_Khoan SET
		Nhan_Vien_ID = @Nhan_Vien_ID,
		Tai_Khoan = @Tai_Khoan,
		Mat_Khau = @Mat_Khau,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END




GO
/****** Object:  StoredProcedure [dbo].[sp_upd_Xe]    Script Date: 09/08/2017 6:24:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_upd_Xe]
	@Auto_ID int,
	@So_Xe varchar(50),
	@Ten_Xe nvarchar(250),
	@Trong_Tai nvarchar(255),
	@Last_Updated_By nvarchar(250),
	@Ghi_Chu nvarchar(250)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE tbl_Xe SET
		So_Xe = @So_Xe,
		Ten_Xe = @Ten_Xe,
		Trong_Tai = @Trong_Tai,
		Ghi_Chu = @Ghi_Chu,
		Last_Updated = getdate(),
		Last_Updated_By = @Last_Updated_By
	WHERE
		Auto_ID = @Auto_ID
END




GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "A"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 215
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "B"
            Begin Extent = 
               Top = 6
               Left = 253
               Bottom = 136
               Right = 431
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_Noi_Dung_Thu_Chi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_Noi_Dung_Thu_Chi'
GO
