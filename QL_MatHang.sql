-- Yêu cầu;
-- 1. tạo cơ sở dữ liệu QuanLyMatHang
-- 2. tạo bảng TaiKhoan
-- 3. nhập dữ liệu

create database QuanLyMatHang;

drop database QuanLyMatHang;

use QuanLyMatHang;

create table TaiKhoan(
	id_TaiKhoan int identity(1, 1) primary key,
	ten_tai_khoan varchar(20),
	mat_khau varchar(20)
);

insert into TaiKhoan(ten_tai_khoan, mat_khau) values ('admin', '123456');
insert into TaiKhoan(ten_tai_khoan, mat_khau) values ('abc', '123456');
insert into TaiKhoan(ten_tai_khoan, mat_khau) values ('def', '123456');