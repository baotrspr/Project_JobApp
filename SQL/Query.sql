create table TTUngVien(
	id varchar(255) primary key not null,
	hoten varchar(255),
	ngsinh varchar(10),
	diachi varchar(255),
	sdt varchar(10),
	email varchar(255),
)

create table TTHoSoUV(
	id varchar(255) not null,
	trinhdo varchar(255),
	linhvuc varchar(255),
	thongtin varchar(max),
)
create table TKUngVien(
	id varchar(255),
	matkhau varchar(255),
	maso varchar(255)
)

create table TKNhaTuyenDung(
	id varchar(255),
	matkhau varchar(255),
	hoten varchar(255),
	maso varchar(255)
)

create table Feeds(
	feedid varchar(255) primary key,
	userid varchar(255),
	content text,
	photo varbinary(max),


)