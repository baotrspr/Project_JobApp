use JobApp

create table TAIKHOAN(
	userid varchar(255) constraint PK_Account primary key,
	matkhau varchar(255) not null,
	vaitro varchar(30),
	ho varchar(255) ,
	ten varchar(255),
	ngsinh varchar(10),
	cmnd varchar(12) check (len(cmnd)=12),
	gioitinh varchar(10),
	diachi varchar(255),
	sdt varchar(10) check (len(sdt) = 10),
	email varchar(255) check (email like '%@%'),
	thongtin text,
)



create table BAIDANG(
	idbai varchar(255) constraint PK_BAIDANG primary key,
	loaibai varchar(255) not null,
	tieude varchar(255) not null,
	noidung text,
	ngaydang varchar(10),
	userid varchar(255) constraint FK_BAIDANG_TK foreign key references TAIKHOAN(userid),
)

create table CONGVIEC(
	idcongviec varchar(255) constraint PK_CONGVIEC primary key,
	tencongviec varchar(255) not null,
	mucluong varchar(255),
	linhvuc varchar(255),
	thongtin text,
	trinhdo varchar(255),
	userid varchar(255) constraint FK_CONGVIEC_TK foreign key references TAIKHOAN(userid),
)


create table UNGTUYEN(
	userid varchar(255) constraint FK_UNGTUYEN_TK foreign key references TAIKHOAN(userid),
	idcongviec varchar(255) constraint FK_UNGTUYEN_CV foreign key references CONGVIEC(idcongviec),
	thoigian datetime,
	trangthaiphanhoi varchar(255),
	cv varbinary(max),
	constraint PK_UNGTUYEN primary key (userid, idcongviec)
)



SELECT *
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME = 'TAIKHOAN'
AND CONSTRAINT_TYPE = 'CHECK';

alter table BAIDANG alter column ngaydang varchar(10)
select * from BAIDANG
insert into BAIDANG values ('FD1234', 'Tuyen dung', 'Tuyen TTS IT', 'Tuyen dung tts it co kinh nghiem', '17/03/2024', 'xuanbao2302')

alter table CONGVIEC add userid varchar(255) constraint FK_CONGVIEC_TK foreign key references TAIKHOAN(userid)
select * from CONGVIEC

insert into CONGVIEC values ('CV001', 'Dev', '50000000', 'CNTT', 'Tuyen nv', 'Dai hoc', 'xuanbao2302')

alter table TAIKHOAN add constraint CK__TAIKHOAN__email__6E01572D check (email like '%@%')
