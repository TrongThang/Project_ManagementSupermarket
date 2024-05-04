use QLST
go
------------------------------------------- GET AND SEARCH  -------------------------------------------
--REVENUE
ALTER PROC sp_GetRevenue
(
	@Ngay date,
	@TieuChi nvarchar(5)
)
as
BEGIN
declare @sellMoney money = 0;
declare @importMoney money = 0;
declare @Count_InvoiceSelling int = 0, @Count_InvoiceWarehouse int = 0, @Count_ProductSelling int = 0,  @Count_ProductImport int = 0, @Count_Discount int = 0, @Count_Supplier int = 0,	@Count_Employee int = 0
	IF @TieuChi = N'Ngày'
		BEGIN
			
			SELECT @Count_InvoiceSelling = COUNT(MaHD), @sellMoney = SUM(TongTien) FROM HoaDonBanHang WHERE NgayLapHD = @Ngay

			SELECT @Count_InvoiceWarehouse = COUNT(MaNK), @importMoney = SUM(TongTien)  FROM HoaDonNhapKho WHERE NgayNhapKho = @Ngay

			SELECT @Count_ProductSelling = COUNT(MaSP) FROM ChiTietHoaDonBanHang CT JOIN HoaDonBanHang HD ON  HD.MaHD = CT.MaHD WHERE NgayLapHD = @Ngay
			SELECT @Count_ProductImport = COUNT(MaSP) FROM ChiTietHoaDonNhapKho CT JOIN HoaDonNhapKho NK ON  NK.MaNK = CT.MaNK WHERE NgayNhapKho = @Ngay
			
			SELECT @Count_Discount = COUNT(MaKM) FROM KhuyenMai WHERE @Ngay BETWEEN NgayBatDau AND NgayKetThuc

			SELECT DISTINCT @Count_Supplier = COUNT(MaNCC) FROM HoaDonNhapKho WHERE NgayNhapKho = @Ngay

			SELECT DISTINCT  @Count_Employee = COUNT(MaNV) FROM HoaDonBanHang WHERE NgayLapHD = @Ngay

			SELECT @sellMoney - @importMoney as DoanhThu, @Count_InvoiceSelling as SLHD_Ban, @Count_InvoiceWarehouse as SLHD_Nhap, @Count_ProductSelling as SLSP_Ban,  @Count_ProductImport as SLSP_Nhap, @Count_Discount as SLKM, @Count_Supplier as SLNCC,	@Count_Employee as SLNV;
		END
	ELSE IF @TieuChi = N'Tuần'
		BEGIN
			--Level: Hard -- Don't
			SELECT 
				COALESCE(SUM(HD.TongTien), 0) - COALESCE(SUM(NK.TongTien), 0) as DoanhThu,
				COUNT(DISTINCT HD.MaHD) AS SLHD_Ban,
				COUNT(DISTINCT NK.MaNK) AS SLHD_Nhap,
				COALESCE(SUM(CTHD.SoLuong), 0) AS SLSP_Ban,
				COALESCE(SUM(CTNK.SoLuong), 0) AS SLSP_Nhap,
				COUNT(DISTINCT KM.MaKM) AS SLKM,
				COUNT(DISTINCT NK.MaNCC) AS SLNCC,
				COUNT(DISTINCT HD.MaNV) AS SLNV
			FROM
				HoaDonBanHang HD
			LEFT JOIN
				ChiTietHoaDonBanHang CTHD ON HD.MaHD = CTHD.MaHD
			LEFT JOIN
				HoaDonNhapKho NK ON DATEPART(WW, NK.NgayNhapKho) = DATEPART(WW, @Ngay)
			LEFT JOIN
				ChiTietHoaDonNhapKho CTNK ON NK.MaNK = CTNK.MaNK
			LEFT JOIN
				KhuyenMai KM ON DATEPART(WW, @Ngay) BETWEEN DATEPART(WW, KM.NgayBatDau) AND DATEPART(WW, KM.NgayKetThuc)
			WHERE
				DATEPART(WW, @Ngay) = DATEPART(WW, NgayLapHD) AND YEAR(HD.NgayLapHD) = YEAR(@Ngay)
		END
	ELSE IF @TieuChi = N'QUÝ'
		BEGIN
			SELECT 
				COALESCE(SUM(HD.TongTien), 0) - COALESCE(SUM(NK.TongTien), 0) as DoanhThu,
				COUNT(DISTINCT HD.MaHD) AS SLHD_Ban,
				COUNT(DISTINCT NK.MaNK) AS SLHD_Nhap,
				COALESCE(SUM(CTHD.SoLuong), 0) AS SLSP_Ban,
				COALESCE(SUM(CTNK.SoLuong), 0) AS SLSP_Nhap,
				COUNT(DISTINCT KM.MaKM) AS SLKM,
				COUNT(DISTINCT NK.MaNCC) AS SLNCC,
				COUNT(DISTINCT HD.MaNV) AS SLNV
			FROM
				HoaDonBanHang HD
			LEFT JOIN
				ChiTietHoaDonBanHang CTHD ON HD.MaHD = CTHD.MaHD
			LEFT JOIN
				HoaDonNhapKho NK ON DATEPART(qq, NK.NgayNhapKho) = DATEPART(qq, @Ngay)
			LEFT JOIN
				ChiTietHoaDonNhapKho CTNK ON NK.MaNK = CTNK.MaNK
			LEFT JOIN
				KhuyenMai KM ON DATEPART(qq, @Ngay) BETWEEN DATEPART(qq, KM.NgayBatDau) AND DATEPART(qq, KM.NgayKetThuc)
			WHERE
				DATEPART(qq, @Ngay) = DATEPART(qq, NgayLapHD) AND YEAR(HD.NgayLapHD) = YEAR(@Ngay)
		END
	ELSE IF @TieuChi = N'Tháng'
		BEGIN
			SELECT 
				COALESCE(SUM(HD.TongTien), 0) - COALESCE(SUM(NK.TongTien), 0) as DoanhThu,
				COUNT(DISTINCT HD.MaHD) AS SLHD_Ban,
				COUNT(DISTINCT NK.MaNK) AS SLHD_Nhap,
				COALESCE(SUM(CTHD.SoLuong), 0) AS SLSP_Ban,
				COALESCE(SUM(CTNK.SoLuong), 0) AS SLSP_Nhap,
				COUNT(DISTINCT KM.MaKM) AS SLKM,
				COUNT(DISTINCT NK.MaNCC) AS SLNCC,
				COUNT(DISTINCT HD.MaNV) AS SLNV
			FROM
				HoaDonBanHang HD
			LEFT JOIN
				ChiTietHoaDonBanHang CTHD ON HD.MaHD = CTHD.MaHD
			LEFT JOIN
				HoaDonNhapKho NK ON MONTH(NK.NgayNhapKho) = MONTH(@Ngay)
			LEFT JOIN
				ChiTietHoaDonNhapKho CTNK ON NK.MaNK = CTNK.MaNK
			LEFT JOIN
				KhuyenMai KM ON MONTH(@Ngay) BETWEEN MONTH(KM.NgayBatDau) AND MONTH(KM.NgayKetThuc)
			WHERE
				MONTH(HD.NgayLapHD) = MONTH(@Ngay) AND YEAR(HD.NgayLapHD) = YEAR(@Ngay)
		END
	ELSE IF @TieuChi = N'Năm'
		BEGIN
			SELECT 
				COALESCE(SUM(HD.TongTien), 0) - COALESCE(SUM(NK.TongTien), 0) as DoanhThu,
				COUNT(DISTINCT HD.MaHD) AS SLHD_Ban,
				COUNT(DISTINCT NK.MaNK) AS SLHD_Nhap,
				COALESCE(SUM(CTHD.SoLuong), 0) AS SLSP_Ban,
				COALESCE(SUM(CTNK.SoLuong), 0) AS SLSP_Nhap,
				COUNT(DISTINCT KM.MaKM) AS SLKM,
				COUNT(DISTINCT NK.MaNCC) AS SLNCC,
				COUNT(DISTINCT HD.MaNV) AS SLNV
			FROM
				HoaDonBanHang HD
			LEFT JOIN
				ChiTietHoaDonBanHang CTHD ON HD.MaHD = CTHD.MaHD
			LEFT JOIN
				HoaDonNhapKho NK ON YEAR(NK.NgayNhapKho) = YEAR(@Ngay)
			LEFT JOIN
				ChiTietHoaDonNhapKho CTNK ON NK.MaNK = CTNK.MaNK
			LEFT JOIN
				KhuyenMai KM ON YEAR(@Ngay) BETWEEN YEAR(KM.NgayBatDau) AND YEAR(KM.NgayKetThuc)
			WHERE
				YEAR(HD.NgayLapHD) = YEAR(@Ngay)
		END
