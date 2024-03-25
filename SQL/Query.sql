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
	ten nvarchar(max),
	ngaythanhlap varchar(10),
    giayphep nvarchar(255),
    ngdungdau nvarchar(255),
    diachi nvarchar(255),
    sdt nvarchar(10) check (len(sdt) = 10),
    masothue nvarchar(255),
    linhvuc nvarchar(255),
    email nvarchar(255) check (email like '%@%'),
	thongtin nvarchar(max),
)

create table CONGVIEC(
	jobid varchar(255) constraint PK_CONGVIEC primary key,
	userid varchar(255) constraint FK_CONGVIEC_TK foreign key references ACCOUNT(userid),
	tencv nvarchar(255) not null,
	ngaytao varchar(10),
	vitri nvarchar(255),
	mucluong nvarchar(255),
	linhvuc nvarchar(255),
	phucloi nvarchar(255),
	yeucau nvarchar(max),
	trangthai nvarchar(255),
)

create table UNGTUYEN(
	userid varchar(255) constraint FK_UNGTUYEN_TK foreign key references ACCOUNT(userid),
	jobid varchar(255) constraint FK_UNGTUYEN_CV foreign key references CONGVIEC(jobid),
	tencv nvarchar(255),
	thoigian varchar(10),
	congty varchar(255) constraint FK_UNGTUYEN_CP foreign key references COMPANY(userid),
	trangthaiphanhoi nvarchar(255),
	constraint PK_UNGTUYEN primary key (userid, jobid)
)
go

create trigger job_delete
on CONGVIEC
for delete
as
	delete from UNGTUYEN where jobid in (select jobid from deleted)
go

create trigger acc_delete
on ACCOUNT
for delete
as
begin
	delete from JOBSEEKER where userid in (select userid from deleted);
	delete from COMPANY where userid in (select userid from deleted);
end
go

create trigger company_delete
on COMPANY
for delete
as
begin
	delete from CONGVIEC where userid in (select userid from deleted)
	delete from UNGTUYEN where userid in (select userid from deleted)
end
go

CREATE TRIGGER after_update_ungtuyen
ON UngTuyen
AFTER UPDATE
AS
BEGIN
    DECLARE @maCV varchar(255)
    DECLARE @trangThaiPhanHoi VARCHAR(255)

    SELECT @maCV = jobid, @trangThaiPhanHoi = trangthaiphanhoi
    FROM inserted

    IF @trangThaiPhanHoi = 'accepted'
    BEGIN
        UPDATE CongViec
        SET trangthai = 'accepted'
        WHERE jobid = @maCV
    END
END



drop trigger ungtuyen_trangthai

drop table COMPANY
select * from UNGTUYEN
select * from CONGVIEC

delete from ACCOUNT

drop table UNGTUYEN
drop table CONGVIEC

drop table BAIDANG
drop table TAIKHOAN

SELECT *
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME = 'TAIKHOAN'
AND CONSTRAINT_TYPE = 'CHECK';

alter table BAIDANG alter column ngaydang varchar(10)
select * from BAIDANG
insert into BAIDANG values ('FD1234', N'Tuyển dụng', N'Tuyển TTS IT', N'Tuyển dụng TTS IT đã tốt nghiệp', '17/03/2024', 'xuanbao2302')

alter table CONGVIEC add userid varchar(255) constraint FK_CONGVIEC_TK foreign key references TAIKHOAN(userid)
select * from CONGVIEC

insert into CONGVIEC values ('CV001', 'Dev', '50000000', 'CNTT', 'Tuyen nv', 'Dai hoc', 'xuanbao2302')

alter table TAIKHOAN add constraint CK__TAIKHOAN__email__6E01572D check (email like '%@%')
