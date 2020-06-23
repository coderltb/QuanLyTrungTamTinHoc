CREATE DATABASE QL_TRUNGTAMCNTT
go
--drop database QL_TRUNGTAMCNTT
USE QL_TRUNGTAMCNTT
GO
CREATE TABLE KHOAHOC
(
	MAKH INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	TENKH NVARCHAR(100) , -- ĐK UNIQUE
	SOLUONGHVTD INT, -- SỐ LƯỢNG HỌC VIÊN TỐI ĐA
	THOILUONG INT, 		-- TÍNH THEO GIỜ
	SOLUONGHVTT INT, -- SỐ LƯỢNG HỌC VIÊN TỐI THIỂU
)

GO
CREATE TABLE PHONGHOC
(
	MAPH INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	TENPH NVARCHAR(100) , -- ĐK UNIQUE
	SOLUONG INT,
)

GO
CREATE TABLE GIANGVIEN
(
	MAGV INT PRIMARY KEY NOT NULL,
	TENGV NVARCHAR(100),
	NAMSINH DATE,
	DIACHI NVARCHAR(MAX),
	SDT CHAR(10),
	TRINHDO NVARCHAR(50),
)

GO

create table DotKhaiGiang
(
	MaDotKhaiGiang int identity(1,1) primary key not null,
	TenDotKhaiGiang nvarchar(250)
)
go

CREATE TABLE ttUser
(
	MaUser int identity(1,1) primary key not null,
	Username varchar(30),
	Pwd varchar(30),
	SDT varchar(11),
	Email varchar(50),
	IsAdmin bit
)
go

CREATE TABLE LOPHOC 
(
	MALH INT IDENTITY(1,1) PRIMARY KEY NOT NULL ,
	MAPH INT,
	MAKH INT,
	MAGV INT,
	MOLOP BIT,
	TIETHOC NVARCHAR(50),
	LICHKHAIGIANG DATE, -- LỊCH KHAI GIẢNG
	LICHKETTHUC DATE, -- LỊCH KẾT THÚC
	TINHTRANG NVARCHAR(100),
	SOLUONG INT,
	MaDotKhaiGiang int
	CONSTRAINT FK_LH_PH_MAPH FOREIGN KEY(MAPH) REFERENCES PHONGHOC(MAPH),
	CONSTRAINT FK_LH_KH_MAKH FOREIGN KEY(MAKH) REFERENCES KHOAHOC(MAKH),
	CONSTRAINT FK_LH_DotKhaiGiang_MaDotKhaiGiang FOREIGN KEY(MaDotKhaiGiang) REFERENCES DotKhaiGiang(MaDotKhaiGiang),
	CONSTRAINT FK_LH_GV_MAHV FOREIGN KEY(MAGV) REFERENCES GIANGVIEN(MAGV)
)
--drop table LOPHOC
select * from LOPHOC
GO
CREATE TABLE HOCVIEN 
(
	MAHV INT  identity(1,1) PRIMARY KEY NOT NULL,
	MALH INT,
	TENHV NVARCHAR(100),
	NAMSINH DATE,
	DIACHI NVARCHAR(MAX),
	NGHENGHIEP NVARCHAR(100),
	TINHTRANG NVARCHAR(100),
	SDT CHAR(10),
	CONSTRAINT FK_HV_LH_MALH FOREIGN KEY(MALH) REFERENCES LOPHOC(MALH)
)


GO
CREATE TABLE BAOLUU
(
	MABL INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	MALH INT,
	MAHV INT,
	THOIGIANBATDAUBAOLUU DATE, -- THỜI GIAN BẮT ĐẦU BẢO LƯU
	THOIGIANKETTHUCBAOLUU DATE, -- THỜI GIAN KẾT THÚC BẢO LƯU
	SOTIENBAOLUU FLOAT, -- SỐ TIỀN BẢO LƯU -- tính bằng Triệu
	CONSTRAINT FK_BL_LH FOREIGN KEY(MALH) REFERENCES LOPHOC(MALH),
	CONSTRAINT FK_BL_HV FOREIGN KEY(MAHV) REFERENCES HOCVIEN(MAHV)
)
--drop table BAOLUU

	
GO
CREATE TABLE CONGNO
(
	MALH INT,
	MABL INT,
	NOIDUNGTHU NVARCHAR(MAX), -- NỘI DUNG THU
	HOCPHI FLOAT,
	SOTIENNOP FLOAT, -- SỐ TIỀN NỘP
	SOTIENCONLAI FLOAT,
	SODU FLOAT,
	TRANGTHAI NVARCHAR(MAX),
	CONSTRAINT PK_CONGNO PRIMARY KEY(MALH, MABL),
	CONSTRAINT FK_CN_LH FOREIGN KEY(MALH) REFERENCES LOPHOC(MALH),
	CONSTRAINT FK_CN_BL FOREIGN KEY(MABL) REFERENCES BAOLUU(MABL)
)
--drop table CONGNO




--ĐIỀU KIỆN BẢNG KHÓA HỌC
GO
ALTER TABLE KHOAHOC
ADD CONSTRAINT CHK_SOLUONGHVTT CHECK(SOLUONGHVTD >= 6)

GO
ALTER TABLE KHOAHOC
ADD CONSTRAINT CHK_SOLUONGHVTD CHECK(SOLUONGHVTD <= 30)

GO 
ALTER TABLE KHOAHOC
ADD CONSTRAINT UNI_TENKH UNIQUE(TENKH)

-- ĐIỀU KIỆN BẢNG PHÒNG HỌC
GO 
ALTER TABLE PHONGHOC
ADD CONSTRAINT UNI_TENPG UNIQUE(TENPH)