END
GO
--Account
CREATE PROC sp_checkAccount
(
	@MaNV varchar(255),
	@MatKhau varchar(255)
)
as
begin
	SELECT COUNT(MatKhau), MaChucVu
	FROM TaiKhoan
	WHERE MaNV = @MaNV AND MatKhau =  @MatKhau
	GROUP BY MaChucVu
end
GO

--Role
CREATE PROC sp_getRole
(
	@MaChucVu varchar(5) = null, 
	@TenChucVu nvarchar(255) = null
)
as
begin
	SELECT MaChucVu, TenChucVu, TrangThai
	FROM ChucVu
	WHERE (MaChucVu LIKE '%' + ISNULL(@MaChucVu, '') + '%')
		AND (TenChucVu LIKE '%' + ISNULL(@TenChucVu, '') + '%')
end
GO
--Employee
ALTER PROC sp_getEmployeeTo
(
	@MaNV varchar(10) = null,
	@CCCD varchar(12) = null,
	@HoTen nvarchar(255) = null,
	@GioiTinh nvarchar(3) = null,
	@DiaChi nvarchar(255) = null,
	@SDT varchar(12) = null,
	@NgayTao datetime = null,
	@MaChucVu varchar(5) = null,
	@TrangThai bit = null
)
as
begin 
	IF @TrangThai is null
	BEGIN
		SELECT MaNV, CCCD, HoTen, GioiTinh, DiaChi, SDT, NgayTao, MaChucVu, Luong, TrangThai
		FROM NhanVien
		WHERE (MaNV LIKE '%' + ISNULL(@MaNV, '') + '%')
			AND (HoTen LIKE '%' + ISNULL(@HoTen, '') + '%')
			AND (CCCD LIKE '%' + ISNULL(@CCCD, '') + '%')
			AND (GioiTinh LIKE '%' + ISNULL(@GioiTinh, '') + '%')
			AND (DiaChi LIKE '%' + ISNULL(@DiaChi, '') + '%')
			AND (SDT LIKE '%' + ISNULL(@SDT, '') + '%')
			AND (NgayTao = ISNULL(@NgayTao, NgayTao))
			AND (MaChucVu LIKE '%' + ISNULL(@MaChucVu, '') + '%')
	END
	ELSE
	BEGIN
		SELECT MaNV, CCCD, HoTen, GioiTinh, DiaChi, SDT, NgayTao, MaChucVu, Luong, TrangThai
		FROM NhanVien
		WHERE (MaNV LIKE '%' + ISNULL(@MaNV, '') + '%')
			AND (HoTen LIKE '%' + ISNULL(@HoTen, '') + '%')
			AND (CCCD LIKE '%' + ISNULL(@CCCD, '') + '%')
			AND (GioiTinh LIKE '%' + ISNULL(@GioiTinh, '') + '%')
			AND (DiaChi LIKE '%' + ISNULL(@DiaChi, '') + '%')
			AND (SDT LIKE '%' + ISNULL(@SDT, '') + '%')
			AND (NgayTao = ISNULL(@NgayTao, NgayTao))
			AND (MaChucVu LIKE '%' + ISNULL(@MaChucVu, '') + '%')
			And (TrangThai = @TrangThai)
	END
