create database QLST
go
use QLST
GO
CREATE FUNCTION dbo.GenerateMaNV()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NextID INT;
    DECLARE @NewMaNV VARCHAR(10);

    -- Tìm số thứ tự tiếp theo
    SELECT @NextID = COALESCE(MAX(CAST(RIGHT(MaNV, 3) AS INT)), 1) + 1 FROM NhanVien;

    -- Tạo mã mới
    SET @NewMaNV = 'NV' + RIGHT('000' + CAST(@NextID AS VARCHAR(3)), 3);

    RETURN @NewMaNV;
END;
GO
CREATE FUNCTION dbo.GenerateMaKH()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NextID INT;
    DECLARE @NewMaKH VARCHAR(10);

    -- Tìm số thứ tự tiếp theo
    SELECT @NextID = COALESCE(MAX(CAST(RIGHT(MaKH, 5) AS INT)), 1) + 1 FROM KhachHang;

    -- Tạo mã mới
    SET @NewMaKH = RIGHT('00000' + CAST(@NextID AS VARCHAR(5)), 5);

    RETURN @NewMaKH;
END;
GO

CREATE FUNCTION dbo.GenerateMaNCC()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NextID INT;
    DECLARE @NewMaNCC VARCHAR(10);

    -- Tìm số thứ tự tiếp theo
    SELECT @NextID = COALESCE(MAX(CAST(RIGHT(MaNCC, 3) AS INT)), 1) + 1 FROM NhaCungCap;

    -- Tạo mã mới
    SET @NewMaNCC = 'NCC' + RIGHT('000' + CAST(@NextID AS VARCHAR(3)), 3);

    RETURN @NewMaNCC;
END;
GO

CREATE FUNCTION dbo.GenerateMaLSP()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NextID INT;
    DECLARE @NewMaLSP VARCHAR(10);

    -- Tìm số thứ tự tiếp theo
    SELECT @NextID = COALESCE(MAX(CAST(RIGHT(MaLoaiSP, 3) AS INT)), 1) + 1 FROM LoaiSanPham;

    -- Tạo mã mới
    SET @NewMaLSP = 'LSP' + RIGHT('000' + CAST(@NextID AS VARCHAR(3)), 3);

    RETURN @NewMaLSP;
END;
GO

CREATE FUNCTION dbo.GenerateMaSP()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NextID INT;
    DECLARE @NewMaSP VARCHAR(10);

    -- Tìm số thứ tự tiếp theo
    SELECT @NextID = COALESCE(MAX(CAST(RIGHT(MaSP, 3) AS INT)), 1) + 1 FROM SanPham;

    -- Tạo mã mới
    SET @NewMaSP = 'SP' + RIGHT('000' + CAST(@NextID AS VARCHAR(3)), 3);

    RETURN @NewMaSP;
END;
GO

CREATE FUNCTION dbo.GenerateMaHD()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NextID INT;
    DECLARE @NewMaHD VARCHAR(10);

    -- Tìm số thứ tự tiếp theo
    SELECT @NextID = COALESCE(MAX(CAST(RIGHT(MaHD, 3) AS INT)), 1) + 1 FROM HoaDonBanHang;

    -- Tạo mã mới
    SET @NewMaHD = 'HD' + RIGHT('000' + CAST(@NextID AS VARCHAR(3)), 3);

    RETURN @NewMaHD;
END;
GO

CREATE FUNCTION dbo.GenerateMaNK()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NextID INT;
    DECLARE @NewMaNK VARCHAR(10);

    -- Tìm số thứ tự tiếp theo
    SELECT @NextID = COALESCE(MAX(CAST(RIGHT(MaNK, 3) AS INT)), 1) + 1 FROM HoaDonNhapKho;

    -- Tạo mã mới
    SET @NewMaNK = 'NK' + RIGHT('000' + CAST(@NextID AS VARCHAR(3)), 3);

    RETURN @NewMaNK;
END;

GO

CREATE TABLE QuanLyLoi
(
	STT int identity(1,1),
	TenLoi varchar(255),
	ViTriLoi varchar(255),
	ThoiGian datetime,
	TrangThai bit

	constraint PK_STT primary key(STT)
)


create table ChucVu
(
	MaChucVu varchar(5),
	TenChucVu nvarchar(50),
	TrangThai bit

	constraint PK_ChucVu primary key (MaChucVu)
)

---======EMPLOYEE
create table NhanVien
(
	MaNV varchar(10) not null constraint DF_TK_MANV default dbo.GenerateMaNV(),
	CCCD varchar(12),
	HoTen nvarchar(255),
	GioiTinh nvarchar(3),
	DiaChi nvarchar(255),
	SDT varchar(12),
	NgayTao date,
	MaChucVu varchar(5),
	TrangThai bit
	
	constraint PK_NV primary key(MaNV),
	constraint FK_NV_CV foreign key(MaChucVu) references ChucVu(MaChucVu)
)

