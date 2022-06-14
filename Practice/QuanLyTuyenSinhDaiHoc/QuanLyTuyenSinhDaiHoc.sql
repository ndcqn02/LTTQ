create  database QuanLyTuyenSinh
go 
use QuanLyTuyenSinh
go
create  table Nganh
(
	MaNganh char(10) primary key , 
	TenNganh nvarchar(200),
	Chitieu int,
	DiemChuan float,
)

create  table HoSoSinhVien
(
	CCCD char(10) primary key,
	HoTen nvarchar(100),
	NgaySinh date,
	GioiTinh nvarchar(10),
	MaNganh char(10) 
	constraint Fk_maNg foreign key (MaNganh) references Nganh(MaNganh),
	NguyenVong char(5),
	DiaChi nvarchar(100),
	Diem1 float,
	Diem2 float,
	Diem3 float
)
go
create table users
(
	CCCD char(10) not null primary key,
	password nvarchar(50) ,
	constraint Fk_HsoCCCD foreign key (CCCD) references HoSoSinhVien(CCCD)
)
go



delete Nganh
insert into Nganh
values ('CNNT', N'Công nghệ thông tin', 3, 20.5),
		('CNHH', N'Công nghệ hoá học', 5, 24.5),
		('CNSH', N'Công nghệ sinh học', 5, 25.5),
		('CNMT', N'Công nghệ môi trường', 5, 18.5),
		('KTD', N'Kĩ thuật điên', 3, 15.5),
		('CK', N'Cơ khí', 150, 21.5),
		('CNOT', N'Công nghệ ô tô', 150, 25.5),
		('XK', N'Xây dựng', 5, 19.5),
		('CNTP', N'Công nghệ thực phẩm', 10, 15.5),
		('HHMT', N'Hoá học môi trường', 5, 18)

