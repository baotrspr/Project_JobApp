use JobApp
create table TKUngVien(
	id varchar(255) primary key not null,
	matkhau varchar(255),
	hoten varchar(255),
	doituong varchar(255),
	ngsinh varchar(10),
	gioitinh varchar(10),
	diachi varchar(255),
	sdt varchar(10),
	hocvan varchar(10),
	email varchar(255),
	hinhanh varbinary(MAX),
	thongtin text,
)

create table TKNhaTuyenDung(
	id varchar(255),
	matkhau varchar(255),
	hoten varchar(255),
	doituong varchar(255),
	ngaysinh varchar(10),
	gioitinh varchar(10),
	diachi varchar(255),
	sdt varchar(10),
	email varchar(255),
	hinhanh varbinary(max),
	donvi varchar(255),
	thongtin text,
)

create table Feeds(
	feedid varchar(255) primary key,
	userid varchar(255),
	tieude varchar(255),
	content text,
	photo varbinary(max),
	luong varchar(255),
	linhvuc varchar(255),
	ngaydang varchar(10),
	solike int,
)

create table CongViec(
	macongviec varchar(255),
	tencongviec varchar(255),
	mucluong varchar(255),
	linhvuc varchar(255),
	thongtin text,
	manguoitao varchar(255),
)