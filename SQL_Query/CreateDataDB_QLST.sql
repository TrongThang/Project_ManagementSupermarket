use QLST

--ADD DATA CHUCVU
INSERT INTO CHUCVU (MaChucVu, TenChucVu, TrangThai) VALUES
('QLCC',N'Quản Lý Cấp Cao',1)
,('QL',N'Quản Lý',1)
,('NV',N'Nhân Viên',1)

--ADD DATA NHANVIEN
INSERT INTO NHANVIEN (MaNV, CCCD, HoTen, GioiTinh, DiaChi, SDT, NgayTao,MaChucVu, TrangThai) VALUES
('NV001',N'1234567890',N'Nguyễn Văn An',N'Nam',N'123 Lê Lợi, Quận 1, TP.HCM','0123 456 789','2023-06-14','NV',1)
,('NV002',N'987654321',N'Trần Thị Bình',N'Nữ',N'456 Nguyễn Văn Linh, Quận 7, TP.HCM','0987 654 321','2023-10-05','NV',1)
,('NV003',N'1357924680',N'Lê Văn Cường',N'Nam',N'789 Trần Hưng Đạo, Đà Nẵng','0909 888 777','2022-10-12','NV',0)
,('NV004',N'2468013579',N'Phạm Thị Dung',N'Nữ',N'101 Lê Lai, Hải Phòng','0888 999 000','2023-05-01','NV',1)
,('NV005',N'9876543210',N'Nguyễn Văn Bắc',N'Nam',N'456 Lý Thường Kiệt, Hà Nội','0123 456 789','2024-02-13','NV',1)
,('NV006',N'123456789',N'Trần Thị Trang',N'Nữ',N'789 Trần Phú, Hà Nội','0987 654 321','2023-01-24','QLCC',0)
,('NV007',N'5678901234',N'Lê Văn Hoàng',N'Nam',N'101 Hùng Vương, Đà Nẵng','0909 888 777','2023-09-01','NV',1)
,('NV008',N'4321098765',N'Phạm Thị Hương',N'Nữ',N'123 Bạch Đằng, Hải Phòng','0888 999 000','2023-07-07','NV',1)
,('NV009',N'987123456',N'Nguyễn Văn Thành',N'Nam',N'456 Nguyễn Huệ, TP.HCM','0123 456 789','2024-01-10','NV',1)
,('NV010',N'6543210987',N'Trần Thị Hằng',N'Nữ',N'789 Trần Phú, Hà Nội','0987 654 321','2023-06-25','QL',1)

--ADD DATA TAIKHOAN
INSERT INTO TAIKHOAN (MaNV, MatKhau, MaChucVu, TrangThai) VALUES
('NV001','password123','NV',1)
,('NV002','123456','NV',1)
,('NV003','abcdef','NV',0)
,('NV004','pass1234','NV',1)
,('NV005','987654','NV',1)
,('NV006','qwerty','QLCC',0)
,('NV007','654321','NV',1)
,('NV008','passpass','NV',1)
,('NV009','111111','NV',1)
,('NV010','222222','QL',1)

