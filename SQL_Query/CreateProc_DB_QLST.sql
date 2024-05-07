use QLST
go
--FUNCTION
--REVENUE
--CREATE PROC sp_GetRevenue
--(
--	@Ngay date,
--	@TieuChi nvarchar(5)
--)
--as
--BEGIN
--	IF @TieuChi = N'Ngày'
--		BEGIN
--			SELECT 
--				(SELECT SUM(TongTien) FROM HoaDonBanHang WHERE Day(NgayLapHD) = DAY(@Ngay) 
--														AND MONTH(NgayLapHD) = MONTH(@Ngay) 
--														AND YEAR(NgayLapHD) = YEAR(@Ngay))
--				- (SELECT SUM(TongTien) FROM HoaDonNhapKho WHERE Day(NgayNhapKho) = DAY(@Ngay) 
--														AND MONTH(NgayNhapKho) = MONTH(@Ngay) 
--														AND YEAR(NgayNhapKho) = YEAR(@Ngay)) as DoanhThu,

--				(SELECT COUNT(DISTINCT HD.MaHD) FROM HoaDonBanHang HD WHERE Day(HD.NgayLapHD) = DAY(@Ngay) 
--														AND MONTH(HD.NgayLapHD) = MONTH(@Ngay) 
--														AND YEAR(HD.NgayLapHD) = YEAR(@Ngay))AS SLHD_Ban,

--				(SELECT COUNT(DISTINCT NK.MaNK) FROM HoaDonNhapKho NK WHERE Day(NK.NgayNhapKho) = DAY(@Ngay) 
--																		AND MONTH(NK.NgayNhapKho) = MONTH(@Ngay) 
--																		AND YEAR(NK.NgayNhapKho) = YEAR(@Ngay)) AS SLHD_Nhap,

--				COALESCE(SUM(CTHD.SoLuong), 0) AS SLSP_Ban,
--				COALESCE(SUM(CTNK.SoLuong), 0) AS SLSP_Nhap,

--				(SELECT COUNT(DISTINCT KM.MaKM) 
--				 FROM KhuyenMai KM 
--				 WHERE @Ngay BETWEEN KM.NgayBatDau AND KM.NgayKetThuc) AS SLKM,

