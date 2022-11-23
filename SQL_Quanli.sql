drop function if exists func_show_CH
create function func_show_CH()
returns table
as
	return(select * from CUAHANG)
go

DROP PROC IF EXISTS proc_ShowCH
GO
create proc proc_ShowCH
as
begin
	select * from func_show_CH()
end
go
exec proc_ShowCH
------------------------------------------------------------



drop function if exists func_Check_Info
create function func_Check_Info(@str NVARCHAR(50) )
returns int
AS
BEGIN
	DECLARE @num int
	SELECT @num = COUNT(*)
		FROM CUAHANG
		WHERE IdQL = @str
	IF (@num = 0) 
		RETURN 0
	RETURN 1
END
GO

create proc proc_Check_Info @str nvarchar(40)
as
begin
	select dbo.func_Check_Info(@str)
end
select dbo.func_Check_Info('NV009')

------------------------------------------------
----------------------------------------------------


-- Cập nhật ID của hàng cho nhân viên, VD khi thăng cấp cho nhân viên lên làm quản lí
create proc Update_IDCH_for_Emp @IDCH char(5), @IDNV char(10)
as
begin
	Update NHANVIEN
	set IdCH = @IDCH
	where IdNV = @IDNV
end
go
--exec Update_IDCH_for_Emp 'CH6', 'NV006'

drop proc if exists proc_Add_CH 
create proc proc_Add_CH @Address nvarchar(40), @ManagerID char(10)
as
begin
	declare @tmp int
	set @tmp = dbo.func_Check_Info(@ManagerID)
	if @tmp = 0
		insert into CUAHANG(Diachi,IdQL) values(@Address, @ManagerID)
		DECLARE @idch CHAR(5)
		SELECT @idch = ch.IdCH
			FROM CUAHANG ch
			WHERE ch.IdQL = @ManagerID
		-- gọi lại hàm cập nhật thông tin của nhân viên
		--EXEC ...
		exec Update_IDCH_for_Emp @idch, @ManagerID
end
go

exec proc_Add_CH 'Phan Dang Luu', 'NV001'

--exec proc_Add_CH 'Le Van Viet', 'NV006'
--------------------------------------------------------------------------------
---------------------------------------------------------------------------------


DROP PROC IF EXISTS proc_UpdateCH
GO
create proc proc_UpdateCH
@IdCH CHAR(3),
@Address  NVARCHAR(100),
@IDMgr Char(10)
as
begin
	update CUAHANG
	SET Diachi =@Address,
		IdQL = @IDMgr
	WHERE IdCH=@IdCH
	exec Update_IDCH_for_Emp @IdCH, @IDMgr
end
go

exec proc_UpdateCH 'CH1', 'Vo Van Ngan', 'NV001'
-------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------

drop function if exists func_show_CH_str
create function func_show_CH_str(@str nvarchar(40))
returns table
as
	return(select * from CUAHANG where Diachi = @str or IdCH = @str or IdQL = @str)
go

drop proc if exists proc_showCH_str
create proc proc_showCH_str @str nvarchar(40)
as 
begin
	select * from func_show_CH_str(@str)
end
go


--Xóa Cửa Hàng-----------

drop proc if exists proc_Update_Info_Store_Of_Employee
create proc proc_Update_Info_Store_Of_Employee @IDCH varchar(10)
as
begin
	update NHANVIEN
	set IdCH = '0'
	where IdCH = @IDCH
end

drop proc if exists proc_Update_Info_Store_Of_Warehouse
create proc proc_Update_Info_Store_Of_Warehouse @IDCH varchar(10)
as
begin
	update KHO_TEST -- đổi tên Table lại
	set IdCH = 'CH1'
	where IdCH = @IDCH
end


drop proc if exists proc_Delete_Store
create proc proc_Delete_Store @IDCH varchar(10)
as
begin
	exec dbo.proc_Update_Info_Store_Of_Employee @IDCH
	exec dbo.proc_Update_Info_Store_Of_Warehouse @IDCH

	update CUAHANG
	set IdQL = null
	where IdCH = @IDCH

	delete CUAHANG where IdCH = @IDCH
end

select * from CUAHANG
exec dbo.proc_Delete_Store 'CH4'

select * from CUAHANG
select * from NHANVIEN
select * from KHO_TEST

--Xóa Cửa Hàng-----------



-----------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------
--Tài Khoan
drop function if exists func_show_acc
create function func_show_acc()
returns table
as
	return( select  tk.IdTK, tk.Matkhau, tk.IdLTK, ltk.TenLTK
			from TAIKHOAN tk, LOAITAIKHOAN ltk
			where tk.IdLTK = ltk.IdLTK		)
go

drop proc if exists proc_show_acc
create proc proc_show_acc
as
begin
	select * from dbo.func_show_acc()
end
go

exec proc_show_acc
--------------------------------------------------------------------------
------------------------------------------------------------------------
drop function if exists func_show_acc_str
alter function func_show_acc_str(@str char(15))
returns table
as
	return( select  tk.IdTK, tk.Matkhau, tk.IdLTK, ltk.TenLTK
			from TAIKHOAN tk, LOAITAIKHOAN ltk
			where tk.IdLTK = ltk.IdLTK	and tk.IdTK = @str	)
go

drop proc if exists proc_show_acc_str
create proc proc_show_acc_str @str char(15)
as
begin
	select * from dbo.func_show_acc_str(@str)
end
go
----------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------

drop proc if exists proc_add_account
create proc proc_add_account @account char(15), @password char(15), @typeaccount char(10)
as
begin
	insert into TAIKHOAN(IdTK, Matkhau, IdLTK) values (@account, @password, @typeaccount)
end
go

--------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------

drop proc if exists proc_del_account
create proc proc_del_account @account char(15)
as
begin
	delete from TAIKHOAN where IdTK = @account
end
go

--------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------
drop proc if exists proc_update_account
create proc proc_update_account @account char(15), @password char(15), @typeaccount char(10)
as
begin
	update TAIKHOAN
	set Matkhau = @password,
		IdLTK = @typeaccount
	where IdTK = @account
end
go

-------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------

DROP FUNCTION IF EXISTS func_show_cus
GO
create function func_show_cus()
returns table
as
return(select * from KHACHHANG)	
go

DROP proc if exists show_list_cus
go
create proc show_list_cus
as
begin	
	select*from func_show_cus()
end
go

------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------

DROP FUNCTION IF EXISTS func_show_cus_str
GO
create function func_show_cus_str(@str char(10))
returns table
as
return(select * from KHACHHANG
		where IdKH = @str)	
go

DROP proc if exists show_list_cus_str
go
create proc show_list_cus_str @str_Cus char(10)
as
begin
	select*from func_show_cus_str(@str_Cus)
end
go

------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------

DROP Proc if exists add_customer
go

create proc add_customer @name nvarchar(30), @point int, @phonenumber char(11)
as
begin	
	Insert into KHACHHANG(Hovaten,Diem,Sdt) VALUES (@name, @point, @phonenumber)
end
go
------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------

DROP proc if exists del_customer
go

create proc del_customer @phonenumber char(11)
as 
begin
	delete from KHACHHANG
	where Sdt = @phonenumber
end
go

---------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------

DROP proc if exists update_customer
go

create proc update_customer @ID_cus char(10), @name nvarchar(30), @point int, @phonenumber char(11)
as
begin
	UPDATE KHACHHANG
SET	Hovaten = @name,
	Diem = @point,
	Sdt = @phonenumber
where IdKH = @ID_cus
end
go