end
GO
--Customer
create proc sp_getCustomerTo
(
	@MaKH varchar(10) = null,
	@HoTen nvarchar(255) = null,
	@CCCD varchar(12) = null,
	@SDT varchar(12) = null,
	@GioiTinh nvarchar(3) = null,
	@DiaChi nvarchar(255) = null,
	@NgayDangKy datetime = null,
	@TrangThai bit = null
)
as
begin
	IF @TrangThai is null
	BEGIN
		SELECT MaKH, HoTen, CCCD, SDT, GioiTinh, DiaChi, NgayDangKy, TrangThai
		FROM KhachHang
		WHERE (MaKH LIKE '%' + ISNULL(@MaKH, '') + '%')
		AND (HoTen LIKE '%' + ISNULL(@HoTen, '') + '%')
		AND (CCCD LIKE '%' + ISNULL(@CCCD, '') + '%')
		AND (GioiTinh LIKE '%' + ISNULL(@GioiTinh, '') + '%')
		AND (DiaChi LIKE '%' + ISNULL(@DiaChi, '') + '%')
		AND (SDT LIKE '%' + ISNULL(@SDT, '') + '%')
		AND (NgayDangKy = ISNULL(@NgayDangKy, NgayDangKy))
	END
	ELSE
	BEGIN
		SELECT MaKH, HoTen, CCCD, SDT, GioiTinh, DiaChi, NgayDangKy, TrangThai
		FROM KhachHang
		WHERE (MaKH LIKE '%' + ISNULL(@MaKH, '') + '%')
		AND (HoTen LIKE '%' + ISNULL(@HoTen, '') + '%')
		AND (CCCD LIKE '%' + ISNULL(@CCCD, '') + '%')
		AND (GioiTinh LIKE '%' + ISNULL(@GioiTinh, '') + '%')
		AND (DiaChi LIKE '%' + ISNULL(@DiaChi, '') + '%')
		AND (SDT LIKE '%' + ISNULL(@SDT, '') + '%')
		AND (NgayDangKy = ISNULL(@NgayDangKy, NgayDangKy))
		And (TrangThai = @TrangThai)
	END
	
	
end
go

--Supplier
CREATE PROC sp_getSupplier
(
	@MaNCC varchar(20) = null,
	@TenNCC nvarchar(255) = null,
	@SDT varchar(12) = null,
	@DiaChi nvarchar(255) = null,
	@TrangThai bit = -1
)
as
begin
	IF @TrangThai < 0
		SELECT MaNCC, TenNCC, SDT, DiaChi, TrangThai
		FROM NhaCungCap
		WHERE (MaNCC LIKE '%' + ISNULL(@MaNCC, '') + '%')
			AND (TenNCC LIKE '%' + ISNULL(@TenNCC, '') + '%')
			AND (SDT LIKE '%' + ISNULL(@SDT, '') + '%')
			AND (DiaChi LIKE '%' + ISNULL(@DiaChi, '') + '%')
			AND (TrangThai = @TrangThai)
	ELSE
		SELECT MaNCC, TenNCC, SDT, DiaChi, TrangThai
		FROM NhaCungCap
		WHERE (MaNCC LIKE '%' + ISNULL(@MaNCC, '') + '%')
			AND (TenNCC LIKE '%' + ISNULL(@TenNCC, '') + '%')
			AND (SDT LIKE '%' + ISNULL(@SDT, '') + '%')
			AND (DiaChi LIKE '%' + ISNULL(@DiaChi, '') + '%')
			AND (TrangThai = @TrangThai) 
end
GO
--TypeProduct
CREATE PROC sp_getTypeProduct
(
	@MaLoaiSP varchar(10) = null,
	@TenLoai nvarchar(100) = null,
	@MoTa nvarchar(255) = null
)
as
begin
	SELECT MaLoaiSP, TenLoai, MoTa
	FROM LoaiSanPham
	WHERE (MaLoaiSP LIKE '%' + ISNULL(@MaLoaiSP, '') + '%')
		AND (TenLoai LIKE '%' + ISNULL(@TenLoai, '') + '%')
		AND (MoTa LIKE '%' + ISNULL(@MoTa, '') + '%')
