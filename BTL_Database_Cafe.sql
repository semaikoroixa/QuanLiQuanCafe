
 USE QuanLyQuanCafe
 GO
 -- Food
 -- Table
 -- FoodCategory
 -- Account 
 -- Bill
 -- BillInfo
 CREATE TABLE TableFood
 (
	id INT IDENTITY PRIMARY KEY,
	name nvarchar(100) not null default N'Bàn chưa có tên',
	status nvarchar(100) not null default N'Trống', --Trống () - Có người() 
 )
 GO
 create table Account
 (  
	UserName nvarchar(100)not null primary key,
	DisplayName nvarchar(100) not null default N'Staff',
	PassWord nvarchar(255)not null default 0,
	Type int not null default 0 --1.Admin--2.Staff
 )
 go
 create table FoodCategory
 (
	id INT IDENTITY PRIMARY KEY,
	name nvarchar(100) not null default N'Chưa đặt tên',
 )
 go
 create table Food
 (
 	id INT IDENTITY PRIMARY KEY,
	name nvarchar(100) not null default N'Chưa đặt tên',
	idCategory INT not null,
	price float not null,
	foreign key (idCategory) references dbo.FoodCategory(id)
 )
 go
 create table Bill 
 (
 id int identity primary key,
 DateCheckIn date not null,
 DateCheckOut date not null,
 idTable int not null,
 status int not null --1.da thanh toan --0.chua thanh toan
 foreign key (idTable) references dbo.TableFood(id)
 )
 go

 create table BillInfo
 (
 id int identity primary key,
 idBill int not null,
 idFood int not null,
 count int not null default 0,
 foreign key (idBill) references dbo.Bill(id),
 foreign key (idFood) references dbo.Food(id)
 )
 go