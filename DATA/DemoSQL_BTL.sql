CREATE DATABASE QLSV_BTL
GO
USE QLSV_BTL
CREATE TABLE tblLOGIN(
	TenDN nvarchar(50)  not null,
	MatKhau nvarchar(50) not null,
	HoTen nvarchar(50) null,
	Quyen nvarchar(50) null,
	primary key (TenDN,MatKhau)
)
GO
CREATE TABLE tblGIANG_VIEN(
	MaGV nvarchar(10) primary key not null,
	TenGV nvarchar(30) null,
	GioiTinh nvarchar(10) null,
	Phone nvarchar(15) null,
	Email nvarchar(20) null
)
GO
CREATE TABLE tblKHOA(
	MaKhoa nvarchar(10) primary key not null,
	TenKhoa nvarchar(50) null
)
GO
CREATE TABLE tblLOP(
	MaLop nvarchar(10) primary key not null,
	TenLop nvarchar(50) null,
	MaKhoa nvarchar(10) null,
	foreign key (MaKhoa) references tblKHOA(MaKhoa)
)
GO
CREATE TABLE tblMON(
	MaMon nvarchar(10) primary key not null,
	TenMon nvarchar(50) null,
	SoDVHT int null,
	MaGV nvarchar(10) null,
	MaKhoa nvarchar(10) null
	foreign key (MaGV) references tblGIANG_VIEN(MaGV)
)
GO
CREATE TABLE tblSINH_VIEN(
	MaSV nvarchar(10) primary key not null,
	HoTen nvarchar(50) null,
	NgaySinh nvarchar(10) null,
	GioiTinh nvarchar(10) null,
	DiaChi nvarchar(50) null,
	MaLop nvarchar(10) null,
	foreign key (MaLop) references tblLOP(MaLop)
)
GO
CREATE TABLE tblKET_QUA(
	MaSV nvarchar(10) not null,
	HoTen nvarchar(50) null,
	MaLop nvarchar(10) null,
	MaMon nvarchar(10) null,
	DiemCC float null,
	DiemGK float null,
	DiemCK float null, 
	DiemTK float null,
	GhiChu nvarchar(100) null,
	foreign key (MaSV) references tblSINH_VIEN(MaSV),
	foreign key (MaLop) references tblLOP(MaLop),
	foreign key (MaMon) references tblMON(MaMon)
)
GO