end
GO
--Product
CREATE PROC sp_getProduct
(
	@MaSP varchar(20) = null,
	@TenSP nvarchar(50) = null,
	@TenNCC varchar(10) = null,
	@TenLoai varchar(10) = null,
	@DonViTinh nvarchar(20) = null,
	@TrangThai bit = null
)
as
begin
	IF @TrangThai is null
		BEGIN
			SELECT MaSP, HinhAnh, TenSP, TenNCC, TenLoai, GiaNhap, GiaBan, SoLuong, HanSuDung, DonViTinh, SanPham.TrangThai
			FROM SanPham
			JOIN LoaiSanPham lsp ON lsp.MaLoaiSP = SanPham.MaLoaiSP
			JOIN NhaCungCap ON NhaCungCap.MaNCC = SanPham.MaNCC
			WHERE (MaSP LIKE '%' + ISNULL(@MaSP, '') + '%')
				AND (TenSP LIKE '%' + ISNULL(@TenSP, '') + '%')
				AND (TenNCC LIKE '%' + ISNULL(@TenNCC, '') + '%')
				AND (lsp.TenLoai LIKE '%' + ISNULL(@TenLoai, '') + '%')
				AND (DonViTinh LIKE '%' + ISNULL(@DonViTinh, '') + '%')
		END
	ELSE
		BEGIN
			SELECT MaSP, HinhAnh, TenSP, TenNCC, TenLoai, GiaNhap, GiaBan, SoLuong, HanSuDung, DonViTinh, SanPham.TrangThai
			FROM SanPham
			JOIN LoaiSanPham lsp ON lsp.MaLoaiSP = SanPham.MaLoaiSP
			JOIN NhaCungCap ON NhaCungCap.MaNCC = SanPham.MaNCC
			WHERE (MaSP LIKE '%' + ISNULL(@MaSP, '') + '%')
				AND (TenSP LIKE '%' + ISNULL(@TenSP, '') + '%')
				AND (TenNCC LIKE '%' + ISNULL(@TenNCC, '') + '%')
				AND (lsp.TenLoai LIKE '%' + ISNULL(@TenLoai, '') + '%')
				AND (DonViTinh LIKE '%' + ISNULL(@DonViTinh, '') + '%')
				AND (SanPham.TrangThai = @TrangThai)
		END
end
GO

--Discount
CREATE PROC sp_getDiscountToDay
as
begin
	SELECT MaKM, TenKM, GiaKhuyenMai, NgayBatDau, NgayKetThuc
	FROM KhuyenMai
	WHERE GETDATE() BETWEEN  NgayBatDau AND NgayKetThuc
end
GO

CREATE PROC sp_getDiscount
(
	@MaKM varchar(10) = null,
	@TenKM varchar(255) = null,
	@NgayBatDat date = null,
	@NgayKetThuc date = null
)
as
begin
	SELECT MaKM,TenKM, GiaKhuyenMai,NgayBatDau, NgayKetThuc
	FROM KhuyenMai
	WHERE (MaKM LIKE '%' + ISNULL(@MaKM, '') + '%')
		AND (TenKM LIKE '%' + ISNULL(@TenKM, '') + '%')
		AND (NgayBatDau = ISNULL(@NgayBatDat, NgayBatDau))
		AND (NgayKetThuc = ISNULL(@NgayKetThuc, NgayKetThuc))
end
GO
--Invoice Selling
CREATE PROC sp_getInvoiceSelling
(
	@MaHD varchar(10) = null,
	@MaNV varchar(10) = null,
	@MaKH varchar(10) = null,
	@NgayLapHD datetime = null
)
as
begin
	IF @MaKH IS NULL
		BEGIN
			SELECT MaHD, MaNV, MaKH, NgayLapHD, TongTien, TienKhachDua, TienTraKhach
			FROM HoaDonBanHang
			WHERE (MaHD LIKE '%' + ISNULL(@MaHD, '') + '%')
				AND (MaNV LIKE '%' + ISNULL(@MaNV, '') + '%')
				AND (NgayLapHD = ISNULL(@NgayLapHD, NgayLapHD))
		END
	ELSE
		BEGIN
			SELECT MaHD, MaNV, MaKH, NgayLapHD, TongTien, TienKhachDua, TienTraKhach
			FROM HoaDonBanHang
			WHERE (MaHD LIKE '%' + ISNULL(@MaHD, '') + '%')
				AND (MaNV LIKE '%' + ISNULL(@MaNV, '') + '%')
				AND (MaKH LIKE '%' + ISNULL(@MaKH, '') + '%')
				AND (NgayLapHD = ISNULL(@NgayLapHD, NgayLapHD))
		END
end
GO

--Detail Invoice Selling
CREATE PROC sp_GetDetailInvoiceSelling
(
	@MaHD varchar(10) = null,
	@MaSP varchar(20) = null,
	@MaKM varchar(10) = null
)
as
begin
	IF @MaKM IS NULL
		BEGIN
			SELECT MaHD, MaSP, MaKM, SoLuong, DonGia, ThanhTien
			FROM ChiTietHoaDonBanHang
			WHERE (MaHD LIKE '%' + ISNULL(@MaHD, '') + '%')
				AND (MaSP LIKE '%' + ISNULL(@MaSP, '') + '%')
		END
    ELSE
		BEGIN
			SELECT MaHD, MaSP, MaKM, SoLuong, DonGia, ThanhTien
			FROM ChiTietHoaDonBanHang
			WHERE (MaHD LIKE '%' + ISNULL(@MaHD, '') + '%')
				AND (MaSP LIKE '%' + ISNULL(@MaSP, '') + '%')
				AND (MaKM LIKE '%' + @MaKM + '%')
		END