--ADD DATA KHACHHANG
INSERT INTO KHACHHANG (MaKH,HoTen, CCCD, SDT, GioiTinh, DiaChi, NgayDangKy, TrangThai) VALUES
('00001',N'Nguyễn Thị Hồng','1234567890','0123 456 789',N'Nữ',N'10 Nguyễn Du, Quận 1, TP.HCM','2023-12-23',1)
,('00002',N'Trần Văn Long','987654321','0987 654 321',N'Nam',N'20 Lê Lợi, Quận 3, TP.HCM','2023-11-30',1)
,('00003',N'Lê Thị Thanh','1357924680','0909 888 777',N'Nữ',N'30 Đống Đa, Quận 5, TP.HCM','2023-10-14',0)
,('00004',N'Phạm Văn Đức','2468013579','0888 999 000',N'Nam',N'40 Nguyễn Huệ, Quận 10, TP.HCM','2024-02-26',1)
,('00005',N'Hoàng Thị Mai','9876543210','0123 456 789',N'Nữ',N'50 Hai Bà Trưng, Quận 11, TP.HCM','2024-02-23',1)
,('00006',N'Nguyễn Văn Đức','123456789','0987 654 321',N'Nam',N'60 Cộng Hòa, Quận Tân Bình, TP.HCM','2024-01-08',0)
,('00007',N'Trần Thị Hương','5678901234','0909 888 777',N'Nữ',N'70 Nguyễn Thị Minh Khai, Quận 3, TP.HCM','2023-12-31',1)
,('00008',N'Lê Văn Nam','4321098765','0888 999 000',N'Nam',N'80 Trần Hưng Đạo, Quận 5, TP.HCM','2023-12-17',1)
,('00009',N'Phạm Thị Hằng','987123456','0123 456 789',N'Nữ',N'90 Bến Thành, Quận 1, TP.HCM','2023-12-02',1)
,('00010',N'Hoàng Văn Tuấn','6543210987','0987 654 321',N'Nam',N'100 Phạm Ngọc Thạch, Quận 3, TP.HCM','2024-01-13',0)


--ADD DATA NHACUNGCAP
INSERT INTO NHACUNGCAP (MaNCC,TenNCC, SDT, DiaChi, TrangThai) VALUES
('NCC001',N'Cửa hàng Thực Phẩm A','0123 456 789',N'12 Nguyễn Văn Linh, Quận 7, HCM',1)
,('NCC002',N'Cửa hàng Tiện Lợi B','0987 654 321',N'34 Lê Lai, Quận 1, HCM',1)
,('NCC003',N'Cửa hàng Vật Liệu C','0909 888 777',N'56 Nguyễn Thị Minh Khai, Q.3, HCM',0)
,('NCC004',N'Siêu Thị Mini XYZ','0888 999 000',N'78 Lý Thường Kiệt, Quận 10, HCM',1)
,('NCC005',N'Cửa hàng Đồ Điện D','0123 456 123',N'90 Trần Hưng Đạo, Quận 5, HCM',1)
,('NCC006',N'Siêu Thị Nhỏ ABC','0987 654 987',N'123 Bến Thành, Quận 1, HCM',1)
,('NCC007',N'Cửa hàng Thực Phẩm E','0909 888 555',N'456 Cống Quỳnh, Quận 1, HCM',0)
,('NCC008',N'Cửa hàng Tiện Lợi F','0888 999 111',N'678 Nguyễn Văn Cừ, Quận 5, HCM',1)
,('NCC009',N'Cửa hàng Vật Liệu G','0123 456 333',N'890 Nguyễn Đình Chiểu, Q.3, HCM',1)
,('NCC010',N'Siêu Thị Mini KLM','0987 654 444',N'101 Lê Lợi, Quận 1, HCM',0)


--ADD DATA LOAISANPHAM
INSERT INTO LOAISANPHAM (MaLoaiSP, TenLoai, MoTa) VALUES
('LSP001',N'Bánh Kẹo',N'Loại sản phẩm gồm các loại bánh và kẹo')
,('LSP002',N'Nước Giải Khát',N'Loại sản phẩm chứa các loại nước giải khát')
,('LSP003',N'Thực Phẩm',N'Loại sản phẩm bao gồm các sản phẩm thực phẩm')
,('LSP004',N'Gia Vị',N'Loại sản phẩm chứa các loại gia vị khác nhau')
,('LSP005',N'Đồ Điện Tử',N'Loại sản phẩm bao gồm các sản phẩm điện tử')
,('LSP006',N'Quần Áo',N'Loại sản phẩm chứa các sản phẩm quần áo và phụ kiện')
,('LSP007',N'Đồ Chơi',N'Loại sản phẩm gồm các loại đồ chơi cho trẻ em')
,('LSP008',N'Mỹ Phẩm',N'Loại sản phẩm chứa các sản phẩm mỹ phẩm và làm đẹp')
,('LSP009',N'Đồ Gia Dụng',N'Loại sản phẩm chứa các sản phẩm gia dụng và đồ nội thất')
,('LSP010',N'Thực Phẩm Tươi',N'Loại sản phẩm chứa các sản phẩm thực phẩm tươi sống')


