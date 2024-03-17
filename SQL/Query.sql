use JobApp

create table TAIKHOAN(
	userid varchar(255) constraint PK_Account primary key,
	matkhau varchar(255) not null,
	vaitro varchar(30),
	ho varchar(255) ,
	ten varchar(255),
	ngsinh date check (datediff(year, ngsinh, getdate()) >= 18),
	cmnd varchar(12) check (len(cmnd)=12),
	gioitinh varchar(10),
	diachi varchar(255),
	sdt varchar(10) check (len(sdt) = 10),
	email varchar(255) check (email like '_@'),
	hinhanh varbinary(MAX),
	thongtin text,
)

alter table TAIKHOAN alter column cmnd varchar(255)

create table BAIDANG(
	idbai varchar(255) constraint PK_BAIDANG primary key,
	loaibai varchar(255) not null,
	tieude varchar(255) not null,
	noidung text,
	ngaydang date,
	hinhanh varbinary(max),
	luotthich int,
	userid varchar(255) constraint FK_BAIDANG_TK foreign key references TAIKHOAN(userid),
)

create table CONGVIEC(
	idcongviec varchar(255) constraint PK_CONGVIEC primary key,
	tencongviec varchar(255) not null,
	mucluong varchar(255),
	linhvuc varchar(255),
	thongtin text,
	trinhdo varchar(255),
)

create table UNGTUYEN(
	userid varchar(255) constraint FK_UNGTUYEN_TK foreign key references TAIKHOAN(userid),
	idcongviec varchar(255) constraint FK_UNGTUYEN_CV foreign key references CONGVIEC(idcongviec),
	thoigian datetime,
	trangthaiphanhoi varchar(255),
	cv varbinary(max),
	constraint PK_UNGTUYEN primary key (userid, idcongviec)
)

insert into TAIKHOAN(userid, matkhau, vaitro) values ('xuanbao2302', 'xuanbao2302','Hirer')
delete from TAIKHOAN where userid = 'xuanbao'

select * from TAIKHOAN
select * from TAIKHOAN where userid = 'xuanbao2302' and matkhau = 'xuanbao2302' and vaitro = 'Hirer'