create table TaiKhoan
(
	MaNV varchar(10) not null,
	MatKhau varchar(255),
	MaChucVu varchar(5) default 'NV',
	TrangThai bit

	constraint PK_TK primary key(MaNV),
	constraint FK_TK_NV foreign key(MaNV) references NhanVien(MaNV),
	constraint FK_TK_CV foreign key(MaChucVu) references ChucVu(MaChucVu)
)

--=====CUSTOMER

create table KhachHang
(
	MaKH varchar(10) not null CONSTRAINT DF_KH_MAKH DEFAULT dbo.GenerateMaKH(),
	HoTen nvarchar(255),
	CCCD varchar(12),
	SDT varchar(10),
	GioiTinh nvarchar(3),
	DiaChi nvarchar(255),
	NgayDangKy date,
	TrangThai bit

	constraint PK_KH primary key(MaKH)
)
--===SUPPLIER
create table NhaCungCap
(
	MaNCC varchar(20) not null CONSTRAINT DF_NCC_MANCC 
								DEFAULT dbo.GenerateMaNCC(),
	
	TenNCC nvarchar(255),
	SDT varchar(12),
	DiaChi nvarchar(255),
	TrangThai bit,

	constraint PK_NCC primary key(MaNCC)
)

--==TYPE PRODUCT
create table LoaiSanPham
(
	MaLoaiSP varchar(10) not null constraint DF_LSP_MaLoaiSP default dbo.GenerateMaLSP(),
	TenLoai nvarchar(100),
	MoTa nvarchar(255)

	constraint PK_LoaiSP primary key(MaLoaiSP)
)

--==== PRODUCT

create table SanPham
(
	MaSP varchar(20) not null constraint DF_SP_MaSP default dbo.GenerateMaSP(),
	TenSP nvarchar(50),
	MaNCC varchar(20) not null,
	MaLoaiSP varchar(10),
	GiaNhap decimal,
	GiaBan decimal,
	SoLuong int,
	HanSuDung varchar(5),
	DonViTinh nvarchar(20),
	HinhAnh varchar(255),
	TrangThai bit,

	constraint PK_SP primary key(MaSP),
	constraint FK_SP_NCC foreign key(MaNCC) references NhaCungCap(MaNCC),
	constraint FK_SP_LoaiSP foreign key(MaLoaiSP) references LoaiSanPham(MaLoaiSP)
)
create table KhuyenMai
(
	MaKM varchar(10),
	TenKM nvarchar(255),
	GiaKhuyenMai float,
	NgayBatDau date,
	NgayKetThuc date

	constraint PK_KM primary key(MaKM)
)

--HD
create table HoaDonBanHang
(
	MaHD varchar(10) not null constraint DF_HDBanHang_MaHD default dbo.GenerateMaHD(),
	MaNV varchar(10) not null,
	MaKH varchar(10),
	NgayLapHD datetime,
	TongTien decimal(18,0),
	TienKhachDua decimal(18,0),
	TienTraKhach decimal(18,0)

	constraint PK_HDBH primary key(MaHD),
	constraint FK_HDBH_NV foreign key(MaNV) references NhanVien(MaNV),
	constraint FK_HDBH_KH foreign key(MaKH) references KhachHang(MaKH)
)

create table ChiTietHoaDonBanHang
(
	MaHD varchar(10) not null,
	MaSP varchar(20) not null,
	MaKM  varchar(10),
	SoLuong int,
	DonGia decimal(18,0),
	ThanhTien decimal(18,0),

	constraint PK_CTHDBH primary key (MaHD,MaSP),
	constraint FK_CTHDBH_HD foreign key(MaHD) references HoaDonBanHang(MaHD),
	constraint FK_CTHDBH_SP foreign key(MaSP) references SanPham(MaSP),
	constraint FK_CTHDBH_KM foreign key(MaKM) references KhuyenMai(MaKM)
)

create table HoaDonNhapKho
(
	MaNK varchar(20) not null constraint DF_HDNhapKho_MaNK default dbo.GenerateMaNK(),
	MaNV varchar(10) not null,
	MaNCC varchar(20) not null,
	NgayNhapKho datetime,
	TongTien decimal(18,0)

	constraint PK_HDNK primary key (MaNK),
	constraint FK_HDNK_NV foreign key (MaNV) references NhanVien(MaNV),
	constraint FK_HDNK_NCC foreign key (MaNCC) references NhaCungCap(MaNCC)
)

create table ChiTietHoaDonNhapKho
(
	MaNK varchar(20) not null,
	MaSP  varchar(20) not null,
	HanSuDung date,
	SoLuong int,
	SoLuongDaBan int DEFAULT 0,
	DonGiaNhap decimal(18,0),
	ThanhTien decimal(18,0)

	constraint PK_CTHDNK primary key (MaNK, MaSP),
	constraint FK_CTHDNK_SP foreign key(MaSP) references SanPham(MaSP)
)

CREATE TABLE QuanLyLoi
(
	
)