--ADD DATA SANPHAM
INSERT INTO SANPHAM (MaSP,TenSP, MaNCC, MaLoaiSP, GiaNhap, GiaBan, SoLuong, HanSuDung, DonViTinh,HinhAnh, TrangThai) VALUES
('SP001',N'Bánh Quy Hương Vị Socola','NCC001','LSP001','10000','15000','50','1Y',N'Hộp','banhquysocola.jpg',1)
,('SP002',N'Nước Ngọt Pepsi','NCC002','LSP002','8000','12000','30','1Y',N'Lon','nuocngotpepsi.jpg',1)
,('SP003',N'Gạo Tám Sáng','NCC003','LSP003','20000','25000','20','5M',N'Kg','gaotamsang.jpg',1)
,('SP004',N'Bột Ngọt Ajinomoto','NCC004','LSP004','5000','7000','40','1.5Y',N'Gói','botngotajinomoto.jpg',1)
,('SP005',N'Điện Thoại Smartphone Samsung','NCC005','LSP005','5000000','5500000','5','',N'Cái','dthsamsung.jpg',1)
,('SP006',N'Áo Thun Nam','NCC006','LSP006','120000','150000','10','',N'Cái','aothunnam.jpg',1)
,('SP007',N'Búp Bê Barbie','NCC007','LSP007','150000','200000','20','',N'Cái','bbbarbie.jpg',1)
,('SP008',N'Kem Chống Nắng SPF 50','NCC008','LSP008','200000','250000','12','2Y',N'Chai','kemchongnangspf_50.jpg',1)
,('SP009',N'Nồi Cơm Điện Tự Động','NCC009','LSP009','300000','350000','8','',N'Cái','noicomdien.jpg',1)
,('SP010',N'Rau Cải Xanh Tươi','NCC010','LSP010','20000','25000','30','2D',N'Kg','raucaixanh.jpg',1)
,('SP011',N'Bánh Bông Lan','NCC001','LSP001','30000','40000','40','7D',N'Hộp','banhbonglan.jpg',1)
,('SP012',N'Nước Suối Lavie','NCC002','LSP002','5000','7000','70','',N'Chai','nuoclavie.jpg',1)
,('SP013',N'Sữa Tươi Vinamilk','NCC003','LSP003','25000','30000','60','6M',N'Hủ','suavinamilk.jpg',1)
,('SP014',N'Tiêu Xanh','NCC004','LSP004','7000','10000','80','3M',N'Gói','tieuxanh.jpg',1)
,('SP015',N'Tai Nghe Bluetooth','NCC005','LSP005','300000','350000','10','',N'Cái','tainghebluetooth.jpg',1)
,('SP016',N'Áo Khoác Dù','NCC006','LSP006','250000','300000','20','',N'Cái','aokhoacdu.jpg',1)
,('SP017',N'Puzzle','NCC007','LSP007','100000','150000','15','',N'Hộp','puzzle.jpg',1)
,('SP018',N'Kem Dưỡng Da Neutrogena','NCC008','LSP008','150000','200000','8','3Y',N'Hũ','kemduongdaneutrogena.jpg',1)
,('SP019',N'Bình Đun Siêu Tốc','NCC009','LSP009','500000','600000','5','',N'Cái','binhdunsieutoc.jpg',1)
,('SP020',N'Dưa Hấu','NCC010','LSP010','15000','20000','40','4D',N'Kg','duahau.jpg',1)

