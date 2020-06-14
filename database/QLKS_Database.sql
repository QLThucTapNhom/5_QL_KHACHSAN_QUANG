create database QLKS
go 
use QLKS
go

CREATE TABLE QUYEN(
     MaQuyen int primary key ,
	 TenQuyen nvarchar(50)

)

CREATE TABLE NHANVIEN(
      MaNV nvarchar(20) primary key,
	  HoTenNV nvarchar(50),
	  CMND nchar(15),
	  NgaySinh date,
	  GioiTinh nvarchar(3),
	  SDT nchar(10),
	  DiaChi nvarchar(50),
	  ChucVu nvarchar(50),
	  
)

CREATE TABLE TAIKHOAN
(
     
     ID INT IDENTITY PRIMARY KEY ,
	 TenDangNhap nvarchar(50),
	 MatKhau NVARCHAR(50) NOT NULL,
	 MaQuyen INT REFERENCES QUYEN(MaQuyen),
	 MaNV NVARCHAR(20) REFERENCES NHANVIEN(MaNV)
)
 

CREATE TABLE KHACHHANG(
       MaKH INT IDENTITY primary key,
	   TenKH nvarchar(50),
	   CMND nchar(15),
	   SDT nchar(10)
)

CREATE TABLE LOAIPHONG
(
      MaLoaiPhong nvarchar(20) primary key,
	  TenLoaiPhong nvarchar(50),
	  DonGia MONEY,
	  SoNgToiDa INT
)

CREATE TABLE PHONG
(
      MaPhong nvarchar(20) primary key,
	  TenPhong nchar(10),
	  MaLoaiPhong nvarchar(20) references LOAIPHONG(MaLoaiPhong),
	  TrangThai nchar(10)
)


CREATE TABLE DICHVU
(
      MaDV nvarchar(20) primary key,
	  TenDV nvarchar(50) ,
	  GiaDV money,
	 
)
CREATE TABLE THIETBI(
       MaTB nvarchar(20) primary key,
	   TenTB nvarchar(50),
)
CREATE TABLE THIETBI_SD(
	   MaPhong nvarchar(20) references PHONG(MaPhong),
	   MaTB nvarchar(20) references THIETBI(MaTB),
	   primary key (MaPhong, MaTB) ,
	   SoLuong INT,
	   TrangThai NVARCHAR(50)
)



CREATE TABLE PHIEUTHUEPHONG
(
     MaPhieu INT IDENTITY primary key,
	 MaKH INT references KHACHHANG(MaKH),
	 MaNV nvarchar(20) references NHANVIEN(MaNV),
	 MaPhong nvarchar(20) references PHONG(MaPhong),
	 NgayNhanPhong datetime,
	 TienDatCoc MONEY,
	 )


CREATE TABLE DICHVU_SD(
	   MaPhieu int references PHIEUTHUEPHONG(MaPhieu),
	   MaDV nvarchar(20) references DICHVU(MaDV),
	   primary key (MaPhieu,MaDV),
	   SoLuong int,  
)

CREATE TABLE HOADON(
           MaHD INT IDENTITY primary key,
           MaKH int references KHACHHANG(MaKH),
 	   MaPhieu int references PHIEUTHUEPHONG(MaPhieu),
	   MaNV nvarchar(20) references NHANVIEN(MaNV),
	   NgayLap datetime,
	   NgayNhan DATETIME,
	   NgayTra DATETIME,
	   TienPhong money,
	   TienDV money,
	   TongTien money
)

	
INSERT INTO QUYEN Values(1,N'Quản Lý'),
                         (2,N'Lễ Tân')

INSERT INTO NHANVIEN Values('1',N'Nguyễn Mạnh Quang','17150173','1999/08/20','Nam','0983467832',N'Hà Nội',N'Quản Lý')

INSERT INTO TAIKHOAN VALUES('admin','123',1,'1')    
                   
INSERT INTO KHACHHANG VALUES (N'Vũ Minh Quang','123456789','0353485333')		

INSERT INTO LOAIPHONG VALUES ('1',N'Phòng 1 người', 300000, 1)
INSERT INTO LOAIPHONG VALUES ('2',N'Phòng 2 người', 500000, 2),
							  ('3',N'Phòng 3 người', 700000, 3),
							  ('4',N'Phòng 4 người', 900000, 4)

							
INSERT INTO PHONG VALUES  ('P101','P101','1',N'Trống'),
                          ('P102','P102','1',N'Trống'),
						  ('P103','P103','4',N'Trống'),
						  ('P104','P104','3',N'Trống'),
						  ('P201','P201','2',N'Trống'),
						  ('P202','P202','2',N'Trống'),
						  ('P203','P203','3',N'Trống'),
						  ('P204','P204','4',N'Trống'),
						  ('P301','P301','4',N'Trống')
INSERT INTO DICHVU VALUES ('DV01',N'Mỳ gói',5000),
                           ('DV02',N'Nước ngọt',10000),
						   ('DV03',N'Spa',100000),
						   ('DV04',N'Giặt là',100000),
						   ('DV05',N'Xe đưa đón',500000)
INSERT INTO THIETBI VALUES ('TB01',N'Ti vi'),
                            ('TB02',N'Điều hòa'),
							('TB03',N'Nóng lạnh'),
							('TB04',N'Quạt')