end
GO
--Invoice Import Warehouse
CREATE PROC sp_GetInvoiceImportWareHouse
(
	@MaNK varchar(10) = null,
	@MaNV varchar(10) = null,
	@MaNCC varchar(10) = null,
	@NgayNhapKho datetime = null,
	@TongTien decimal = null
)
as
begin
	SELECT MaNK, MaNV, MaNCC, NgayNhapKho, TongTien
	FROM HoaDonNhapKho
	WHERE (MaNK LIKE '%' + ISNULL(@MaNK, '') + '%')
		AND (MaNV LIKE '%' + ISNULL(@MaNV, '') + '%')
		AND (MaNCC LIKE '%' + ISNULL(@MaNCC, '') + '%')
		AND (NgayNhapKho = ISNULL(@NgayNhapKho, NgayNhapKho))
		AND (TongTien = ISNULL(@TongTien, TongTien))
end
GO

--Detail Invoice Import Warehouse
CREATE PROC sp_GetDetailInvoiceImportWareHouse
(
	@MaNK varchar(20) = null,
	@MaSp varchar(20) = null
)
as
begin
	SELECT MaNK, MaSP, SoLuong, DonGiaNhap, ThanhTien
	FROM ChiTietHoaDonNhapKho
	WHERE (MaNK LIKE '%' + ISNULL(@MaNK, '') + '%')
		AND (MaSP LIKE '%' + ISNULL(@MaSp, '') + '%')
end
GO

------------------------------------------- INSERT  -------------------------------------------
--Account
CREATE PROC sp_InsertAccount
(
	@MaNV varchar(10),
	@MaChucVu varchar(5)
)
as
begin
	declare @isMaNV int = (SELECT COUNT(MANV) 
							FROM NhanVien
							WHERE MaNV = @MaNV)
	if (@isMaNV <= 0)	
	begin
		declare @pass varchar(255) = (SELECT CCCD FROM NhanVien WHERE MaNV = @MaNV)
		INSERT INTO TaiKhoan (MaNV, MatKhau, MaChucVu, TrangThai)
		VALUES (@MaNV, @pass, @MaChucVu, 1)

		SELECT 1
	end
end
GO

--Role
CREATE PROC sp_InsertRole
(
	@MaChucVu varchar(5) = null, 
	@TenChucVu nvarchar(255) = null,
	@TrangThai bit = 0
)
as
begin
	INSERT INTO ChucVu (MaChucVu, TenChucVu, TrangThai) VALUES (@MaChucVu, @TenChucVu, @TrangThai)

	SELECT 1
end
GO

--Employee
CREATE PROC sp_InsertEmployee
(
	@CCCD varchar(12), @HoTen nvarchar(100) = null, @GioiTinh nvarchar(3) = 'Nam',
	@DiaChi nvarchar(255) = null, @SDT varchar(12) = null, @NgayTao date = GETDATE,
	@MaChucVu varchar(5) = null, @TrangThai bit = 1
)
as 
begin 
		INSERT INTO NhanVien(CCCD, HoTen, GioiTinh, DiaChi, SDT, NgayTao, MaChucVu, TrangThai)
		VAlUES(@CCCD, @HoTen, @GioiTinh, @DiaChi, @SDT, @NgayTao, @MaChucVu, @TrangThai)

		declare @MaNV_New varchar(10) = ( SELECT TOP 1 MaNV
										FROM NhanVien
										ORDER BY MaNV DESC)
		INSERT INTO TaiKhoan(MaNV, MatKhau, MaChucVu, TrangThai) 
		VALUES(@MaNV_New, @CCCD, @MaChucVu, @TrangThai)

		SELECT 1
end
GO
--Customer
create proc sp_InsertCustomer
(
	 @CCCD varchar(12), @HoTen nvarchar(100) = null,
	@GioiTinh nvarchar(3) = 'Nam', @DiaChi nvarchar(255) = null, @SDT varchar(12) = null, @NgayDangKy date = GETDATE,
	 @TrangThai bit = 1
 

)
as 
begin 
		INSERT INTO KhachHang( HoTen, CCCD, SDT, GioiTinh, DiaChi, NgayDangKy, TrangThai)
		VAlUES( @HoTen ,@CCCD , @SDT ,@GioiTinh , @DiaChi , @NgayDangKy ,@TrangThai )
		SELECT 1
end
go

--Supplier
CREATE PROC sp_InsertSupplier
(
	@TenNCC nvarchar(255), @SDT varchar(12),
	@DiaChi nvarchar(255), @TrangThai bit = 1
)
as
begin
	INSERT INTO NhaCungCap(TenNCC, SDT, DiaChi, TrangThai)
	VALUES (@TenNCC, @SDT, @DiaChi, @TrangThai)

	SELECT 1
end
GO

--TypeProduct
CREATE PROC sp_InsertTypeProduct
(
	@TenLoai nvarchar(100) = null,
	@MoTa nvarchar(255) = null
)
as
begin
	INSERT INTO LoaiSanPham (TenLoai, MoTa)
	VALUES (@TenLoai, @MoTa)

	
	SELECT 1
end
GO