--ADD DATA KHUYENMAI
INSERT INTO KHUYENMAI (MaKM, TenKM, GiaKhuyenMai, NgayBatDau, NgayKetThuc)  VALUES
('KM080324',N'Khuyến Mãi 8/3/2024','0.1','2024-03-06','2024-03-08')
,('KMGP24',N'Khuyến Mãi Ngày Giải Phóng 30/4/2024','0.2','2024-04-27','2024-05-2')
,('KMQK23',N'Khuyến Mãi Ngày Quốc Khánh 2/9/2023','0.2','2023-08-28','2023-09-04')
,('KMSN24',N'Khuyến Mãi Sinh Nhật Năm 24','0.15','2024-2-22','2024-2-22')

--ADD DATA HOADONBANHANG
INSERT INTO HOADONBANHANG (MaHD, MaNV, MaKH, NgayLapHD, TongTien, TienKhachDua, TienTraKhach) VALUES
('HD001','NV001','00001','2023-07-09 00:10:56','200000','300000','100000')
,('HD002','NV002','00002','2024-02-28 00:11:58','24000','50000','26000')
,('HD003','NV003','00003','2023-09-27 18:48:03','28000','30000','2000')
,('HD004','NV004','00004','2024-01-26 14:52:43','450000','500000','50000')
,('HD005','NV005','00005','2023-04-07 14:26:19','500000','500000','0')
,('HD006','NV006','00006','2022-10-28 03:54:20','75000','100000','25000')
,('HD007','NV007','00007','2023-03-24 13:26:11','70000','70000','0')
,('HD008','NV008','00008','2023-09-02 12:55:13','32000','50000','18000')
,('HD009','NV009','00009','2023-07-22 00:24:46','300000','500000','200000')
,('HD010','NV010','00010','2024-01-20 23:46:21','400000','500000','100000')


--ADD DATA CHITIETHOADONBANHANG
INSERT INTO CHITIETHOADONBANHANG (MaHD, MaSP, MaKM,SoLuong, DonGia, ThanhTien) VALUES
('HD001','SP020',null,5,20000,100000)
,('HD001','SP003',null,4,25000,100000)
,('HD002','SP002',null,2,12000,24000)
,('HD003','SP004',null,4,7000,28000)
,('HD004','SP006',null,3,150000,450000)
,('HD005','SP008',null,2,250000,500000)
,('HD006','SP010',null,3,25000,75000)
,('HD007','SP012',null,10,7000,70000)
,('HD008','SP014','KMQK23',4,10000,32000)
,('HD009','SP016',null,1,300000,300000)
,('HD010','SP018',null,2,200000,400000)


--ADD DATA HOADONNHAPKHO
INSERT INTO HOADONNHAPKHO (MaNK, NgayNhapKho, MaNV, MaNCC, TongTien) VALUES
('NK001','2023-05-04 04:50:10','NV001','NCC002',3300000)
,('NK002','2022-10-13 05:21:55','NV002','NCC003',2840000)
,('NK003','2024-01-17 06:00:42','NV003','NCC001',285500000)
,('NK004','2023-05-28 09:59:04','NV004','NCC004',17520000)
,('NK005','2022-11-23 22:14:42','NV005','NCC002',25000000)
,('NK006','2022-11-26 02:25:39','NV006','NCC003',1500000)
,('NK007','2023-11-22 15:35:09','NV007','NCC001',1100000)
,('NK008','2023-08-13 12:16:43','NV008','NCC004',1700000)
,('NK009','2023-12-26 05:29:38','NV009','NCC002',1400000)
,('NK010','2023-12-05 16:35:18','NV010','NCC003',1600000)

--ADD DATA CHITIETHOADONNHAPKHO
INSERT INTO CHITIETHOADONNHAPKHO(MaNK, MaSP, SoLuong, DonGiaNhap, ThanhTien) VALUES
('NK001','SP001',100,10000,1000000)
,('NK001','SP002',150,8000,1200000)
,('NK002','SP003',80,20000,1600000)
,('NK002','SP004',120,5000,600000)
,('NK003','SP005',50,5000000,250000000)
,('NK003','SP006',70,120000,8400000)
,('NK004','SP007',30,150000,4500000)
,('NK004','SP008',45,200000,9000000)
,('NK005','SP009',65,300000,19500000)
,('NK005','SP010',90,20000,1800000)
