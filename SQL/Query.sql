use JobApp


create table ACCOUNT(
	userid varchar(255) constraint PK_Account primary key,
	matkhau varchar(255) not null,
	vaitro nvarchar(30),
)

create table JOBSEEKER(
	userid varchar(255) constraint PK_JobSeeker primary key,
	ho nvarchar(255) ,
	ten nvarchar(255),
	ngsinh nvarchar(10),
	cmnd nvarchar(12) check (len(cmnd)=12),
	gioitinh nvarchar(10),
	diachi nvarchar(255),
	sdt nvarchar(10) check (len(sdt) = 10),
	email nvarchar(255) check (email like '%@%'),
	thongtin nvarchar(max),
)


create table COMPANY(
	userid varchar(255) constraint PK_Company primary key,
	ten nvarchar(255),
	ngaythanhlap varchar(10),
    ngdungdau nvarchar(255),
    diachi nvarchar(255),
    sdt nvarchar(10) check (len(sdt) = 10),
    masothue nvarchar(255),
    linhvuc nvarchar(255),
    email nvarchar(255) check (email like '%@%'),
	thongtin nvarchar(max),
	website varchar(255)
)

create table CONGVIEC(
	jobid varchar(255) constraint PK_CONGVIEC primary key,
	userid varchar(255) constraint FK_CONGVIEC_TK foreign key references ACCOUNT(userid) on delete cascade,
	tencv nvarchar(255) not null,
	ngaytao varchar(10),
	vitri nvarchar(255),
	mucluong nvarchar(255),
	linhvuc nvarchar(255),
	thongtin nvarchar(max),
	phucloi nvarchar(max),
	yeucau nvarchar(max),
	soluong int,
	noilamviec nvarchar(255),
	diadiem nvarchar(255),
	handangki varchar(10),
	trangthai nvarchar(255),
	dadangki int
)
alter table CONGVIEC alter column ngaytao varchar(20)
select c.*, co.ten from CONGVIEC c join COMPANY co on c.userid = co.userid
update CONGVIEC set ngaytao = '12/04/2024 23:59:59' where jobid = 'HS001'

create table UNGTUYEN(
	userid varchar(255) constraint FK_UNGTUYEN_TK foreign key references ACCOUNT(userid) on delete cascade,
	jobid varchar(255) constraint FK_UNGTUYEN_CV foreign key references CONGVIEC(jobid) on delete cascade,
	tencv nvarchar(255),
	thoigian varchar(10),
	congty varchar(255) constraint FK_UNGTUYEN_CP foreign key references COMPANY(userid),
	trangthaiphanhoi nvarchar(255),
	constraint PK_UNGTUYEN primary key (userid, jobid)
)
go

create trigger ins_congviec_ddk
on CONGVIEC
after insert
as
begin
	declare @nmacv varchar(255)
	select @nmacv = ne.jobid from inserted ne
	update CONGVIEC set dadangki = 0, trangthai = 'avail' where jobid = @nmacv
end
go

--create trigger ins_congviec_tencty
--on CONGVIEC
--after insert
--as
--begin
--	declare @nuserid varchar(255)
--	select @nuserid = ne.userid from inserted ne
--	begin
--		update CONGVIEC set 

create trigger ins_ungtuyen_cv
on UNGTUYEN
after insert
as
begin
	declare @nmacv varchar(255), @odadangki int, @osl int
	select @nmacv = ne.jobid from inserted ne
	update CONGVIEC set dadangki = dadangki + 1 where jobid = @nmacv
end
go

create trigger del_ungtuyen_cv
on UNGTUYEN
after delete
as
begin
	declare @nmacv varchar(255) 
	select @nmacv = ne.jobid from inserted ne
	update CONGVIEC set dadangki = dadangki - 1 where jobid = @nmacv
end
go

create trigger del_acc_seeker
on ACCOUNT
after delete
as
begin
	declare @ouserid varchar(255), @ovaitro varchar(10)
	select @ouserid = ol.userid, @ovaitro = ol.vaitro
	from deleted ol
	if @ovaitro = 'JobSeeker'
	begin
		delete from JOBSEEKER where userid = @ouserid;
	end
	else if @ovaitro = 'Company'
	begin
		delete from COMPANY where userid = @ouserid;
	end