--Product
CREATE PROC sp_InsertProduct
(
	@TenSp nvarchar(50), @MaNCC varchar(20), @MaLoaiSP varchar(10),
	@GiaNhap decimal, @GiaBan decimal, @SoLuong int, @HanSuDung varchar(5),
	@DonViTinh nvarchar(20), @HinhAnh varchar(255), @TrangThai bit
)
as
begin
	INSERT INTO SanPham (TenSP, MaNCC, MaLoaiSP, GiaNhap, GiaBan, SoLuong, HanSuDung, DonViTinh, HinhAnh, TrangThai)
	VALUES (@TenSP, @MaNCC, @MaLoaiSP, @GiaNhap, @GiaBan, @SoLuong, @HanSuDung, @DonViTinh, @HinhAnh, @TrangThai)

	SELECT 1
end
GO

--Discount
CREATE PROC sp_InsertDiscount
(
	@MaKM varchar(10),
	@TenKM nvarchar(50),
	@GiaKhuyenMai float = 0,
	@NgayBatDau date = GETDATE,
	@NgayKetThuc date = GETDATE
)
as
begin
	INSERT INTO KhuyenMai (MaKM, TenKM, GiaKhuyenMai, NgayBatDau, NgayKetThuc)
	VALUES (@MaKM, @TenKM, @GiaKhuyenMai, @NgayBatDau, @NgayKetThuc)

	SELECT 1
end
GO
--Invoice Selling
CREATE PROC sp_InsertInvoiceSelling
(
	@MaNV varchar(10),
	@MaKH varchar(10) = null,
	@TongTien decimal,
	@TienKhachDua decimal = 0
)
as
begin
	INSERT INTO HoaDonBanHang(MaNV, MaKH, NgayLapHD,TongTien, TienKhachDua, TienTraKhach)
	VALUES (@MaNV, @MaKH, GETDATE() ,@TongTien, @TienKhachDua, @TienKhachDua - @TongTien)


	SELECT TOP 1 MaHD
	FROM HoaDonBanHang
	ORDER BY MaHD DESC
end
GO

--Detail Invoice Selling
CREATE PROC sp_InsertDetailInvoiceSelling
(
	@MaHD varchar(10),
	@MaSP varchar(20) = null,
	@MaKM varchar(10) = null,
	@SoLuong int = 0,
	@DonGia decimal = 0
)
as
begin
	INSERT INTO ChiTietHoaDonBanHang(MaHD, MaSP, MaKM, SoLuong, DonGia, ThanhTien)
	VALUES (@MaHD, @MaSP, @MaKM, @SoLuong, @DonGia, @SoLuong* @DonGia* (1 - (SELECT GiaKhuyenMai
																		FROM KhuyenMai
																		WHERE MaKM = @MaKM))
			)

	UPDATE SanPham
	SET SoLuong = SoLuong - @SoLuong
	WHERE MaSP = @MaSP
end
GO


--Invoice Import Warehouse
CREATE PROC sp_InsertInvoiceImportWareHouse
(
	@MaNV varchar(10),
	@MaNCC varchar(20),
	@NgayNhapKho datetime = GETDATE,
	@TongTien decimal
)
as
begin
	INSERT INTO HoaDonNhapKho (MaNV, MaNCC, NgayNhapKho, TongTien)
	VALUES (@MaNV, @MaNCC, @NgayNhapKho, @TongTien)

	SELECT TOP 1 MaNK
	FROM HoaDonNhapKho
	ORDER BY MaNK DESC
end
GO

--Detail Invoice Import Warehouse
ALTER PROC sp_InsertDetailInvoiceImportWareHouse
(
	@MaNK varchar(20) = null,
	@MaSP varchar(20) = null,
	@SoLuong int = 0,
	@DonGiaNhap decimal = 0
)
as
begin
	declare @NgayNhap datetime = ( SELECT NgayNhapKho
									FROM HoaDonNhapKho
									WHERE MaNK = @MaNK);
	declare @HSD varchar(5) = ( SELECT HanSuDung 
						FROM SanPham
						WHERE MaSP = @MaSP);

	declare @charHSD varchar(1) = RIGHT(@HSD, 1);
	declare @NgayHetHan date = null;

	IF @charHSD = 'D'
		BEGIN
			SET @NgayHetHan = DATEADD(day, CAST(LEFT(@HSD, LEN(@HSD) - 1 ) AS INT) , @NgayNhap)
		END
	ELSE IF @charHSD = 'M'
		BEGIN
			SET @NgayHetHan = DATEADD(MONTH, CAST(LEFT(@HSD, LEN(@HSD) - 1 ) AS INT) , @NgayNhap)
		END
	ELSE IF @charHSD = 'Y'
		BEGIN
			SET @NgayHetHan = DATEADD(YEAR, CAST(LEFT(@HSD, LEN(@HSD) - 1 ) AS INT) , @NgayNhap)
		END

	INSERT INTO ChiTietHoaDonNhapKho(MaNK, MaSP, NgayHetHan, SoLuong, DonGiaNhap, ThanhTien)
	VALUES (@MaNK, @MaSP, @NgayHetHan, @SoLuong, @DonGiaNhap, @SoLuong * @DonGiaNhap)

	SELECT 1
end
GO

------------------------------------------- UPDATE  -------------------------------------------
--Account
CREATE PROC sp_UpdatePasswordAccount
(
	@MaNV varchar(10),
	@MatKhau varchar(255)
)
as
begin
	declare @isMaNV int = (SELECT COUNT(MANV) 
							FROM NhanVien
							WHERE MaNV = @MaNV)
	if (@isMaNV > 0)
		begin
			UPDATE TaiKhoan
			SET MatKhau = @MatKhau
			WHERE @MaNV = MaNV
		end
	

	SELECT 1