--				COUNT(DISTINCT NK.MaNCC) AS SLNCC,
--				COUNT(DISTINCT HD.MaNV) AS SLNV
--			FROM
--				HoaDonBanHang HD
--			LEFT JOIN
--				ChiTietHoaDonBanHang CTHD ON HD.MaHD = CTHD.MaHD
--			LEFT JOIN
--				HoaDonNhapKho NK ON NK.NgayNhapKho = @Ngay
--			LEFT JOIN
--				ChiTietHoaDonNhapKho CTNK ON NK.MaNK = CTNK.MaNK
--			LEFT JOIN
--				KhuyenMai KM ON @Ngay BETWEEN KM.NgayBatDau AND KM.NgayKetThuc
--			WHERE
--				(Day(HD.NgayLapHD) = DAY(@Ngay) 
--				AND MONTH(HD.NgayLapHD) = MONTH(@Ngay) 
--				AND YEAR(HD.NgayLapHD) = YEAR(@Ngay))
--				OR
--				(Day(NK.NgayNhapKho) = DAY(@Ngay) 
--				AND MONTH(NK.NgayNhapKho) = MONTH(@Ngay) 
--				AND YEAR(NK.NgayNhapKho) = YEAR(@Ngay))
--		END
--	ELSE IF @TieuChi = N'Tuần'
--		BEGIN
--			--Level: Hard -- Finish
--			SELECT 
--				COALESCE(SUM(HD.TongTien), 0) - COALESCE(SUM(NK.TongTien), 0) as DoanhThu,
--				COUNT(DISTINCT HD.MaHD) AS SLHD_Ban,
--				COUNT(DISTINCT NK.MaNK) AS SLHD_Nhap,
--				COALESCE(SUM(CTHD.SoLuong), 0) AS SLSP_Ban,
--				COALESCE(SUM(CTNK.SoLuong), 0) AS SLSP_Nhap,
--				COUNT(DISTINCT KM.MaKM) AS SLKM,
--				COUNT(DISTINCT NK.MaNCC) AS SLNCC,
--				COUNT(DISTINCT HD.MaNV) AS SLNV
--			FROM
--				HoaDonBanHang HD
--			LEFT JOIN
--				ChiTietHoaDonBanHang CTHD ON HD.MaHD = CTHD.MaHD
--			LEFT JOIN
--				HoaDonNhapKho NK ON DATEPART(WW, NK.NgayNhapKho) = DATEPART(WW, @Ngay)
--			LEFT JOIN
--				ChiTietHoaDonNhapKho CTNK ON NK.MaNK = CTNK.MaNK
--			LEFT JOIN
--				KhuyenMai KM ON DATEPART(WW, @Ngay) BETWEEN DATEPART(WW, KM.NgayBatDau) AND DATEPART(WW, KM.NgayKetThuc)
--			WHERE
--				DATEPART(WW, @Ngay) = DATEPART(WW, NgayLapHD) AND YEAR(HD.NgayLapHD) = YEAR(@Ngay)
--				OR
--				DATEPART(WW, @Ngay) = DATEPART(WW, NgayNhapKho) AND YEAR(NK.NgayNhapKho) = YEAR(@Ngay)
--		END
--	ELSE IF @TieuChi = N'QUÝ'
--		BEGIN
--			SELECT 
--				COALESCE(SUM(HD.TongTien), 0) - COALESCE(SUM(NK.TongTien), 0) as DoanhThu,
--				COUNT(DISTINCT HD.MaHD) AS SLHD_Ban,
--				COUNT(DISTINCT NK.MaNK) AS SLHD_Nhap,
--				COALESCE(SUM(CTHD.SoLuong), 0) AS SLSP_Ban,
--				COALESCE(SUM(CTNK.SoLuong), 0) AS SLSP_Nhap,
--				COUNT(DISTINCT KM.MaKM) AS SLKM,
--				COUNT(DISTINCT NK.MaNCC) AS SLNCC,
--				COUNT(DISTINCT HD.MaNV) AS SLNV
--			FROM
--				HoaDonBanHang HD
--			LEFT JOIN
--				ChiTietHoaDonBanHang CTHD ON HD.MaHD = CTHD.MaHD
--			LEFT JOIN
--				HoaDonNhapKho NK ON DATEPART(qq, NK.NgayNhapKho) = DATEPART(qq, @Ngay)
--			LEFT JOIN
--				ChiTietHoaDonNhapKho CTNK ON NK.MaNK = CTNK.MaNK
--			LEFT JOIN
--				KhuyenMai KM ON DATEPART(qq, @Ngay) BETWEEN DATEPART(qq, KM.NgayBatDau) AND DATEPART(qq, KM.NgayKetThuc)
--			WHERE
--				DATEPART(qq, @Ngay) = DATEPART(qq, NgayLapHD) AND YEAR(HD.NgayLapHD) = YEAR(@Ngay)
--				OR
--				DATEPART(qq, @Ngay) = DATEPART(qq, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay)
--		END
--	ELSE IF @TieuChi = N'Tháng'
--		BEGIN
--			SELECT 
--				COALESCE(SUM(HD.TongTien), 0) - COALESCE(SUM(NK.TongTien), 0) as DoanhThu,
--				COUNT(DISTINCT HD.MaHD) AS SLHD_Ban,
--				COUNT(DISTINCT NK.MaNK) AS SLHD_Nhap,
--				COALESCE(SUM(CTHD.SoLuong), 0) AS SLSP_Ban,
--				COALESCE(SUM(CTNK.SoLuong), 0) AS SLSP_Nhap,
--				COUNT(DISTINCT KM.MaKM) AS SLKM,
--				COUNT(DISTINCT NK.MaNCC) AS SLNCC,
--				COUNT(DISTINCT HD.MaNV) AS SLNV
--			FROM
--				HoaDonBanHang HD
--			LEFT JOIN
--				ChiTietHoaDonBanHang CTHD ON HD.MaHD = CTHD.MaHD
--			LEFT JOIN
--				HoaDonNhapKho NK ON MONTH(NK.NgayNhapKho) = MONTH(@Ngay)
--			LEFT JOIN
--				ChiTietHoaDonNhapKho CTNK ON NK.MaNK = CTNK.MaNK
--			LEFT JOIN
--				KhuyenMai KM ON MONTH(@Ngay) BETWEEN MONTH(KM.NgayBatDau) AND MONTH(KM.NgayKetThuc)
--			WHERE
--				MONTH(HD.NgayLapHD) = MONTH(@Ngay) AND YEAR(HD.NgayLapHD) = YEAR(@Ngay)
--				OR
--				MONTH(NgayNhapKho) = MONTH(@Ngay) AND YEAR(NgayNhapKho) = YEAR(@Ngay)
--		END
--	ELSE IF @TieuChi = N'Năm'
--		BEGIN
--			SELECT 
--				COALESCE(SUM(HD.TongTien), 0) - COALESCE(SUM(NK.TongTien), 0) as DoanhThu,
--				COUNT(DISTINCT HD.MaHD) AS SLHD_Ban,
--				COUNT(DISTINCT NK.MaNK) AS SLHD_Nhap,
--				COALESCE(SUM(CTHD.SoLuong), 0) AS SLSP_Ban,
--				COALESCE(SUM(CTNK.SoLuong), 0) AS SLSP_Nhap,
--				COUNT(DISTINCT KM.MaKM) AS SLKM,
--				COUNT(DISTINCT NK.MaNCC) AS SLNCC,
--				COUNT(DISTINCT HD.MaNV) AS SLNV
--			FROM
--				HoaDonBanHang HD
--			LEFT JOIN
--				ChiTietHoaDonBanHang CTHD ON HD.MaHD = CTHD.MaHD
--			LEFT JOIN
--				HoaDonNhapKho NK ON YEAR(NK.NgayNhapKho) = YEAR(@Ngay)
--			LEFT JOIN
--				ChiTietHoaDonNhapKho CTNK ON NK.MaNK = CTNK.MaNK
--			LEFT JOIN
--				KhuyenMai KM ON YEAR(@Ngay) BETWEEN YEAR(KM.NgayBatDau) AND YEAR(KM.NgayKetThuc)
--			WHERE
--				YEAR(HD.NgayLapHD) = YEAR(@Ngay)
--				OR
--				YEAR(NgayNhapKho) = YEAR(@Ngay)
--		END
--END
GO
create function func_TienBanSP
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns decimal 
as
BEGIN
declare @TienBanSP decimal = 0
	if @TieuChi = N'Ngày'
		SET @TienBanSP = (SELECT SUM(TongTien) FROM HoaDonBanHang WHERE Day(NgayLapHD) = DAY(@Ngay) 
											AND MONTH(NgayLapHD) = MONTH(@Ngay) 
											AND YEAR(NgayLapHD) = YEAR(@Ngay))
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @TienBanSP = (SELECT SUM(TongTien) FROM HoaDonBanHang WHERE DATEPART(WW, @Ngay) = DATEPART(WW, NgayLapHD) AND YEAR(NgayLapHD) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Tháng'
		SET @TienBanSP = (SELECT SUM(TongTien) FROM HoaDonBanHang WHERE MONTH(NgayLapHD) = MONTH(@Ngay) AND YEAR(NgayLapHD) = YEAR(@Ngay))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @TienBanSP = (SELECT SUM(TongTien) FROM HoaDonBanHang WHERE DATEPART(QQ, @Ngay) = DATEPART(QQ, NgayLapHD) AND YEAR(NgayLapHD) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Năm'
		BEGIN
			SET @TienBanSP = (SELECT SUM(TongTien) FROM HoaDonBanHang WHERE YEAR(NgayLapHD) = YEAR(@Ngay))						
		END
	return @TienBanSP
END;
GO

create function func_TienNhapSP
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns decimal 
as
BEGIN
declare @TienNhapSP decimal = 0
	if @TieuChi = N'Ngày'
		SET @TienNhapSP = (SELECT SUM(TongTien) FROM HoaDonNhapKho WHERE Day(NgayNhapKho) = DAY(@Ngay) 
													AND MONTH(NgayNhapKho) = MONTH(@Ngay) 
													AND YEAR(NgayNhapKho) = YEAR(@Ngay))
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @TienNhapSP = (SELECT SUM(TongTien) FROM HoaDonNhapKho WHERE DATEPART(WW, @Ngay) = DATEPART(WW, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Tháng'
		SET @TienNhapSP = (SELECT SUM(TongTien) FROM HoaDonNhapKho WHERE MONTH(NgayNhapKho) = MONTH(@Ngay) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @TienNhapSP = (SELECT SUM(TongTien) FROM HoaDonNhapKho WHERE DATEPART(QQ, @Ngay) = DATEPART(QQ, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Năm'
		BEGIN
			SET @TienNhapSP = (SELECT SUM(TongTien) FROM HoaDonNhapKho WHERE YEAR(NgayNhapKho) = YEAR(@Ngay))
		END
	return @TienNhapSP
END
GO

--SLHD BAN
create function func_SLHD_Ban
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns int 
as
BEGIN
declare @SLHD_Ban int = 0
	if @TieuChi = N'Ngày'
		SET @SLHD_Ban = (SELECT COUNT(MaHD) FROM HoaDonBanHang WHERE Day(NgayLapHD) = DAY(@Ngay) 
											AND MONTH(NgayLapHD) = MONTH(@Ngay) 
											AND YEAR(NgayLapHD) = YEAR(@Ngay))
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @SLHD_Ban = (SELECT COUNT(MaHD) FROM HoaDonBanHang WHERE DATEPART(WW, @Ngay) = DATEPART(WW, NgayLapHD) AND YEAR(NgayLapHD) = YEAR(@Ngay))							
		END
	else if @TieuChi = N'Tháng'
		SET @SLHD_Ban = (SELECT COUNT(MaHD) FROM HoaDonBanHang WHERE MONTH(NgayLapHD) = MONTH(@Ngay) AND YEAR(NgayLapHD) = YEAR(@Ngay))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @SLHD_Ban = (SELECT COUNT(MaHD) FROM HoaDonBanHang WHERE DATEPART(QQ, @Ngay) = DATEPART(QQ, NgayLapHD) AND YEAR(NgayLapHD) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Năm'
	BEGIN
		SET @SLHD_Ban = (SELECT COUNT(MaHD) FROM HoaDonBanHang WHERE YEAR(NgayLapHD) = YEAR(@Ngay))
	END
	return @SLHD_Ban
END
GO

--SLHD Nhap
create function func_SLHD_Nhap
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns int 
as
BEGIN
declare @SLHD_Nhap int = 0
	if @TieuChi = N'Ngày'
		SET @SLHD_Nhap = (SELECT COUNT(MaNK) FROM HoaDonNhapKho WHERE Day(NgayNhapKho) = DAY(@Ngay) 
											AND MONTH(NgayNhapKho) = MONTH(@Ngay) 
											AND YEAR(NgayNhapKho) = YEAR(@Ngay))
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @SLHD_Nhap = (SELECT COUNT(MaNK) FROM HoaDonNhapKho WHERE DATEPART(WW, @Ngay) = DATEPART(WW, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay))							
		END
	else if @TieuChi = N'Tháng'
		SET @SLHD_Nhap = (SELECT COUNT(MaNK) FROM HoaDonNhapKho WHERE MONTH(NgayNhapKho) = MONTH(@Ngay) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @SLHD_Nhap = (SELECT COUNT(MaNK) FROM HoaDonNhapKho WHERE DATEPART(QQ, @Ngay) = DATEPART(QQ, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Năm'
	BEGIN
		SET @SLHD_Nhap = (SELECT COUNT(MaNK) FROM HoaDonNhapKho WHERE YEAR(NgayNhapKho) = YEAR(@Ngay))
	END
	return @SLHD_Nhap
END
GO

--SLHD Ban
create function func_SLSP_Ban
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns int 
as
BEGIN
declare @SLSP_Ban int = 0
	if @TieuChi = N'Ngày'
		SET @SLSP_Ban = (SELECT Sum(SoLuong) FROM ChiTietHoaDonBanHang CT JOIN HoaDonBanHang HD ON  CT.MaHD = HD.MaHD
						WHERE Day(NgayLapHD) = DAY(@Ngay) 
							AND MONTH(NgayLapHD) = MONTH(@Ngay) 
							AND YEAR(NgayLapHD) = YEAR(@Ngay)
						)
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @SLSP_Ban = (SELECT Sum(SoLuong) FROM ChiTietHoaDonBanHang CT JOIN HoaDonBanHang HD ON  CT.MaHD = HD.MaHD
							WHERE DATEPART(WW, @Ngay) = DATEPART(WW, NgayLapHD) AND YEAR(NgayLapHD) = YEAR(@Ngay))							
		END
	else if @TieuChi = N'Tháng'
		SET @SLSP_Ban = (SELECT Sum(SoLuong) FROM ChiTietHoaDonBanHang CT JOIN HoaDonBanHang HD ON  CT.MaHD = HD.MaHD 
						WHERE MONTH(NgayLapHD) = MONTH(@Ngay) AND YEAR(NgayLapHD) = YEAR(@Ngay))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @SLSP_Ban = (SELECT Sum(SoLuong) FROM ChiTietHoaDonBanHang CT JOIN HoaDonBanHang HD ON  CT.MaHD = HD.MaHD
							WHERE DATEPART(QQ, @Ngay) = DATEPART(QQ, NgayLapHD) AND YEAR(NgayLapHD) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Năm'
	BEGIN
		SET @SLSP_Ban = (SELECT Sum(SoLuong) FROM ChiTietHoaDonBanHang CT JOIN HoaDonBanHang HD ON  CT.MaHD = HD.MaHD
						WHERE YEAR(NgayLapHD) = YEAR(@Ngay))
	END
	return @SLSP_Ban
END
GO

--SLSP_Nhap
create function func_SLSP_Nhap
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns int 
as
BEGIN
declare @SLSP_Nhap int = 0
	if @TieuChi = N'Ngày'
		SET @SLSP_Nhap = (SELECT Sum(SoLuong) FROM ChiTietHoaDonNhapKho CT JOIN HoaDonNhapKho NK ON  CT.MaNK = NK.MaNK
						WHERE Day(NgayNhapKho) = DAY(@Ngay) 
							AND MONTH(NgayNhapKho) = MONTH(@Ngay) 
							AND YEAR(NgayNhapKho) = YEAR(@Ngay)
						)
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @SLSP_Nhap = (SELECT Sum(SoLuong) FROM ChiTietHoaDonNhapKho CT JOIN HoaDonNhapKho NK ON  CT.MaNK = NK.MaNK
							WHERE DATEPART(WW, @Ngay) = DATEPART(WW, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay))							
		END
	else if @TieuChi = N'Tháng'
		SET @SLSP_Nhap = (SELECT Sum(SoLuong) FROM ChiTietHoaDonNhapKho CT JOIN HoaDonNhapKho NK ON  CT.MaNK = NK.MaNK
						WHERE MONTH(NgayNhapKho) = MONTH(@Ngay) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @SLSP_Nhap = (SELECT Sum(SoLuong) FROM ChiTietHoaDonNhapKho CT JOIN HoaDonNhapKho NK ON  CT.MaNK = NK.MaNK
							WHERE DATEPART(QQ, @Ngay) = DATEPART(QQ, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Năm'
	BEGIN
		SET @SLSP_Nhap = (SELECT Sum(SoLuong) FROM ChiTietHoaDonNhapKho CT JOIN HoaDonNhapKho NK ON  CT.MaNK = NK.MaNK
						WHERE YEAR(NgayNhapKho) = YEAR(@Ngay))
	END
	return @SLSP_Nhap
END
GO

--SLKM
create function func_SLKM
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns int 
as
BEGIN
declare @SLKM int = 0
	if @TieuChi = N'Ngày'
		SET @SLKM = (SELECT COUNT(MaKM) FROM KhuyenMai WHERE @Ngay BETWEEN NgayBatDau AND NgayKetThuc)
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @SLKM = (SELECT COUNT(MaKM) FROM KhuyenMai WHERE DATEPART(WW, @Ngay) BETWEEN DATEPART(WW, NgayBatDau) AND DATEPART(WW, NgayKetThuc))							
		END
	else if @TieuChi = N'Tháng'
		SET @SLKM = (SELECT COUNT(MaKM) FROM KhuyenMai WHERE MONTH(@Ngay) BETWEEN MONTH(NgayBatDau) AND MONTH(NgayKetThuc))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @SLKM = (SELECT COUNT(MaKM) FROM KhuyenMai WHERE DATEPART(QQ, @Ngay) BETWEEN DATEPART(QQ, NgayBatDau) AND DATEPART(QQ, NgayKetThuc))
		END
	else if @TieuChi = N'Năm'
	BEGIN
		SET @SLKM = (SELECT COUNT(MaKM) FROM KhuyenMai WHERE YEAR(@Ngay) BETWEEN YEAR(NgayBatDau) AND YEAR(NgayKetThuc))
	END
	return @SLKM
END
GO

--SL_NCC
create function func_SLNCC
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns int 
as
BEGIN
declare @SLNCC int = 0
	if @TieuChi = N'Ngày'
		SET @SLNCC = (SELECT DISTINCT COUNT(MaNCC) FROM HoaDonNhapKho WHERE Day(NgayNhapKho) = DAY(@Ngay) 
																	AND MONTH(NgayNhapKho) = MONTH(@Ngay) 
																	AND YEAR(NgayNhapKho) = YEAR(@Ngay))
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @SLNCC = (SELECT DISTINCT COUNT(MaNCC) FROM HoaDonNhapKho 
							WHERE DATEPART(WW, @Ngay) = DATEPART(WW, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay))							
		END
	else if @TieuChi = N'Tháng'
		SET @SLNCC = (SELECT DISTINCT COUNT(MaNCC) FROM HoaDonNhapKho 
						WHERE MONTH(NgayNhapKho) = MONTH(@Ngay) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @SLNCC = (SELECT DISTINCT COUNT(MaNCC) FROM HoaDonNhapKho 
							WHERE DATEPART(QQ, @Ngay) = DATEPART(QQ, NgayNhapKho) AND YEAR(NgayNhapKho) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Năm'
	BEGIN
		SET @SLNCC = (SELECT DISTINCT COUNT(MaNCC) FROM HoaDonNhapKho 
						WHERE YEAR(NgayNhapKho) = YEAR(@Ngay))
	END
	return @SLNCC
END
GO

--SL_NV
create function func_SLNV
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
returns int 
as
BEGIN
declare @SLNV int = 0
	if @TieuChi = N'Ngày'
		SET @SLNV = (SELECT DISTINCT COUNT(MaNV) FROM HoaDonBanHang	WHERE Day(NgayLapHD) = DAY(@Ngay) 
															AND MONTH(NgayLapHD) = MONTH(@Ngay) 
															AND YEAR(NgayLapHD) = YEAR(@Ngay))
	else if @TieuChi = N'Tuần'
		BEGIN
			SET @SLNV = (SELECT DISTINCT COUNT(MaNV) FROM HoaDonBanHang
							WHERE DATEPART(WW, @Ngay) = DATEPART(WW, NgayLapHD) AND YEAR(NgayLapHD) = YEAR(@Ngay))							
		END
	else if @TieuChi = N'Tháng'
		SET @SLNV = (SELECT DISTINCT COUNT(MaNV) FROM HoaDonBanHang
						WHERE MONTH(NgayLapHD) = MONTH(@Ngay) AND YEAR(NgayLapHD) = YEAR(@Ngay))
	else if @TieuChi = N'Quý'
		BEGIN
			SET @SLNV = (SELECT DISTINCT COUNT(MaNV) FROM HoaDonBanHang
							WHERE DATEPART(QQ, @Ngay) = DATEPART(QQ, NgayLapHD) AND YEAR(NgayLapHD) = YEAR(@Ngay))
		END
	else if @TieuChi = N'Năm'
	BEGIN
		SET @SLNV = (SELECT DISTINCT COUNT(MaNV) FROM HoaDonBanHang
						WHERE YEAR(NgayLapHD) = YEAR(@Ngay))
	END
	return @SLNV
END
GO

ALTER PROC sp_GetRevenue
(
	@Ngay datetime,
	@TieuChi nvarchar(5)
)
AS
BEGIN
SELECT
	dbo.func_TienBanSP(@Ngay, @TieuChi) - dbo.func_TienNhapSP(@Ngay, @TieuChi) AS DoanhThu,
	dbo.func_TienBanSP(@Ngay, @TieuChi) AS TienBanSP,
	dbo.func_TienNhapSP(@Ngay, @TieuChi) AS TienNhapSP,
	dbo.func_SLHD_Ban(@Ngay, @TieuChi) AS SLHD_Ban,
	dbo.func_SLHD_Nhap(@Ngay, @TieuChi) AS SLHD_Nhap,
	dbo.func_SLSP_Ban(@Ngay, @TieuChi) AS SLSP_Ban,
	dbo.func_SLSP_Nhap(@Ngay, @TieuChi) AS SLSP_Nhap,
	dbo.func_SLKM(@Ngay, @TieuChi) AS SLKM,
	dbo.func_SLNCC(@Ngay, @TieuChi) AS SLNCC,
	dbo.func_SLNV(@Ngay, @TieuChi) AS SLNV
END

--PROC
------------------------------------------- GET AND SEARCH  -------------------------------------------

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
CREATE PROC sp_getEmployeeTo
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
		SELECT MaNV, CCCD, HoTen, GioiTinh, DiaChi, SDT, NgayTao, MaChucVu, TrangThai
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
		SELECT MaNV, CCCD, HoTen, GioiTinh, DiaChi, SDT, NgayTao, MaChucVu, TrangThai
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
	@TrangThai bit = null
)
as
begin
	IF @TrangThai is null
		SELECT MaNCC, TenNCC, SDT, DiaChi, TrangThai
		FROM NhaCungCap
		WHERE (MaNCC LIKE '%' + ISNULL(@MaNCC, '') + '%')
			AND (TenNCC LIKE '%' + ISNULL(@TenNCC, '') + '%')
			AND (SDT LIKE '%' + ISNULL(@SDT, '') + '%')
			AND (DiaChi LIKE '%' + ISNULL(@DiaChi, '') + '%')
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
ALTER PROC sp_getProduct
(
	@MaSP varchar(20) = null,
	@TenSP nvarchar(50) = null,
	@TenNCC nvarchar(255) = null,
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
ALTER PROC sp_getInvoiceSelling
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
			SELECT MaHD, MaNV, MaKH,NgayLapHD, TongTien, TienKhachDua, TienTraKhach
			FROM HoaDonBanHang HD
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
ALTER PROC sp_GetDetailInvoiceSelling
(
	@MaHD varchar(10) = null,
	@MaSP varchar(20) = null,
	@MaKM varchar(10) = null
)
as
begin
	IF @MaKM IS NULL
		BEGIN
			SELECT MaHD, TenSP, MaKM, DonGia, CT.SoLuong as SL, ThanhTien
			FROM 
				ChiTietHoaDonBanHang CT
			LEFT JOIN
				SanPham SP ON SP.MaSP = CT.MaSP
			WHERE (MaHD LIKE '%' + ISNULL(@MaHD, '') + '%')
				AND (CT.MaSP LIKE '%' + ISNULL(@MaSP, '') + '%')
		END
	ELSE
		BEGIN
			SELECT MaHD, TenSp, MaKM, DonGia, CT.SoLuong as SL, ThanhTien
			FROM 
				ChiTietHoaDonBanHang CT
			LEFT JOIN
				SanPham SP ON SP.MaSP = CT.MaSP
			WHERE (MaHD LIKE '%' + ISNULL(@MaHD, '') + '%')
				AND (CT.MaSP LIKE '%' + ISNULL(@MaSP, '') + '%')
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
ALTER PROC sp_InsertInvoiceImportWareHouse
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

	UPDATE SanPham
	SET SoLuong = SoLuong + @SoLuong
	WHERE MaSP = @MaSP

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
ALTER PROC sp_UpdateEmployee
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