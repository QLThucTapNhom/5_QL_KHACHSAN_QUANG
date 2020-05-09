CREATE DATABASE QLKHACHSAN

USE QLKHACHSAN


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
	  GiaTheoGio MONEY,
      GiaTheoNgay MONEY,
	  SoNguoi INT
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
CREATE TABLE DICHVU_SD(
	   MaPhong nvarchar(20) references PHONG(MaPhong),
	   MaDV nvarchar(20) references DICHVU(MaDV),
	   primary key (MaPhong,MaDV),
	   SoLuong int,
	  
)

CREATE TABLE HOADON(
       MaHD INT IDENTITY primary key,
	   MaKH int references KHACHHANG(MaKH),
	   MaPhong nvarchar(20) references PHONG(MaPhong),
	   MaNV nvarchar(20) references NHANVIEN(MaNV),
	   NgayLap datetime,
	   NgayNhan DATETIME,
	   NgayTra DATETIME,
	   TienDV money,
	   TongTien money
)
CREATE TABLE PHIEUTHUEPHONG
(
     MaPhieu INT IDENTITY primary key,
	 MaKH INT references KHACHHANG(MaKH),
	 MaPhong nvarchar(20) references PHONG(MaPhong),
	 NgayNhanPhong datetime,
	 )


INSERT INTO QUYEN Values(1,N'Quản Lý'),
                         (2,N'Lễ Tân')

INSERT INTO NHANVIEN Values('1',N'Đồng Văn Hùng','17150123','1999/08/20','Nam','0983467832',N'Hà Nội',N'Quản Lý')

INSERT INTO TAIKHOAN VALUES('admin','123',1,'1')    
                   
INSERT INTO KHACHHANG VALUES (N'Nguyễn Mạnh Quang','12345','0353485333')		

INSERT INTO LOAIPHONG VALUES ('1',N'Phòng 1 người',80000,300000,1)
INSERT INTO LOAIPHONG VALUES ('2',N'Phòng 2 người',150000,5000000,2),
							  ('3',N'Phòng 3 người',2000000, 7000000,3),
							  ('4',N'Phòng 4 người',300000, 1000000,4)

INSERT INTO PHONG VALUES  ('P01','P101','1',N'Thuê'),
                          ('P02','P102','1',N'Trống'),
						  ('P03','P103','4',N'Trống'),
						  ('P04','P104','3',N'Trống'),
						  ('P05','P201','2',N'Trống'),
						  ('P06','P202','2',N'Trống'),
						  ('P07','P203','3',N'Trống'),
						  ('P08','P204','4',N'Trống'),
						  ('P09','P301','4',N'Trống')
INSERT INTO DICHVU VALUES ('DV01',N'Mỳ gói',5000),
                           ('DV02',N'Nước ngọt',10000),
						   ('DV03',N'Spa',100000),
						   ('DV04',N'Giặt là',100000),
						   ('DV05',N'Xe đưa đón',500000)
INSERT INTO THIETBI VALUES ('TB01',N'Ti vi'),
                            ('TB02',N'Điều hòa'),
							('TB03',N'Nóng lạnh'),
							('TB04',N'Quạt')
INSERT INTO THIETBI_SD VALUES ('P01','TB01',1,N'Tốt'),
                              ('P01','TB02',1,N'Tốt'),
							  ('P01','TB03',1,N'Tốt'),
							  ('P01','TB04',1,N'Tốt')
                                                      

INSERT INTO PHIEUTHUEPHONG VALUES('1','P01','2020/05/05 8:00:00') 


INSERT INTO DICHVU_SD VALUES ('P01','DV01',1)
INSERT INTO DICHVU_SD VALUES ('P01','DV02',3)

<<<<<<< HEAD
INSERT INTO HOADON VALUES('1','1','2020/05/07 9:00:00','2020/05/05 9:00:00','2020/05/07 9:00:00',200000,850000)  


--"SELECT*FROM dbo.NHANVIEN WHERE  MaNV like'%"+"+%' OR HoTenNV LIKE '%"++"%' OR CMND LIKE '%"++"%'OR SDT LIKE '%"++"%'OR HoTenNV LIKE '%"++"%'OR DiaChi LIKE '%"++"%'OR ChucVu LIKE '%"++"%'"
=======
INSERT INTO HOADON VALUES('1','P01','1','2020/05/07 9:00:00','2020/05/05 9:00:00','2020/05/07 9:00:00',200000,850000)  

>>>>>>> ee35ca4cf6b61d380626083b87af9576f4fc387a
