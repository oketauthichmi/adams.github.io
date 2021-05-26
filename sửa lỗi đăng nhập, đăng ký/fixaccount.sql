




CREATE PROC LOGIN1
@useName nvarchar(100), @passWord nvarchar(100)
as
begin

select * from DangNhap where TaiKhoan=@useName and password =@passWord

end
go