--ĐIỀU KIỆN BẢNG LỚP HỌC
GO
ALTER TABLE LOPHOC 
ADD CONSTRAINT CHK_LICHKG_LICHKT CHECK(DATEDIFF(DAY, LICHKHAIGIANG, LICHKETTHUC) > 0)

-- ĐIỀU KIỆN BẢNG BẢO LƯU
GO
ALTER TABLE BAOLUU
ADD CONSTRAINT CHK_TGBDBAOLUU_TGKTBAOLUU CHECK(DATEDIFF(DAY, THOIGIANBATDAUBAOLUU, THOIGIANKETTHUCBAOLUU) > 0)

GO 
ALTER TABLE BAOLUU
ADD CONSTRAINT CHK_SOTIENBAOLUU CHECK(SOTIENBAOLUU > 0)

-- ĐIỀU KIỆN BẢNG CÔNG NỢ
GO
ALTER TABLE CONGNO
ADD CONSTRAINT CHK_HOCPHI CHECK(HOCPHI > 0 AND SOTIENNOP > 0)

--ĐIỀU KIỆN BẢNG HỌC VIÊN
GO 
ALTER TABLE HOCVIEN
ADD CONSTRAINT DEF_TINHTRANG  DEFAULT 'Đang học' FOR TINHTRANG
--Nhập liệu

	INSERT INTO KHOAHOC VALUES(N'Lập trình web php',30,40,10);
	INSERT INTO KHOAHOC VALUES(N'Java sping',30,30,10);
	INSERT INTO KHOAHOC VALUES(N'Lập trình web với HTML,CSS,Javascript',30,40,10);
	INSERT INTO KHOAHOC VALUES(N'Công nghệ blockchain',30,30,10);
	INSERT INTO KHOAHOC VALUES(N'Lập trình .NET',30,40,10);
	INSERT INTO KHOAHOC VALUES(N'Phân tích dữ liệu',30,30,10);
	INSERT INTO KHOAHOC VALUES(N'Khai phá dữ liệu',30,40,10);
	INSERT INTO KHOAHOC VALUES(N'Ảo hoá ,điện toán đám mây',30,30,10);
	INSERT INTO KHOAHOC VALUES(N'ReactJs từ cơ bản đến nâng cao',30,40,10);
	INSERT INTO KHOAHOC VALUES(N'Nodejs và Vuejs',30,30,10);
	INSERT INTO KHOAHOC VALUES(N'Cơ sở dữ liệu Oracle và phân tích dữ liệu',30,40,10);
	INSERT INTO KHOAHOC VALUES(N'Công nghệ java',30,30,10);
	INSERT INTO KHOAHOC VALUES(N'Làm game với Unity',30,40,10);
	INSERT INTO KHOAHOC VALUES(N'Làm game từ cơ bản đến nâng cao với C++',30,30,10);
	INSERT INTO KHOAHOC VALUES(N'Lập trình android cơ bản',30,40,10);
	GO
	SELECT * FROM KHOAHOC
	
	
	INSERT INTO PHONGHOC VALUES (N'PH203',50);
	INSERT INTO PHONGHOC VALUES (N'PH23',40);
	INSERT INTO PHONGHOC VALUES (N'PH201',50);
	INSERT INTO PHONGHOC VALUES (N'PH102',40);
	INSERT INTO PHONGHOC VALUES (N'PH200',50);
	INSERT INTO PHONGHOC VALUES (N'PH101',40);
	INSERT INTO PHONGHOC VALUES (N'PH202',50);
	INSERT INTO PHONGHOC VALUES (N'PH222',40);
	INSERT INTO PHONGHOC VALUES (N'PH21',50);
	INSERT INTO PHONGHOC VALUES (N'PH13',40);
	INSERT INTO PHONGHOC VALUES (N'PH15',50);
	INSERT INTO PHONGHOC VALUES (N'PH205',40);
	INSERT INTO PHONGHOC VALUES (N'PH106',50);
	INSERT INTO PHONGHOC VALUES (N'PH104',40);
	INSERT INTO PHONGHOC VALUES (N'PH111',40);
	GO
	SELECT * FROM PHONGHOC
	
	
	INSERT INTO GIANGVIEN VALUES (1, N'Nguyễn Thanh Nhi','1992',N'120 Nguyễn Văn Quá,quân 3,Tp Hồ Chí Minh','0252541793',N'Tiến sĩ');
	INSERT INTO GIANGVIEN VALUES (2, N'Trần Thanh Cảnh','1986',N'100 Nguyễn Thượng Hiền,quân 3,Tp Hồ Chí Minh','0352541725',N'Thạc sĩ');
	INSERT INTO GIANGVIEN VALUES (3, N'Trinh Văn Thanh','1992',N'135 Nguyễn Văn Quá,quân 3,Tp Hồ Chí Minh','0483511763',N'Thạc sĩ');
	INSERT INTO GIANGVIEN VALUES (4, N'Trần Yến Loan','1993',N'164 Điện Biên Phủ,quân 3,Tp Hồ Chí Minh','0252541747',N'Tiến sĩ');
	INSERT INTO GIANGVIEN VALUES (5, N'Nguyễn Văn Cẩn','1975',N'14 Nguyễn Thượng Hiền,quân 3,Tp Hồ Chí Minh','0252541735',N'Giáo sư');
	INSERT INTO GIANGVIEN VALUES (6, N'Nguyễn Thị Kim Yến','1988',N'260 Hải Thượng Lãng Ông,quân 1,Tp Hồ Chí Minh','0222541799',N'Thạc sĩ');
	INSERT INTO GIANGVIEN VALUES (7, N'Nguyễn Kim Nhi','1991',N'13 Hoàng Sa,quân 3,Tp Hồ Chí Minh','0122541796',N'Tiến sĩ');
	INSERT INTO GIANGVIEN VALUES (8, N'Trần Đức Phú','1993',N'61 Nguyễn Trãi,quân 1,Tp Hồ Chí Minh','0462541785',N'Tiến sĩ');
	INSERT INTO GIANGVIEN VALUES (9, N'Vũ Văn Tài','1989',N'65 Lê Văn Sĩ,quân 3,Tp Hồ Chí Minh','0392541766',N'Phó giáo sư');
	INSERT INTO GIANGVIEN VALUES (10, N'Mai Thanh Trúc','1987',N'123 Điên Biên Phủ,quân 3,Tp Hồ Chí Minh','0152544875',N'Tiến sĩ');
	INSERT INTO GIANGVIEN VALUES (11, N'Trần Thị Nũ','1992',N'351 Nguyễn Văn Quá,quân 3,Tp Hồ Chí Minh','0572541357',N'Phó giáo sư');
	INSERT INTO GIANGVIEN VALUES (12, N'Trần Thái Tú','1993',N'33 Lê Văn Sĩ,quân 3,Tp Hồ Chí Minh','0552541647',N'Tiến sĩ');
	INSERT INTO GIANGVIEN VALUES (13, N'Vũ Văn Tài','1986',N'615 Hoàng Sa 3,Tp Hồ Chí Minh','0352541965',N'Thạc sĩ');
	INSERT INTO GIANGVIEN VALUES (14, N'Vũ Thị Thanh Thuý','1995',N'512 Nguyễn Văn Quá,quân 3,Tp Hồ Chí Minh','0472541728',N'Tiến sĩ');
	INSERT INTO GIANGVIEN VALUES (15, N'Nguyễn Thanh Hoàng','1993',N'352 Nguyễn Văn Quá,quân 3,Tp Hồ Chí Minh','0632541798',N'Tiến sĩ');
	GO
	SELECT * FROM GIANGVIEN