end
go

create trigger del_acc_ungtuyen
on ACCOUNT
after delete
as
begin
	declare @ouserid varchar(255), @ovaitro varchar(10)
	select @ouserid = ol.userid, @ovaitro = ol.vaitro
	from deleted ol
	if @ovaitro = 'JobSeeker'
	begin
		delete from UNGTUYEN where userid = @ouserid;
	end
	else if @ovaitro = 'Company'
	begin
		delete from UNGTUYEN where congty = @ouserid;
	end
end
go

create trigger del_acc_congviec
on ACCOUNT
after delete
as
begin
	declare @ouserid varchar(255), @ovaitro varchar(10)
	select @ouserid = ol.userid, @ovaitro = ol.vaitro
	from deleted ol
	if @ovaitro = 'Company'
	begin
		delete from CONGVIEC where userid = @ouserid;
	end
end
go

create trigger del_congviec_ungtuyen
on CONGVIEC
after delete
as
begin
	declare @ojobid varchar(255)
	select @ojobid = ol.jobid
	from deleted ol
		delete from UNGTUYEN where jobid = @ojobid;
end
go

create trigger upd_ungtuyen_congviec
on UNGTUYEN
after update
as
begin
	declare @ntrangthaiphanhoi varchar(255), @njobid varchar(255)
	select @ntrangthaiphanhoi = ne.trangthaiphanhoi, @njobid = ne.jobid
	from inserted ne
	if @ntrangthaiphanhoi = 'accepted'
	begin
		update CONGVIEC set trangthai = 'notavail' where jobid = @njobid
	end
end
go
	
select * from CONGVIEC

ALTER TABLE UNGTUYEN
ADD CONSTRAINT FK_UNGTUYEN_TK FOREIGN KEY (userid) REFERENCES ACCOUNT(userid) ON DELETE CASCADE

select * from JOBSEEKER
drop table COMPANY
select * from UNGTUYEN join CONGVIEC on UNGTUYEN.jobid = CONGVIEC.jobid
select * from CONGVIEC

select * from UNGTUYEN
select * from ACCOUNT  ac join JOBSEEKER js on ac.userid=js.userid
delete from ACCOUNT where userid = 'baobao04'

drop table UNGTUYEN
drop table CONGVIEC

drop table BAIDANG
drop table TAIKHOAN

SELECT *
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME = 'TAIKHOAN'
AND CONSTRAINT_TYPE = 'CHECK';

alter table BAIDANG alter column ngaydang varchar(10)
select * from ACCOUNT
insert into BAIDANG values ('FD1234', N'Tuyển dụng', N'Tuyển TTS IT', N'Tuyển dụng TTS IT đã tốt nghiệp', '17/03/2024', 'xuanbao2302')

alter table CONGVIEC add userid varchar(255) constraint FK_CONGVIEC_TK foreign key references TAIKHOAN(userid)
select * from CONGVIEC

insert into CONGVIEC values ('CV001', 'Dev', '50000000', 'CNTT', 'Tuyen nv', 'Dai hoc', 'xuanbao2302')

alter table TAIKHOAN add constraint CK__TAIKHOAN__email__6E01572D check (email like '%@%')

update ACCOUNT set matkhau = 'xuanbao04' where userid = 'xuanbao'
delete from ACCOUNT where userid = 'hsacademy'
update CONGVIEC set trangthai = 'rejected' where jobid = 'FPT1'

delete from UNGTUYEN

select * from ACCOUNT
select * from JOBSEEKER
select * from COMPANY
select * from CONGVIEC
select * from UNGTUYEN


delete from UNGTUYEN
delete from CONGVIEC
delete from COMPANY
delete from JOBSEEKER
delete from ACCOUNT

delete from COMPANY
update CONGVIEC set mucluong = 30000000 where jobid = 264895