end
GO
--Role
CREATE PROC sp_UpdateRole
(
	@MaChucVu varchar(5) = null,
	@TenChucVu nvarchar(255) = null,
	@TrangThai bit = 0
)
as
begin
	UPDATE ChucVu
	SET MaChucVu = @MaChucVu, TenChucVu = @TenChucVu, TrangThai = @TrangThai

	SELECT 1
end
GO
--Employee
CREATE PROC sp_UpdateEmployee
(
	@MaNV varchar(10), @CCCD varchar(12), @HoTen nvarchar(100),
	@GioiTinh nvarchar(3), @DiaChi nvarchar(255), @SDT varchar(12), @NgayTao date,
	@MaChucVu varchar(5), @TrangThai bit = 0 

)
as 
begin 
		UPDATE NhanVien
		SET CCCD = @CCCD, HoTen = @HoTen,GioiTinh = @GioiTinh, DiaChi = @DiaChi, 
			SDT = @SDT, NgayTao = @NgayTao, 
			MaChucVu = @MaChucVu, TrangThai = @TrangThai
		WHERE MaNV = @MaNV

		UPDATE TaiKhoan
		SET MaChucVu = @MaChucVu
		WHERE MaNV = @MaNV

		SELECT 1
end
GO

--Customer

create proc sp_UpdateCustomer
(
	@MaKH varchar(10),  @CCCD varchar(12), @HoTen nvarchar(100),
	@GioiTinh nvarchar(3), @DiaChi nvarchar(255), @SDT varchar(12), @NgayDangKy date,
	 @TrangThai bit = 0 
)
as 
begin 
		UPDATE KhachHang
		SET  CCCD = @CCCD, HoTen = @HoTen,
			GioiTinh = @GioiTinh, DiaChi = @DiaChi, SDT = @SDT, NgayDangKy = @NgayDangKy, 
			TrangThai = @TrangThai
		WHERE MaKH = @MaKH
		SELECT 1
end
go

--Supplier
CREATE PROC sp_UpdateSupplier
(
	@MaNCC varchar(20), @TenNCC nvarchar(255), @SDT varchar(12),
	@DiaChi nvarchar(255), @TrangThai bit = 1
)
as
begin
	UPDATE NhaCungCap
	SET TenNCC = @TenNCC, SDT = @SDT, DiaChi = @DiaChi, TrangThai = @TrangThai
	WHERE MaNCC = @MaNCC

	SELECT 1
end
GO


--TypeProduct
CREATE PROC sp_UpdateTypeProduct
(
	@MaLoaiSP varchar(10),
	@TenLoai nvarchar(100) = null,
	@MoTa nvarchar(255) = null
)
as
begin
	UPDATE LoaiSanPham
	SET TenLoai = @TenLoai, @MoTa = MoTa
	WHERE @MaLoaiSP = MaLoaiSP

	
	SELECT 1
end
GO


--Product
CREATE PROC sp_UpdateProduct
(
	@MaSP nvarchar(10), @TenSp nvarchar(50), @MaNCC varchar(20), @MaLoaiSP varchar(10),
	@GiaNhap decimal, @GiaBan decimal, @SoLuong int, @HanSuDung varchar(5),
	@DonViTinh nvarchar(20), @HinhAnh varchar(255), @TrangThai int
)
as
begin
	UPDATE SanPham
	SET TenSP = @TenSp, MaNCC = @MaNCC, MaLoaiSP = @MaLoaiSP, GiaNhap = @GiaNhap, GiaBan = @GiaBan, SoLuong = @SoLuong, 
		HanSuDung = @HanSuDung, DonViTinh = @DonViTinh, HinhAnh = @HinhAnh, TrangThai = @TrangThai
	WHERE MaSP = @MaSp

	SELECT 1
end
GO
--Discount
CREATE PROC sp_UpdateDiscount
(
	@MaKM varchar(10),
	@TenKM varchar(10),
	@GiaKhuyenMai float = 0,
	@NgayBatDau date = GETDATE,
	@NgayKetThuc date = GETDATE
)
as
begin
	UPDATE KhuyenMai 
	SET TenKM = @TenKM, GiaKhuyenMai = @GiaKhuyenMai, 
		NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc
	WHERE MaKM = @MaKM

	SELECT 1
end
GO

--Invoice Selling
CREATE PROC sp_UpdateInvoiceSelling
(
	@MaHD varchar(10) = null,
	@MaNV varchar(20) = null,
	@MaKH varchar(10) = null,
	@NgayLapHD Datetime = 0,
	@TongTien decimal = 0,
	@TienKhachDua decimal = 0
)
as
begin
	UPDATE HoaDonBanHang
	SET @MaNV =  @MaNV, MaKH = @MaKH, NgayLapHD = @NgayLapHD, TongTien = @TongTien, 
		TienKhachDua = @TienKhachDua,  TienTraKhach = @TienKhachDua - @TongTien
	WHERE MaHD = @MaHD

	SELECT 1
