create database QuanLyVeMayBay
go
use QuanLyVeMayBay
go
create table Users
(
	id varchar(10) not null primary key,
	Ho nvarchar(50) ,
	Ten nvarchar(50),
	Chuyenbay nvarchar(50)
)
go
insert into Users
values('us01',N'Nguyễn',N'Đức Cường', N'CV01'),
		('us02',N'Nguyễn',N'Văn A', N'CV01'),
		('us03',N'Nguyễn',N'Văn B', N'CV02')