GO
	insert into DotKhaiGiang values(N'Đợt 1 2019')
	insert into DotKhaiGiang values(N'Đợt 2 2019')
	insert into DotKhaiGiang values(N'Đợt 3 2019')
	insert into DotKhaiGiang values(N'Đợt 1 2018')
	insert into DotKhaiGiang values(N'Đợt 2 2018')
	insert into DotKhaiGiang values(N'Đợt 3 2018')
	insert into DotKhaiGiang values(N'Đợt 1 2017')
	insert into DotKhaiGiang values(N'Đợt 2 2017')
	insert into DotKhaiGiang values(N'Đợt 3 2017')
	insert into DotKhaiGiang values(N'Đợt 1 2016')
	insert into DotKhaiGiang values(N'Đợt 2 2016')
	insert into DotKhaiGiang values(N'Đợt 3 2016')
	insert into DotKhaiGiang values(N'Đợt 1 2015')
	insert into DotKhaiGiang values(N'Đợt 2 2015')
	insert into DotKhaiGiang values(N'Đợt 3 2015')
	insert into DotKhaiGiang values(N'Đợt 1 2014')
	insert into DotKhaiGiang values(N'Đợt 2 2014')
	insert into DotKhaiGiang values(N'Đợt 3 2014')
	insert into DotKhaiGiang values(N'Đợt 1 2013')
	insert into DotKhaiGiang values(N'Đợt 2 2013')
	insert into DotKhaiGiang values(N'Đợt 3 2013')
	insert into DotKhaiGiang values(N'Đợt 1 2012')
	insert into DotKhaiGiang values(N'Đợt 2 2012')
	insert into DotKhaiGiang values(N'Đợt 3 2012')
	insert into DotKhaiGiang values(N'Đợt 1 2011')
	insert into DotKhaiGiang values(N'Đợt 2 2011')
	insert into DotKhaiGiang values(N'Đợt 3 2011')

	insert into ttUser values ('LongAdmin', '123', '0902123456', 'longtb@gmail.com', 1)
	insert into ttUser values ('TrinhAdmin', '123', '0903456789', 'trinhnk@gmail.com', 1)
	insert into ttUser values ('TuanAdmin', '123', '0904123456', 'tuanntg@gmail.com', 1)
	insert into ttUser values ('NguyenVanA', '123', '0909000777', 'anv@gmail.com', 0)
	insert into ttUser values ('NgoThiB', '123', '0907999777', 'bnt@gmail.com', 0)
	insert into ttUser values ('HaVanC', '123', '0901365489', 'cvh@gmail.com', 0)
