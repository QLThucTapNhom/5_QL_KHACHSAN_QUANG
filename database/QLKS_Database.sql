﻿CREATE DATABASE QLKHACHSAN

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
	   TienPhong money,
	   TienDV money,
	   TongTien money
)
CREATE TABLE PHIEUTHUEPHONG
(
     MaPhieu INT IDENTITY primary key,
	 MaKH INT references KHACHHANG(MaKH),
	 MaPhong nvarchar(20) references PHONG(MaPhong),
	 NgayNhanPhong datetime,
	 TienDatCoc MONEY,
	 )


INSERT INTO QUYEN Values(1,N'Quản Lý'),
                         (2,N'Lễ Tân')

INSERT INTO NHANVIEN Values('1',N'Đồng Văn Hùng','17150123','1999/08/20','Nam','0983467832',N'Hà Nội',N'Quản Lý')

INSERT INTO TAIKHOAN VALUES('admin','123',1,'1')    
                   
INSERT INTO KHACHHANG VALUES (N'Nguyễn Mạnh Quang','12345','0353485333')		

INSERT INTO LOAIPHONG VALUES ('1',N'Phòng 1 người', 300000, 1)
INSERT INTO LOAIPHONG VALUES ('2',N'Phòng 2 người', 500000, 2),
							  ('3',N'Phòng 3 người', 700000, 3),
							  ('4',N'Phòng 4 người', 900000, 4)

INSERT INTO PHONG VALUES  ('P101','P101','1',N'Thuê'),
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
INSERT INTO THIETBI_SD VALUES ('P01','TB01',1,N'Tốt'),
                              ('P01','TB02',1,N'Tốt'),
							  ('P01','TB03',1,N'Tốt'),
							  ('P01','TB04',1,N'Tốt')
                                                      

INSERT INTO PHIEUTHUEPHONG VALUES('1','P101','2020/05/05 8:00:00','200000') 


INSERT INTO DICHVU_SD VALUES ('P101','DV01',1)
INSERT INTO DICHVU_SD VALUES ('P101','DV02',3)


--INSERT INTO HOADON VALUES('1','1','2020/05/07 9:00:00','2020/05/05 9:00:00','2020/05/07 9:00:00',200000,850000)  


--"SELECT*FROM dbo.NHANVIEN WHERE  MaNV like'%"+"+%' OR HoTenNV LIKE '%"++"%' OR CMND LIKE '%"++"%'OR SDT LIKE '%"++"%'OR HoTenNV LIKE '%"++"%'OR DiaChi LIKE '%"++"%'OR ChucVu LIKE '%"++"%'"

--INSERT INTO HOADON VALUES('1','P01','1','2020/05/07 9:00:00','2020/05/05 9:00:00','2020/05/07 9:00:00',200000,850000)  

-- Thủ tục liên quan
-- create proc Xoa_DV @MaDV nvarchar(20)
-- as
-- begin
-- delete from DICHVU where MaDV = @MaDV
-- delete from DICHVU_SD where MaDV = @MaDV
-- end