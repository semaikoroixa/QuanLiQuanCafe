create database KhachHang
go
create table tblKhachHang
(makh varchar(255),
tenkh varchar(255),
diachi varchar(255),
sdt float
);
insert into tblKhachHang(makh,tenkh,diachi,sdt)
values('23as','Ly Thanh Long','49 Thuy Linh Hoang Mai','0987654321'),
('2112ad','Truong Anh Ngoc','Italia','0997752112'),
('400ak','Tam Gia Huy','Pho Dich Vong','19001002');
select * from tblKhachHang