-- Cần phải thay đổi lại khoá chính
GO
	SET DATEFORMAT DMY
	
	INSERT INTO LOPHOC VALUES (1, 5, 9, 1, '9h - 11h (3,5,7)','11/08/2015','11/10/2015',N'CÒN',40,15)
	INSERT INTO LOPHOC VALUES (2, 1, 15, 0, '14h - 16h (2,4,6)','11/08/2015','11/10/2015',N'CÒN',40,15)
	INSERT INTO LOPHOC VALUES (3, 2, 14, 1, '17h - 19h (2,4,6)','11/08/2015','11/10/2015',N'CÒN',40,15)
	INSERT INTO LOPHOC VALUES (4, 4, 13, 1, '19h - 21h (3,5,7)','11/08/2015','11/10/2015',N'CÒN',40,15)
	INSERT INTO LOPHOC VALUES (15, 6, 10, 0, '9h - 11h (2,4,6)','11/08/2015','11/10/2015',N'CÒN',40,15)
	INSERT INTO LOPHOC VALUES (6, 7, 7, 0, '7h - 9h (3,5,7)','11/08/2015','11/10/2015',N'CÒN',40,15)
	INSERT INTO LOPHOC VALUES (7, 3, 5, 1, '19h - 21h (2,4,6)','11/08/2015','11/10/2015',N'CÒN',40,15)
	INSERT INTO LOPHOC VALUES (8, 13, 4, 0, '17h - 19h (3,5,7)','11/08/2015','11/10/2015',N'CÒN',40,15)
	INSERT INTO LOPHOC VALUES (10, 12, 3, 0, '9h - 11h (2,4,6)','11/08/2015','11/10/2015',N'CÒN',40,15)
	INSERT INTO LOPHOC VALUES (9, 10, 6, 0, '7h - 9h (2,4,6)','11/08/2015','11/10/2015',N'CÒN',40,15)
	INSERT INTO LOPHOC VALUES (5, 11, 8, 1, '17h - 19h (2,4,6)','11/08/2015','11/10/2015',N'CÒN',40,15)
	INSERT INTO LOPHOC VALUES (12, 14, 1, 1, '19h - 21h (2,4,6)','11/08/2015','11/10/2015',N'CÒN',40,15)
	INSERT INTO LOPHOC VALUES (11, 8, 2, 0, '14h - 16h (3,5,7)','11/08/2015','11/10/2015',N'CÒN',40,15)
	INSERT INTO LOPHOC VALUES (13, 9, 12, 1, '9h - 11h (2,4,6)','11/08/2015','11/10/2015',N'CÒN',40,15)

	GO
	SELECT * FROM LOPHOC

	--DELETE FROM LOPHOC
	SET DATEFORMAT DMY
	INSERT INTO HOCVIEN VALUES ( 1, N'Nguyễn Văn Thành','12/05/1996',N'120 Trần Văn Ơn',N'Sinh viên',N'Đang học','0352981488');
	INSERT INTO HOCVIEN VALUES ( 2,N'Trần Thiên Lý','12/08/1986',N'120 Ngô Tài',N'Sinh viên',N'Đang học','03529841');
	INSERT INTO HOCVIEN VALUES ( 3,N'Nguyễn Thị Thuý','1/05/1988',N'120 Trần Văn Tài',N'Sinh viên',N'Đang học','0365881488');
	INSERT INTO HOCVIEN VALUES ( 4,N'Nguyễn Thành','17/02/1995',N'120 Nguyễn Thanh Tú',N'Sinh viên',N'Đang học','0352981165');
	INSERT INTO HOCVIEN VALUES ( 5,N'Nguyễn Văn Tài','21/1/1993',N'100 Nguyễn Cảnh Chân',N'Sinh viên',N'Đang học','0352981751');
	INSERT INTO HOCVIEN VALUES ( 6,N'Trần Thanh Thuý','25/3/1989',N'10 Trần Văn Ơn',N'Sinh viên',N'Đang học','0352981684');
	INSERT INTO HOCVIEN VALUES ( 7,N'Trần Nhân Lý','14/4/1994',N'140 Trần Văn Ơn',N'Sinh viên',N'Đang học','0352981948');
	INSERT INTO HOCVIEN VALUES ( 8,N'Nguyễn Thanh Mai','3/5/1995',N'18 Điện Biên Phủ',N'Sinh viên',N'Đang học','0352981781');
	INSERT INTO HOCVIEN VALUES ( 9,N'Vũ Văn Việt','14/2/1992',N'13 Trần Văn Ơn',N'Sinh viên',N'Đang học','0352981781');
	INSERT INTO HOCVIEN VALUES ( 10,N'Ngô Xuân Tài','1/1/1991',N'15 Trần Cảnh Chân',N'Sinh viên',N'Đang học','0352981812');
	INSERT INTO HOCVIEN VALUES ( 11,N'Võ Tấn Kiệt','12/7/1995',N'25 Trần Văn Ơn',N'Sinh viên',N'Đang học','0352981748');
	INSERT INTO HOCVIEN VALUES ( 12,N'Nguyễn Nhân','3/6/1996',N'25 Lê Văn Sỹ',N'Sinh viên',N'Đang học','0352981915');
	INSERT INTO HOCVIEN VALUES ( 13,N'Nguyễn Thành Thái','24/4/1989',N'120 Trần Văn Ơn',N'Sinh viên',N'Đang học','0352981818');
	INSERT INTO HOCVIEN VALUES ( 14,N'Nguyễn Kim Yến','6/8/1994',N'114 Trần Văn Ơn',N'Sinh viên',N'Đang học','0352981722');
	INSERT INTO HOCVIEN VALUES ( 2,N'Nguyễn Văn Tâm','11/3/1993',N'112 Trần Văn Ơn',N'Sinh viên',N'Đang học','0352981684');
	INSERT INTO HOCVIEN VALUES ( 3,N'Trần Thiên Lý','12/08/1986',N'120 Ngô Tài',N'Sinh viên',N'Đang học','03529841');
	INSERT INTO HOCVIEN VALUES ( 1,N'Nguyễn Văn Tâm','11/3/1993',N'112 Trần Văn Ơn',N'Sinh viên',N'Đang học','0352981684');
	INSERT INTO HOCVIEN VALUES ( 1,N'Nguyễn Văn Tâm','11/3/1993',N'112 Trần Văn Ơn',N'Sinh viên',N'Đang học','0352981684');
	INSERT INTO HOCVIEN VALUES ( 5,N'Trần Thiên Lý','12/08/1986',N'120 Ngô Tài',N'Sinh viên',N'Đang học','03529841');
	INSERT INTO HOCVIEN VALUES ( 1,N'Vũ Văn Việt','14/2/1992',N'13 Trần Văn Ơn',N'Sinh viên',N'Đang học','0352981781');
	INSERT INTO HOCVIEN VALUES ( 1,N'Ngô Xuân Tài','1/1/1991',N'15 Trần Cảnh Chân',N'Sinh viên',N'Đang học','0352981812');
	INSERT INTO HOCVIEN VALUES ( 2,N'Ngô Xuân Tài','1/1/1991',N'15 Trần Cảnh Chân',N'Sinh viên',N'Đang học','0352981812');
	GO
	SELECT * FROM HOCVIEN
	
	DBCC CHECKIDENT ('[BAOLUU]', RESEED, 0);

	INSERT INTO BAOLUU VALUES (1,8,'12/05/2016','3/2/2017',500000);
	INSERT INTO BAOLUU VALUES (2,9,'12/05/2016','3/2/2017',250000);
	INSERT INTO BAOLUU VALUES (3,10,'12/05/2016','3/2/2017',500000);
	INSERT INTO BAOLUU VALUES (6, 11,'12/05/2016','3/2/2017',500000);
	INSERT INTO BAOLUU VALUES (5, 12,'12/05/2016','3/2/2017',250000);
	INSERT INTO BAOLUU VALUES (4, 9,'12/05/2016','3/2/2017',250000);
	INSERT INTO BAOLUU VALUES (7, 7,'12/05/2016','3/2/2017',250000);
	INSERT INTO BAOLUU VALUES (14, 8,'12/05/2016','3/2/2017',500000);
	INSERT INTO BAOLUU VALUES (10, 1,'12/05/2016','3/2/2017',500000);
	INSERT INTO BAOLUU VALUES (11,10,'12/05/2016','3/2/2017',500000);
	INSERT INTO BAOLUU VALUES (12, 4,'12/05/2016','3/2/2017',250000);
	INSERT INTO BAOLUU VALUES (13, 5,'12/05/2016','3/2/2017',500000);
	INSERT INTO BAOLUU VALUES (9, 2,'12/05/2016','3/2/2017',250000);
	INSERT INTO BAOLUU VALUES (7, 13,'12/05/2016','3/2/2017',500000);
	INSERT INTO BAOLUU VALUES (8, 3,'12/05/2016','3/2/2017',500000);
	GO
	SELECT * FROM BAOLUU
	--DELETE FROM BAOLUU


	INSERT INTO CONGNO VALUES ( 1, 3, N'Tiền học phí',13000000,10000000,12300,0,N'Trạng Thái');		
	INSERT INTO CONGNO VALUES ( 2, 4, N'Tiền học phí',11000000,10000000,2100,0,N'Trạng Thái');
	INSERT INTO CONGNO VALUES ( 4, 2, N'Tiền học phí',12000000,12000000,1200,0,N'Trạng Thái');
	INSERT INTO CONGNO VALUES ( 7, 1, N'Tiền học phí',10000000,13000000,4000,0,N'Trạng Thái');
	INSERT INTO CONGNO VALUES ( 8, 11, N'Tiền học phí',12500000,13000000,78300,0,N'Trạng Thái');
	INSERT INTO CONGNO VALUES ( 9, 10, N'Tiền học phí',10500000,11000000,89000,0,N'Trạng Thái');
	INSERT INTO CONGNO VALUES ( 10, 7, N'Tiền học phí',13500000,14000000,4000,0,N'Trạng Thái');
	INSERT INTO CONGNO VALUES ( 11, 8, N'Tiền học phí',10000000,11000000,5000,0,N'Trạng Thái');
	INSERT INTO CONGNO VALUES ( 13, 13, N'Tiền học phí',14500000,15000000,87000,0,N'Trạng Thái');
	SELECT * FROM CONGNO
	--DELETE FROM CONGNO
	--SELECT * FROM CONGNO, BAOLUU WHERE CONGNO.MABL = BAOLUU.MABL

	------------------------------------------------ Store Procedure ----------------------------------------------------------------------------------
	----------------------------------------Giảng Viên----------------------------------------ư
	go
	create proc LayToanBoGiangVien
	as
	begin
		select * from GIANGVIEN
	end

	GO

	create proc ThemGiangVien
	(
		@MAGV int,
		@TENGV nvarchar(100),
		@NAMSINH date,
		@DIACHI NVARCHAR(MAX),
		@SDT CHAR(10),
		@TRINHDO NVARCHAR(50)
	)
	AS
		BEGIN
		INSERT INTO GIANGVIEN(MAGV,TENGV,NAMSINH,DIACHI,SDT,TRINHDO) VALUES(@MAGV,@TENGV,@NAMSINH,@DIACHI,@SDT,@TRINHDO)
	END

	GO

	CREATE PROC XoaGiangVien
	(
		@MAGV INT
	)
	AS
		BEGIN
		DELETE FROM GIANGVIEN WHERE MAGV = @MAGV
	END

	GO

	create proc SuaGiangVien
	(
		@MAGV int,
		@TENGV nvarchar(100),
		@NAMSINH date,
		@DIACHI NVARCHAR(MAX),
		@SDT CHAR(10),
		@TRINHDO NVARCHAR(50)
	)
	AS
		BEGIN
		UPDATE GIANGVIEN
		SET TENGV = @TENGV,NAMSINH=@NAMSINH,DIACHI=@DIACHI,SDT=@SDT,TRINHDO=@TRINHDO WHERE MAGV=@MAGV
	END

	go

	
	-----------------Có thay đổi-----------------
	create proc TimKiemGiangVien
	(
		@ChuoiTimKiem nvarchar(50)
	)
	AS
	BEGIN
		SELECT * FROM GIANGVIEN
		WHERE TENGV LIKE N'%' + @ChuoiTimKiem + '%'
	END
	go
	-------------------------------------------------------------------------------------------
	----------------------------- Khóa Học ----------------------------------------------------
	create proc LayToanBoKhoaHoc
	as
	begin
		select * from KHOAHOC
	end

	GO

	create proc ThemKhoaHoc
	(
		@TENKH nvarchar(100),
		@SOLUONGHVTD INT,
		@THOILUONG INT,
		@SOLUONGHVTT INT
	)
	AS
		BEGIN
		INSERT INTO KHOAHOC(TENKH,SOLUONGHVTD,THOILUONG,SOLUONGHVTT) VALUES(@TENKH,@SOLUONGHVTD,@THOILUONG,@SOLUONGHVTT)
	END

	GO

	CREATE PROC XoaKhoaHoc
	(
		@MAKH INT
	)
	AS
		BEGIN
		DELETE FROM KHOAHOC WHERE MAKH = @MAKH
	END

	GO

	create proc SuaKhoaHoc
	(
		@MAKH int,
		@TENKH nvarchar(100),
		@SOLUONGHVTD INT,
		@THOILUONG INT,
		@SOLUONGHVTT INT
	)
	AS
		BEGIN
		UPDATE KHOAHOC
		SET TENKH = @TENKH,SOLUONGHVTD=@SOLUONGHVTD,THOILUONG=@THOILUONG,SOLUONGHVTT=@SOLUONGHVTT WHERE MAKH = @MAKH
	END

	go

	-----------------Có thay đổi-----------------

	create proc TimKiemKhoaHoc
	(
		@ChuoiTimKiem nvarchar(50)
	)
	AS
	BEGIN 
		SELECT * FROM KHOAHOC
		WHERE TENKH LIKE N'%' + @ChuoiTimKiem + '%'
	END
	go
	-------------------------------------------------------------------------------------------
	----------------------------- Phòng Học ---------------------------------------------------
	create proc LayToanBoPhongHoc
	as
	begin
		select * from PHONGHOC
	end

	GO
	create proc ThemPhongHoc
	(
		@TENPH NVARCHAR(100),
		@SOLUONG INT
	)
	AS
	BEGIN
	INSERT INTO PHONGHOC(TENPH,SOLUONG) VALUES(@TENPH,@SOLUONG)
	END

	GO

	CREATE PROC XoaPhongHoc
	(
		@MAPH INT
	)
	AS
	BEGIN
	DELETE FROM PHONGHOC WHERE MAPH = @MAPH
	END

	GO

	create proc SuaPhongHoc
	(
		@MAPH INT,
		@TENPH NVARCHAR(100),
		@SOLUONG INT
	)
	AS
	BEGIN
	UPDATE PHONGHOC
	SET TENPH = @TENPH,SOLUONG=@SOLUONG WHERE MAPH = @MAPH
	END

	go

	-----------------Có thay đổi-----------------

	create proc TimKiemPhongHoc
	(
		@ChuoiTimKiem nvarchar(50)
	)
	AS
	BEGIN
		SELECT * FROM PHONGHOC
		WHERE TENPH LIKE N'%' + @ChuoiTimKiem + '%'
	END
	go
	------------------------------------- Lop Hoc----------------------------------------------

	create proc ThemLopHoc
	(
		@MAPH INT,
		@MAKH INT,
		@MAGV INT,
		@MOLOP BIT,
		@TIETHOC NVARCHAR(50),
		@LICHKHAIGIANG DATE,
		@LICHKETTHUC DATE,
		@TINHTRANG NVARCHAR(100),
		@SOLUONG INT,
		@MaDotKhaiGiang int
	)
	AS
	BEGIN
	INSERT INTO LOPHOC(MAPH,MAKH,MAGV,MOLOP,TIETHOC,LICHKHAIGIANG,LICHKETTHUC,TINHTRANG,SOLUONG,MaDotKhaiGiang) VALUES(@MAPH,@MAKH,@MAGV,@MOLOP,@TIETHOC,@LICHKHAIGIANG,@LICHKETTHUC,@TINHTRANG,@SOLUONG,@MaDotKhaiGiang)
	END
	go

	CREATE PROC SuaLopHoc
	(
		@MALH INT,
		@MAPH INT,
		@MAKH INT,
		@MAGV INT,
		@MOLOP BIT,
		@TIETHOC NVARCHAR(50),
		@LICHKHAIGIANG DATE,
		@LICHKETTHUC DATE,
		@TINHTRANG NVARCHAR(100),
		@SOLUONG INT,
		@MaDotKhaiGiang int
	)
	AS
	BEGIN
	UPDATE LOPHOC
	SET MAPH=@MAPH,MAKH=@MAKH,MAGV=@MAGV,MOLOP=@MOLOP,TIETHOC=@TIETHOC,LICHKHAIGIANG=@LICHKHAIGIANG,LICHKETTHUC=@LICHKETTHUC,TINHTRANG=@TINHTRANG,SOLUONG=@SOLUONG,MaDotKhaiGiang = @MaDotKhaiGiang WHERE MALH = @MALH
	END

	go

	create proc XoaLopHoc
	(
		@MALH int
	)
	as
	BEGIN
	DELETE FROM LOPHOC WHERE MALH = @MALH
	END

	go

	create proc LayToanBoLopHoc
	as
	begin
		select LOPHOC.MALH,TENPH,TENKH,TENGV,TIETHOC,LOPHOC.LICHKHAIGIANG,LOPHOC.LICHKETTHUC,LOPHOC.TINHTRANG,LOPHOC.SOLUONG,LOPHOC.MOLOP,PHONGHOC.MAPH,DotKhaiGiang.TenDotKhaiGiang from  LOPHOC,GIANGVIEN,KHOAHOC,PHONGHOC,DotKhaiGiang where DotKhaiGiang.MaDotKhaiGiang = LOPHOC.MaDotKhaiGiang and LOPHOC.MAGV = GIANGVIEN.MAGV and LOPHOC.MAKH = KHOAHOC.MAKH and LOPHOC.MAPH = PHONGHOC.MAPH
	end

	select * from CONGNO

	go
	--drop proc TimKiemLop
	-----------------------------------------------------------------------------------------------------------------------------
	create proc TimKiemLop
	(
			@MaDotKhaiGiang  int
	)
	as
	begin
               select LOPHOC.MALH,TENPH,TENKH,TENGV,TIETHOC,LOPHOC.LICHKHAIGIANG,LOPHOC.LICHKETTHUC,LOPHOC.TINHTRANG,LOPHOC.SOLUONG,LOPHOC.MOLOP,PHONGHOC.MAPH,DotKhaiGiang.TenDotKhaiGiang from LOPHOC,GIANGVIEN,KHOAHOC,PHONGHOC,DotKhaiGiang where DotKhaiGiang.MaDotKhaiGiang = LOPHOC.MaDotKhaiGiang and LOPHOC.MAGV = GIANGVIEN.MAGV and LOPHOC.MAKH = KHOAHOC.MAKH and LOPHOC.MAPH = PHONGHOC.MAPH and DotKhaiGiang.MaDotKhaiGiang = @MaDotKhaiGiang
	end
	-----------------------------------------------------------------------------------------------------------------------
	go
	select * from LOPHOC
	go
	-------------------------------------------------------------------------------------------

	
	----------------------------------------BAO LUU----------------------------------------


	create proc LayToanBoBaoLuu
	as
	begin
		select * from BAOLUU
	end

	GO


	create proc LayToanBoBaoLuuTheoLop
	(
		@MALH int
	)
	as
	begin
		select * from BAOLUU where MALH = @MALH
	end

	GO


		create proc LayToanBoBaoLuuTheoMaHocVien
	(
		@MAHV int
	)
	as
	begin
		select * from BAOLUU where MAHV =@MAHV
	end

	GO

	create proc ThemBaoLuu
	(
		@MALH INT,
		@MAHV INT,
		@THOIGIANBATDAUBAOLUU DATE, 
		@THOIGIANKETTHUCBAOLUU DATE, 
		@SOTIENBAOLUU FLOAT 
	)
	AS
	BEGIN
	INSERT INTO BAOLUU(MALH,MAHV,THOIGIANBATDAUBAOLUU,THOIGIANKETTHUCBAOLUU,SOTIENBAOLUU) 
	VALUES(@MALH,@MAHV,@THOIGIANBATDAUBAOLUU,@THOIGIANKETTHUCBAOLUU,@SOTIENBAOLUU)
	END

	GO
	

	CREATE PROC XoaBaoLuu
	(
		@MABL INT
	)
	AS
	BEGIN
	DELETE FROM BAOLUU WHERE MABL = @MABL
	END

	GO

	create proc SuaBaoLuu
	(
		@MABL INT,
		@MALH INT,
		@MAHV INT,
		@THOIGIANBATDAUBAOLUU DATE, 
		@THOIGIANKETTHUCBAOLUU DATE, 
		@SOTIENBAOLUU FLOAT 
	)
	AS
	BEGIN
	UPDATE BAOLUU
	SET MALH=@MALH,MAHV=@MAHV,THOIGIANBATDAUBAOLUU=@THOIGIANBATDAUBAOLUU,
	THOIGIANKETTHUCBAOLUU=@THOIGIANKETTHUCBAOLUU,SOTIENBAOLUU=@SOTIENBAOLUU  WHERE MABL=@MABL
	END
	go

	create proc TimKiemBaoLuu
	(
		@MABL int
	)
	AS
	BEGIN
		SELECT * FROM BAOLUU
		WHERE MABL = @MABL
	END
	go
	create proc TimKiemBaoLuuTrongCongNo
	(
		@MABL int
	)
	AS
	BEGIN
		SELECT * FROM CONGNO
		WHERE MABL = @MABL
	END
	go
	-------------------------------------------------------------------------------------------
		----------------------------------------CÔNG NỢ----------------------------------------


	create proc LayToanBoCongNo
	as
	begin
		select * from CONGNO
	end

	GO

	create proc ThemCongNo
	(
	@MALH INT,
	@MABL INT,
	@NOIDUNGTHU NVARCHAR(MAX),
	@HOCPHI FLOAT,
	@SOTIENNOP FLOAT, 
	@SOTIENCONLAI FLOAT,
	@SODU FLOAT,
	@TRANGTHAI NVARCHAR(MAX)
	)
	AS
	BEGIN
			IF ( @SOTIENNOP > @HOCPHI )
				SET @SOTIENCONLAI = 0
		ELSE
				SET @SOTIENCONLAI = abs(@HOCPHI - @SOTIENNOP)
		IF ( @SOTIENNOP > (@HOCPHI  - (select SOTIENBAOLUU FROM BAOLUU WHERE MABL = @MABL)))
				SET @SODU = @SOTIENNOP - (@HOCPHI - (SELECT SOTIENBAOLUU FROM BAOLUU WHERE MABL = @MABL ))
		ELSE
				UPDATE CONGNO
				SET @SODU = 0
				WHERE MABL = @MABL

	INSERT INTO CONGNO(MALH,MABL,NOIDUNGTHU,HOCPHI,SOTIENNOP,SOTIENCONLAI,SODU,TRANGTHAI)
	VALUES(@MALH,@MABL,@NOIDUNGTHU,@HOCPHI,@SOTIENNOP,@SOTIENCONLAI,@SODU,@TRANGTHAI)

	END

	GO
	

	CREATE PROC XoaCongNo
	(
		@MALH INT,
		@MABL INT
	)
	AS
	BEGIN
	DELETE FROM CONGNO WHERE MALH = @MALH AND MABL=@MABL
	END

	GO

	create proc SuaCongNo	
	(
		@MALH INT,
		@MABL INT,
		@NOIDUNGTHU NVARCHAR(MAX),
		@HOCPHI FLOAT,
		@SOTIENNOP FLOAT, 
		@SOTIENCONLAI FLOAT,
		@SODU FLOAT,
		@TRANGTHAI NVARCHAR(MAX)
	)
	AS
	BEGIN
		IF ( @SOTIENNOP > @HOCPHI )
				SET @SOTIENCONLAI = 0
		ELSE
				SET @SOTIENCONLAI = abs(@HOCPHI - @SOTIENNOP)
		IF ( @SOTIENNOP > (@HOCPHI  - (select SOTIENBAOLUU FROM BAOLUU WHERE MABL = @MABL)))
				SET @SODU = @SOTIENNOP - (@HOCPHI - (SELECT SOTIENBAOLUU FROM BAOLUU WHERE MABL = @MABL ))
		ELSE
				UPDATE CONGNO
				SET @SODU = 0
				WHERE MABL = @MABL
	UPDATE CONGNO
	SET NOIDUNGTHU=@NOIDUNGTHU,HOCPHI=@HOCPHI,SOTIENNOP=@SOTIENNOP,SOTIENCONLAI=@SOTIENCONLAI,SODU=@SODU,TRANGTHAI=@TRANGTHAI 
	WHERE MALH=@MALH AND MABL=@MABL
	END
	go
		create proc TimKiemCongNo
	(
		@MABL int,
		@MALH int
	)
	AS
	BEGIN
		SELECT * FROM CONGNO
		WHERE MABL = @MABL and MALH =@MALH
	END
	go
			create proc TimKiemCongNoTheoMaLop
	(
		@MALH int
	)
	AS
	BEGIN
		SELECT * FROM CONGNO
		WHERE MALH =@MALH
	END
	go
			create proc TimKiemCongNoTheoMaBL
	(
		@MABL int
	)
	AS
	BEGIN
		SELECT * FROM CONGNO
		WHERE MABL =@MABL
	END
	go
		-------------------------------------------------------------------------------------------

		---------------------------------------- HỌC VIÊN ----------------------------------------

	create proc LayToanBoHocVien
	as
	begin
		select * from HOCVIEN
	end

	go
	create proc LayToanBoHocVienTheoLop
	(
		@MALH int
	)
	as
	begin
		select * from HOCVIEN where MALH = @MALH
	end


	GO

	create proc ThemHocVien
	(
		@MALH INT,
		@TENHV NVARCHAR(100),
		@NAMSINH DATE,
		@DIACHI NVARCHAR(MAX),
		@NGHENGHIEP NVARCHAR(100),
		@TINHTRANG NVARCHAR(100),
		@SDT CHAR(10)
	)
	AS
	BEGIN
	INSERT INTO HOCVIEN(MALH,TENHV,NAMSINH,DIACHI,NGHENGHIEP,TINHTRANG,SDT)
	VALUES(@MALH,@TENHV,@NAMSINH,@DIACHI,@NGHENGHIEP,@TINHTRANG,@SDT)
	END

	GO
	

	CREATE PROC XoaHocVien
	(
		@MAHV INT
	)
	AS
	BEGIN
	DELETE FROM HOCVIEN WHERE MAHV=@MAHV
	END

	GO

	create proc SuaHocVien	
	(
		@MAHV INT ,
		@MALH INT,
		@TENHV NVARCHAR(100),
		@NAMSINH DATE,
		@DIACHI NVARCHAR(MAX),
		@NGHENGHIEP NVARCHAR(100),
		@TINHTRANG NVARCHAR(100),
		@SDT CHAR(10)
	)
	AS
	BEGIN
	UPDATE HOCVIEN
	SET MALH=@MALH,TENHV=@TENHV,NAMSINH=@NAMSINH,DIACHI=@DIACHI,NGHENGHIEP=@NGHENGHIEP,TINHTRANG=@TINHTRANG,SDT=@SDT
	WHERE MAHV =@MAHV
	END
	go
	create proc TimKiemHocVienByName
	(
		@TimKiem nvarchar(50)
	)
	AS
	BEGIN
		SELECT * FROM HOCVIEN
		WHERE TENHV like N'%' + @TimKiem + '%' or TENHV =@TimKiem
	END
	
	go

	create proc TimKiemHocVienByID
	(
		@MAHV int 
	)
	AS
	BEGIN
		SELECT * FROM HOCVIEN
		WHERE MAHV =@MAHV
	END
	go
	create proc TimKiemHocVienTrongBaoLuu
	(
		@MAHV int 
	)
	AS
	BEGIN
		SELECT * FROM BAOLUU
		WHERE MAHV =@MAHV
	END
	go


----------------------------------- Đợt Khai Giảng-----------------------------------------------------------
create proc LayDotKhaiGiang
as
begin
select * from DotKhaiGiang
end
go
create proc AddDotKhaiGiang
(
	@TenDotKhaiGiang nvarchar(250)
)
as
begin
insert into DotKhaiGiang(TenDotKhaiGiang) values(@TenDotKhaiGiang)
end
go
create proc EditDotKhaiGiang
(
	@MaDotKhaiGiang int,
	@TenDotKhaiGiang nvarchar(250)
)
as
begin
Update DotKhaiGiang set TenDotKhaiGiang = @TenDotKhaiGiang where MaDotKhaiGiang = @MaDotKhaiGiang
end
go
--drop proc DeleteDotKhaiGiang
create proc DeleteDotKhaiGiang
(
 @TenDotKhaiGiang nvarchar(250)
)
as
begin
delete from DotKhaiGiang where TenDotKhaiGiang = @TenDotKhaiGiang
end
go

	-------------------------------------------------------------------------------------------
	
	--Có Gì Thêm Vào Đây
	create proc LayToanBoUser
	as
	begin
		select * from ttUser 
	end
	--drop proc LayToanBoUser

	------------------------------------------------------------------------------------------