end
GO
--Detail Invoice Selling
CREATE PROC sp_UpdateDetailInvoiceSelling
(
	@MaHD varchar(10) = null,
	@MaSP varchar(20) = null,
	@MaKM varchar(10) = null,
	@SoLuong int = 0,
	@DonGia decimal = 0
)
as
begin
	UPDATE ChiTietHoaDonBanHang
	SET MaSP =  @MaSP, MaKM = @MaKM, SoLuong = @SoLuong, DonGia = @DonGia, ThanhTien = @SoLuong * @DonGia * (SELECT GiaKhuyenMai
																											FROM KhuyenMai
																											WHERE MaKM = @MaKM)
	WHERE MaHD = @MaHD

	IF @SoLuong > (SELECT SoLuong FROM SanPham WHERE MaSP = @MaSP)
		UPDATE SanPham
		SET SoLuong = SoLuong - @SoLuong
		WHERE MaSP = @MaSP
	ELSE IF @SoLuong < (SELECT SoLuong FROM SanPham WHERE MaSP = @MaSP)
		UPDATE SanPham
		SET SoLuong = SoLuong + @SoLuong
		WHERE MaSP = @MaSP

	SELECT 1
end
GO


--Invoice Import Warehouse
CREATE PROC sp_UpdateInvoiceImportWareHouse
(
	@MaNK varchar(20),
	@MaNV varchar(10),
	@MaNCC varchar(20),
	@NgayNhapKho datetime = GETDATE,
	@TongTien decimal
)
as
begin
	UPDATE HoaDonNhapKho
	SET MaNK = @MaNK, MaNV = @MaNV, MaNCC = @MaNCC, 
		NgayNhapKho = @NgayNhapKho, TongTien = @TongTien

	SELECT 1
end
GO

--Detail Invoice Import Warehouse
CREATE PROC sp_UpdateDetailInvoiceImportWareHouse
(
	@MaNK varchar(20) = null,
	@MaSp varchar(20) = null,
	@SoLuong int = 0,
	@DonGiaNhap decimal = 0
)
as
begin
	UPDATE ChiTietHoaDonNhapKho
	SET MaNK = @MaNK, MaSP = @MaSP, SoLuong = @SoLuong, 
		DonGiaNhap = @DonGiaNhap, ThanhTien = @SoLuong * DonGiaNhap

	SELECT 1
end
GO
------------------------------------------- UPDATE STATUS OR DELETE -------------------------------------------
--Account
CREATE PROC sp_UpdateStatusAccount
(
	@MaNV varchar(10),
	@MatKhau varchar(255),
	@MaChucVu varchar(5),
	@TrangThai bit
)
as
begin
	UPDATE TaiKhoan
	SET TrangThai = @TrangThai
	WHERE MaNV = @MaNV

	SELECT 1
end
GO
--Role
CREATE PROC sp_UpdatStatusRole
(
	@MaChucVu varchar(5) = null
)
as
begin
	UPDATE ChucVu
	SET TrangThai = 0

	SELECT 1
end
GO
--Employee
CREATE PROC sp_UpdateStatusEmployee
(
	@MaNV varchar(10) = null
)
as 
begin
	UPDATE NhanVien
	SET TrangThai = 0
	WHERE MaNV = @MaNV

	SELECT 1
end
GO
--Customer

create proc sp_UpdateStatusCustomer
(
	@MaKH varchar(10) = null
)
as 
begin
	Update KhachHang
	set TrangThai=0
	where MaKH=@MaKH
	select 1

end
go

--Supplier
CREATE PROC sp_UpdateStatusSupplier
(
	@MaNCC varchar(20)
)
as
begin
	UPDATE NhaCungCap
	SET TrangThai = 0
	WHERE MaNCC = @MaNCC

	UPDATE SanPham
	SET TrangThai = 0
	WHERE MaNCC = @MaNCC

	SELECT 1
end
GO
--TypeProduct
CREATE PROC sp_UpdateStatusTypeProduct
(
	@MaLoaiSP varchar(10)
)
as
begin
	DELETE FROM LoaiSanPham
	WHERE MaLoaiSP = @MaLoaiSP

	SELECT 1
end
GO
--Product
CREATE PROC sp_UpdateStatusProduct
(
	@MaSP varchar(20)
)
as
begin
	UPDATE SanPham
	SET TrangThai = 0
	WHERE MaSP = @MaSP

	SELECT 1
end
GO
--Discount

--Invoice Selling
CREATE PROC sp_DeleteInvoiceSelling
(
	@MaHD varchar(10)
)
as
begin
	DELETE FROM ChiTietHoaDonBanHang
	WHERE MaHD = @MaHD
	
	DELETE FROM HoaDonBanHang
	WHERE MaHD = @MaHD

	SELECT 1
end
GO

--Detail Invoice Selling
CREATE PROC sp_DeleteDetailInvoiceSelling
(
	@MaHD varchar(10),
	@MaSP varchar(20) = null
)
as
begin
	IF @MaSP IS NULL
		BEGIN 
			DELETE FROM ChiTietHoaDonBanHang
			WHERE MaHD = @MaHD
		END
	ELSE
		BEGIN
			DELETE FROM ChiTietHoaDonBanHang
			WHERE MaHD = @MaHD AND MaSP = @MaSP
		END


	SELECT 1
end
GO

--Invoice Import Warehouse

CREATE PROC sp_DeleteInvoiceImportWareHouse
(
	@MaNK varchar(20) = null
)
as
begin
	DELETE FROM ChiTietHoaDonNhapKho
	WHERE MaNK = @MaNK

	DELETE FROM HoaDonNhapKho
	WHERE MaNK = @MaNK

	SELECT 1
end
GO

--Detail Invoice Import Warehouse
CREATE PROC sp_DeleteDetailInvoiceImportWareHouse
(
	@MaSP varchar(20)
)
as
begin
	DELETE FROM ChiTietHoaDonNhapKho
	WHERE MaSP = @MaSP

	SELECT 1
end
GO