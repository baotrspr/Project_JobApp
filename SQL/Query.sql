use JobApp

create table TAIKHOAN(
	userid varchar(255) constraint PK_Account primary key,
	matkhau varchar(255) not null,
	vaitro nvarchar(30),
	ho nvarchar(255) ,
	ten nvarchar(255),
	ngsinh nvarchar(10),
	cmnd nvarchar(12) check (len(cmnd)=12),
	gioitinh nvarchar(10),
	diachi nvarchar(255),
	sdt nvarchar(10) check (len(sdt) = 10),
	email nvarchar(255) check (email like '%@%'),
	thongtin text,
)



create table BAIDANG(
	idbai varchar(255) constraint PK_BAIDANG primary key,
	loaibai nvarchar(255) not null,
	tieude nvarchar(255) not null,
	noidung text,
	ngaydang varchar(10),
	userid varchar(255) constraint FK_BAIDANG_TK foreign key references TAIKHOAN(userid),
	motacv nvarchar(255),
)
alter table BAIDANG add motacv nvarchar(255)
select * from BAIDANG
delete from BAIDANG where idbai = 'FD1234'
create table CONGVIEC(
	idcongviec varchar(255) constraint PK_CONGVIEC primary key,
	tencongviec varchar(255) not null,
	mucluong nvarchar(255),
	linhvuc nvarchar(255),
	thongtin text,
	trinhdo nvarchar(255),
	userid varchar(255) constraint FK_CONGVIEC_TK foreign key references TAIKHOAN(userid),
)


create table UNGTUYEN(
	userid varchar(255) constraint FK_UNGTUYEN_TK foreign key references TAIKHOAN(userid),
	idcongviec varchar(255) constraint FK_UNGTUYEN_CV foreign key references CONGVIEC(idcongviec),
	thoigian datetime,
	trangthaiphanhoi nvarchar(255),
	cv varbinary(max),
	constraint PK_UNGTUYEN primary key (userid, idcongviec)
)

select * from BAIDANG

drop table TAIKHOAN
drop table BAIDANG
drop table CONGVIEC
drop table UNGTUYEN


SELECT *
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME = 'TAIKHOAN'
AND CONSTRAINT_TYPE = 'CHECK';

alter table BAIDANG alter column ngaydang varchar(10)
delete from BAIDANG
insert into BAIDANG values ('FD1234', N'Tuyển dụng', N'Tuyển TTS IT', N'Tuyển dụng TTS IT đã tốt nghiệp', '17/03/2024', 'xuanbao2302')

alter table CONGVIEC add userid varchar(255) constraint FK_CONGVIEC_TK foreign key references TAIKHOAN(userid)
select * from CONGVIEC

insert into CONGVIEC values ('CV001', 'Dev', '50000000', 'CNTT', 'Tuyen nv', 'Dai hoc', 'xuanbao2302')

alter table TAIKHOAN add constraint CK__TAIKHOAN__email__6E01572D check (email like '%@%')
