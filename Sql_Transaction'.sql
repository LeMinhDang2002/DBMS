-- Tài Khoản------------------------------------------------------------------------------------------

drop proc if exists transaction_proc_add_account

create proc transaction_proc_add_account @account char(15), @password char(15), @typeaccount char(10)
as 
begin
	begin transaction
		begin try
			insert into TAIKHOAN(IdTK, Matkhau, IdLTK) values (@account, @password, @typeaccount)
			commit transaction
		end try
		begin catch
			rollback transaction
		end catch
end
go

exec transaction_proc_add_account '0382255077', '123', 'LTK1'

drop proc if exists transaction_proc_delete_account

create proc transaction_proc_delete_account @account char(15)
as
begin
	begin transaction
		begin try
			delete from TAIKHOAN where IdTK = @account
			commit transaction
		end try
		begin catch
			rollback transaction
		end catch
end
go

exec transaction_proc_delete_account '0382255077'

drop proc if exists transaction_proc_update_account

create proc transaction_proc_update_account @account char(15), @password char(15), @typeaccount char(10)
as
begin
	begin transaction
		begin try
			update TAIKHOAN
			set Matkhau = @password,
			IdLTK = @typeaccount
			where IdTK = @account
			commit transaction
		end try
		begin catch
			rollback transaction
		end catch
end
go
exec transaction_proc_update_account '123', '1234', 'LTK3'

-- Tài Khoản----------------------------------------------------------------------------------------------

-- Cửa Hàng--------------------------------------------------------------------------------------------------------


-----------------Phần này nếu có rồi thì không cần chạy lại-----------------------------------------------
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
----------------------------------------------------------------------------------------------------------

drop proc if exists transaction_proc_add_store
create proc transaction_proc_add_store @Address nvarchar(40), @ManagerID char(10)
as
begin
	begin transaction
		begin try
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

			commit transaction
		end try
		begin catch
			rollback transaction
		end catch
end
go

-- Hình như là có nhân viên trước rồi mới thêm 1 của hàng được
select * from NHANVIEN
exec transaction_proc_add_store '...','...'

drop proc if exists transaction_proc_update_store 
create proc transaction_proc_update_store 
@IdCH CHAR(3),
@Address  NVARCHAR(100),
@IDMgr Char(10)
as
begin
	begin transaction
		begin try
			update CUAHANG
			SET Diachi =@Address,
				IdQL = @IDMgr
			WHERE IdCH=@IdCH
			exec Update_IDCH_for_Emp @IdCH, @IDMgr

			commit transaction
		end try
		begin catch
			rollback transaction
		end catch
end
go

exec transaction_proc_update_store 'CH1', 'Vo Van Ngan', 'NV001'


-----------------Xóa Cua Hàng---------------------------------
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


drop proc if exists transaction_proc_Delete_Store
create proc transaction_proc_Delete_Store @IDCH varchar(10)
as
begin
	begin transaction
		begin try
			exec dbo.proc_Update_Info_Store_Of_Employee @IDCH
			exec dbo.proc_Update_Info_Store_Of_Warehouse @IDCH

			update CUAHANG
			set IdQL = null
			where IdCH = @IDCH

			delete CUAHANG where IdCH = @IDCH
			commit transaction
		end try
		begin catch
			rollback transaction
		end catch
end

select * from CUAHANG
exec dbo.transaction_proc_Delete_Store 'CH2'


-- Cửa Hàng--------------------------------------------------------------------------------------------------------

-- Khách Hàng---------------------------------------------------------------------------------------------------------


drop proc if exists transaction_proc_add_cus
create proc transaction_proc_add_cus @name nvarchar(30), @point int, @phonenumber char(11)
as
begin
	begin transaction
		begin try
			Insert into KHACHHANG(Hovaten,Diem,Sdt) VALUES (@name, @point, @phonenumber)
			commit transaction
		end try
		begin catch
			rollback transaction
		end catch
end
go

exec transaction_proc_add_cus 'abc', '10','0909090909'

drop proc if exists transaction_proc_del_cus
create proc transaction_proc_del_cus @phonenumber char(11)
as
begin
	begin transaction
		begin try
			delete from KHACHHANG
			where Sdt = @phonenumber
			commit transaction
		end try
		begin catch
			rollback transaction
		end catch
end
go

exec transaction_proc_del_cus '0909090909'

drop proc if exists transaction_proc_update_cus
create proc transaction_proc_update_cus @ID_cus char(10), @name nvarchar(30), @point int, @phonenumber char(11)
as
begin
	begin transaction
		begin try
			UPDATE KHACHHANG
			SET	Hovaten = @name,
				Diem = @point,
				Sdt = @phonenumber
			where IdKH = @ID_cus
			commit transaction
		end try
		begin catch
			rollback transaction
		end catch
end
go

select * from KHACHHANG
exec transaction_proc_update_cus 'KH001','Nguyen Vi', '10', '0945881905'


-- Khách Hàng---------------------------------------------------------------------------------------------------------