go
delete HoSoSinhVien
SELECT FORMAT (getdate(), 'dd-MM-yy') as date	
GO
insert into HoSoSinhVien
values ('123',N'Nguyễn Đức Cường', '12-01-20', 'Nam', 'CNNT', 'NV1', N'Quảng Nam', 9,9,9 ),
		('124',N'Nguyễn Đức Hoà', '12-01-20', 'Nam', 'CNNT', 'NV1', N'Quảng Nam', 10,8,9 ),
		('125',N'Nguyễn Đức Cương', '12-01-20', 'Nam', 'CNNT', 'NV1', N'Quảng Nam', 5,8,9 ),
		('126',N'Nguyễn Đức Hào', '12-01-20', 'Nam', 'HHMT', 'NV1', N'Quảng Nam', 7,4,9 ),
		('127',N'Nguyễn Đức Hưng', '12-01-20', 'Nam', 'CNTP', 'NV1', N'Quảng Nam', 6,10,9.5 ),
		('128',N'Nguyễn Đức Hùng', '12-01-20', 'Nam', 'CNNT', 'NV1', N'Quảng Nam', 7,8,9 ),
		('129',N'Nguyễn Văn Hậu', '12-01-20', 'Nam', 'CNNT', 'NV1', N'Quảng Nam', 8,10,8 ),
		('130',N'Nguyễn Đức Sinh', '12-01-20', 'Nữ', 'XK', 'NV1', N'Quảng Nam', 6,9,5.5 ),
		('12345',N'Nguyễn Đức Bảo', '12-01-20', 'Nam', 'CNNT', 'NV1', N'Quảng Nam', 7,5,9 ),
		('123456',N'Nguyễn Đức Khánh', '12-01-20', 'Nam', 'CNTP', 'NV1', N'Quảng Nam', 9,8,9 ),
		('12346',N'Nguyễn Văn A', '12-01-20', 'Nam', 'HHMT', 'NV2', N'Quảng Nam', 7,10,9 ),
		('12347',N'Nguyễn Văn B', '12-01-20', 'Nam', 'HHMT', 'NV1', N'Quảng Nam', 9,8,9 ),
		('12348',N'Nguyễn Văn C', '12-01-20', 'Nữ', 'HHMT', 'NV1', N'Quảng Ngãi', 7,10,9 ),
		('12349',N'Nguyễn Văn D', '12-06-20', 'Nữ', 'HHMT', 'NV2', N'Quảng Nam', 7,10,9 ),
		('12341',N'Nguyễn Văn E', '12-07-20', 'Nam', 'HHMT', 'NV1', N'Quảng Ngãi', 7,10,9 ),
		('12342',N'Nguyễn Văn F', '12-08-20', 'Nam', 'HHMT', 'NV2', N'Quảng Nam', 7,10,9 ),
		('12343',N'Nguyễn Văn G', '12-01-20', 'Nữ', 'HHMT', 'NV1', N'Quảng Ngãi', 7,10,9 ),
		('1234112',N'Nguyễn Văn H', '12-01-20', 'Nam', 'HHMT', 'NV1', N'Quảng Nam', 9,10,9 ),
		('1234113',N'Nguyễn Văn I', '12-01-20', 'Nam', 'HHMT', 'NV2', N'Quảng Nam', 8,10,9 ),
		('1234114',N'Nguyễn Văn K', '12-02-20', 'Nữ', 'HHMT', 'NV1', N'Quảng Nam', 7,10,9 ),
		('1234115',N'Nguyễn Văn L', '12-03-20', 'Nam', 'HHMT', 'NV1', N'Quảng Nam', 5,10,9 ),
		('1234116',N'Nguyễn Văn M', '12-04-20', 'Nữ', 'HHMT', 'NV1', N'Quảng Nam', 7,8,9 ),
		('1234117',N'Nguyễn Văn Q', '12-05-20', 'Nam', 'HHMT', 'NV1', N'Quảng Nam', 7,9,9 ),
		('1234118',N'Nguyễn Văn P', '01-03-2000', 'Nữ', 'CNMT', 'NV2', N'Quảng Nam', 7,9,9 ),
		('1234119',N'Nguyễn Văn O', '01-03-2000', 'Nữ', 'CNMT', 'NV2', N'Quảng Nam', 7,9,9 ),
		('1234121',N'Nguyễn Văn I', '01-03-2000', 'Nữ', 'CNMT', 'NV2', N'Quảng Nam', 7.5,9,9 ),
		('1234122',N'Nguyễn Văn Y', '01-03-2000', 'Nữ', 'CNMT', 'NV2', N'Quảng Nam', 9.8,9,9 ),
		('1234123',N'Nguyễn Văn R', '01-03-2000', 'Nữ', 'CNMT', 'NV2', N'Quảng Nam', 8,9,9 ),
		('1234124',N'Nguyễn Văn E', '01-03-2000', 'Nữ', 'CNMT', 'NV2', N'Quảng Nam', 5,9,9 ),
		('1234125',N'Nguyễn Văn W', '01-03-2000', 'Nữ', 'CNMT', 'NV2', N'Quảng Nam', 8,9,9 )



go
insert into users
values ('123',123),
		('12345',123)

go 
select * From HoSoSinhVien
select * from Nganh


-- Danh sach dau dai hoc
select distinct * from HoSoSinhVien LEFT JOIN Nganh ON HoSoSinhVien.MaNganh  = Nganh.MaNganh where Diem1 + Diem1 + Diem3 >= DiemChuan
select DISTINCT CCCD,HoTen from HoSoSinhVien, Nganh where Diem1 + Diem1 + Diem3 >= DiemChuan 
	
-- so ho so dang ky
select count (CCCD) from HoSoSinhVien 

-- dem so luong dau dai hoc
select count(DISTINCT(CCCD )) from HoSoSinhVien LEFT JOIN Nganh ON HoSoSinhVien.MaNganh  = Nganh.MaNganh where Diem1 + Diem1 + Diem3 >= DiemChuan

-- dem so luong nganh hien dang dang ky bao nhieu
select TenNganh, count (Nganh.MaNganh ) as SLDaDau 
from HoSoSinhVien,Nganh
where Diem1 + Diem1 + Diem3 >= DiemChuan 
group by TenNganh 

-- danh sach nganh du chi tieu
select Nganh .TenNganh ,Chitieu 
from Nganh,(select TenNganh, count (Nganh.MaNganh ) as SLDaDau 
			from HoSoSinhVien,Nganh
			where Diem1 + Diem1 + Diem3 >= DiemChuan 
			group by TenNganh ) truyvancon
where  Nganh .TenNganh = truyvancon.TenNganh and truyvancon.SLDaDau >= Chitieu 


