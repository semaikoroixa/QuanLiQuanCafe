use QuanLyQuanCafe
go
insert dbo.TableFood
(name,status)
values 
(N'Bàn 1'--name-nvarchar(100)
N'Trống'--status--nvarchar(100)
)
--them ban
declare @i int =0

while @i<=10
begin
	insert dbo.TableFood(name)values (N'Bàn '+cast (@i as nvarchar(100)))--name-nvarchar(100)
	set @i=@i+1
end 
go
alter proc USP_GetTableList
	as select * from dbo.TableFood
	go
update dbo.TableFood set status =N'Có người' where id = 6
	exec dbo.USP_GetTableList
	go

	--them catagory
insert dbo.FoodCategory(name)
values (N'Đồ ăn' --name -nvarchar(100)
)
insert dbo.FoodCategory(name)
values (N'Cafe' --name -nvarchar(100)
)
insert dbo.FoodCategory(name)
values (N'Trà' --name -nvarchar(100)
)
insert dbo.FoodCategory(name)
values (N'Soda' --name -nvarchar(100)
)
insert dbo.FoodCategory(name)
values (N'Đá xay' --name -nvarchar(100)
)insert dbo.FoodCategory(name)
values (N'Khác' --name -nvarchar(100)
)

--Thêm món ăn
insert dbo.Food(name,idCategory,price)
values(N'Hướng dương',--name-nvarchar(100)
1,--idCategory--int
15000)--price -int )
insert dbo.Food(name,idCategory,price)
values(N'Bò khô',1,25000 )
insert dbo.Food(name,idCategory,price)
values(N'Khô gà',1,25000 )
insert dbo.Food(name,idCategory,price)
values(N'Chân gà rang muối',1,40000 )
insert dbo.Food(name,idCategory,price)
values(N'Xoài lắc',1,25000 )
insert dbo.Food(name,idCategory,price)
values(N'Đen đá',2,25000 )
insert dbo.Food(name,idCategory,price)
values(N'Sữa đá',2,25000 )
insert dbo.Food(name,idCategory,price)
values(N'Bạc xỉu',2,30000 )
insert dbo.Food(name,idCategory,price)
values(N'Cafe cốt dừa',2,35000 )
insert dbo.Food(name,idCategory,price)
values(N'Cafe trứng',2,40000 )
insert dbo.Food(name,idCategory,price)
values(N'Latte',2,40000 )
insert dbo.Food(name,idCategory,price)
values(N'Machiatto',2,35000 )
insert dbo.Food(name,idCategory,price)
values(N'Trà đào cam xả',3,30000 )
insert dbo.Food(name,idCategory,price)
values(N'Trà oolong',3,25000 )
insert dbo.Food(name,idCategory,price)
values(N'Trà chanh',3,18000 )
insert dbo.Food(name,idCategory,price)
values(N'Trà tắc nha đam',3,22000 )
insert dbo.Food(name,idCategory,price)
values(N'Trà vải nhiệt đới',3,30000 )
insert dbo.Food(name,idCategory,price)
values(N'Trà ổi hồng',3,30000 )
insert dbo.Food(name,idCategory,price)
values(N'Deep blue',4,35000 )
insert dbo.Food(name,idCategory,price)
values(N'Violet',4,35000 )
insert dbo.Food(name,idCategory,price)
values(N'Sunset',4,35000 )
insert dbo.Food(name,idCategory,price)
values(N'Ruby',4,35000 )
insert dbo.Food(name,idCategory,price)
values(N'Rose',4,35000 )
insert dbo.Food(name,idCategory,price)
values(N'Matcha đá xay',5,40000 )
insert dbo.Food(name,idCategory,price)
values(N'Chocolate dynamic',5,40000 )
insert dbo.Food(name,idCategory,price)
values(N'Chanh tuyết',5,40000 )
insert dbo.Food(name,idCategory,price)
values(N'Chocolate smoothie',5,40000 )
insert dbo.Food(name,idCategory,price)
values(N'Nước chanh',6,25000 )
insert dbo.Food(name,idCategory,price)
values(N'Nước ép theo mùa',6,35000 )

--Thêm bill
insert dbo.Bill
(DateCheckIn,DateCheckOut,idTable,status)
values(GETDATE() ,--datecheckin-date
GETDATE(), --datecheckout-date)
3, --idTable-int
0) --status-int

insert dbo.Bill
(DateCheckIn,DateCheckOut,idTable,status)
values(GETDATE() ,--datecheckin-date
GETDATE(), --datecheckout-date)
3, --idTable-int
0) --status-int

insert dbo.Bill
(DateCheckIn,DateCheckOut,idTable,status)
values(GETDATE() ,--datecheckin-date
GETDATE(), --datecheckout-date)
4, --idTable-int
1) --status-int
insert dbo.Bill
(DateCheckIn,DateCheckOut,idTable,status)
values(GETDATE() ,--datecheckin-date
GETDATE(), --datecheckout-date)
5, --idTable-int
1) --status-int
insert dbo.Bill
(DateCheckIn,DateCheckOut,idTable,status)
values(GETDATE() ,--datecheckin-date
GETDATE(), --datecheckout-date)
4, --idTable-int
0) --status-int
insert dbo.Bill
(DateCheckIn,DateCheckOut,idTable,status)
values(GETDATE() ,--datecheckin-date
GETDATE(), --datecheckout-date)
6, --idTable-int
0) --status-int

--Them billinfo
insert dbo.BillInfo
(idBill,idFood,count)
values(4, --idBill-int
5, --idFood-int
2) --count-int
insert dbo.BillInfo
(idBill,idFood,count)
values(3, --idBill-int
3, --idFood-int
4) --count-int
insert dbo.BillInfo
(idBill,idFood,count)
values(5, --idBill-int
5, --idFood-int
1) --count-int

insert dbo.BillInfo
(idBill,idFood,count)
values(4, --idBill-int
1, --idFood-int
1) --count-int
insert dbo.BillInfo
(idBill,idFood,count)
values(3, --idBill-int
4, --idFood-int
2) --count-int
insert dbo.BillInfo
(idBill,idFood,count)
values(7, --idBill-int
6, --idFood-int
1) --count-int
insert dbo.BillInfo
(idBill,idFood,count)
values(10, --idBill-int
6, --idFood-int
1) --count-int
insert dbo.BillInfo
(idBill,idFood,count)
values(11, --idBill-int
3, --idFood-int
2) --count-int
go







select f.name, bi.count,f.price,f.price*bi.count as totalPrice from dbo.BillInfo as bi,dbo.Bill as b,dbo.Food as f  
where bi.idBill=b.id and bi.idFood=f.id and b.status = 0 and b.idTable=3
	

	select * from dbo.Bill where idTable=3 and status=1
	select * from dbo.BillInfo where idBill=4

	select * from dbo.Food
	select * from dbo.FoodCategory
	select * from dbo.Food where idCategory=3
	
	go
create proc USP_InsertBill
	@idTable int 
	as 
	begin
	insert dbo.Bill
	(DateCheckIn,
	DateCheckOut, 
	idTable,
	status,
	discount
	)

	values(GETDATE(), --DateCheckIn-date
			GETDATE(), --DateCheckOut-date
	@idTable, --idTable-int
	0, 
	0) --int
	end
	go

	create proc USP_InsertBillInfo
	@idBill int,@idFood int, @count int
	as 
	begin 

	end
	go
		
create proc USP_InsertBillInfo
@idBill int,@idFood int, @count int
as
begin
	declare @isExitsBillInfo int --ktra  bill ton tai hay chua
	declare @foodCount int =1
	select @isExitsBillInfo =id,@foodCount=b.count 
	from dbo.BillInfo as b
	where idBill=@idBill and idFood=@idFood --ktra xem bill co bang bill dua vao khong va thuc an co ton tai trong bill khong 
	if(@isExitsBillInfo>0)
	begin
	declare @newCount int=@foodCount+@count
		if(@newCount>0)
			update dbo.BillInfo set count=@foodCount+@count where idFood = @idFood
		else
			delete dbo.BillInfo where idBill=@idBill and idFood=@idFood
	end
	else
	begin
		insert dbo.BillInfo
			(idBill,idFood,count)
		values(@idBill, --idBill-int
			@idFood, --idFood-int
			@count) --count-int
	end
	end
	go

--update dbo.Bill set status=1 where id=1

go
alter trigger UTG_UpdateBillInfo
on dbo.BillInfo for insert, update
as
begin
	declare @idBill int
	select @idBill=idBill from Inserted
	declare @idTable int
	select @idTable = idTable from dbo.Bill where id = @idBill and status = 0
	declare @count int
	select @count =Count(*) from dbo.BillInfo where idBill = @idBill
	if (@count>0)
	update dbo.TableFood set status =N'Có người' where id = @idTable
	else
	update dbo.TableFood set status =N'Trống' where id = @idTable
end
go


create trigger UTG_UpdateBill
on dbo.Bill for update
as
begin
	declare @idBill int
	select @idBill= id from inserted
	declare @idTable int
	select @idTable = idTable from dbo.Bill where id = @idBill 
	declare @count int = 0
	select @count =count(*) from dbo.Bill where idTable = @idTable and status =0
	if (@count=0)
		update dbo.TableFood set status = N'Trống' where id=@idTable
end
go

alter table dbo.Bill
add discount int

update dbo.Bill set discount =0
go

--declare @idBillNew int =78

--select id into IDBillInfoTable from dbo.BillInfo where idBill=@idBillNew

--declare @idBillOld int =77

--update dbo.BillInfo set idBill =@idBillOld where id in (select * from IDBillInfoTable)

alter proc USP_SwitchTable --dang tuong doi loi phan idTable
@idTable1 int, @idTable2 int 
as
begin

	declare @idFirstBill int
	declare @idSecondBill int

	declare @isFirstTableEmpty int =1 --0 empty
	declare @isSecondTableEmpty int =1 

	select @idSecondBill=id from dbo.Bill where idTable=@idTable2 and status=0
	select @idFirstBill=id from dbo.Bill where idTable=@idTable1 and status=0 

	if(@idFirstBill = null)
	begin
		insert dbo.Bill
			(DateCheckIn,
			DateCheckOut,
			idTable,
			status)
		values(GETDATE() ,--datecheckin-date
			GETDATE(), --datecheckout-date)
			@idTable1, --idTable-int
			0) --status-int
			
			select @idFirstBill=max(id) from dbo.Bill where idTable=@idTable1 and status=0
			
	end
		select @isFirstTableEmpty=count(*) from dbo.BillInfo where idBill = @idFirstBill
		if(@idSecondBill = null)
	begin
		insert dbo.Bill
			(DateCheckIn,DateCheckOut,idTable,status)
		values(GETDATE() ,--datecheckin-date
			GETDATE(), --datecheckout-date)
			@idTable2, --idTable-int
			0) --status-int
			
			select @idSecondBill=max(id) from dbo.Bill where idTable=@idTable2 and status=0
		
	end
		select @isSecondTableEmpty=count(*) from dbo.BillInfo where idBill = @idSecondBill

 
	select id into IDBillInfoTable from dbo.BillInfo where idBill=@idSecondBill


	update dbo.BillInfo set idBill =@idSecondBill where idBill=@idFirstBill

	update dbo.BillInfo set idBill= @idFirstBill where id in (select * from IDBillInfoTable)

	drop table IDBillInfoTable
	if (@isFirstTableEmpty=0)
		update dbo.TableFood set status = N'Trống' where id = @idTable2
	if (@isSecondTableEmpty=0)
	update dbo.TableFood set status = N'Trống' where id = @idTable1
end
go

exec dbo.USP_SwitchTable @idTable1 =5,
@idTable2=7
go








select * from dbo.TableFood
	select * from dbo.Bill
	select * from dbo.BillInfo
	select * from dbo.Food 
	select * from dbo.FoodCategory
	select * from dbo.TableFood
update dbo.TableFood set status = N'Trống'
delete dbo.BillInfo
delete dbo.Bill

alter table dbo.Bill add totalPrice float
go 

alter proc USP_GetListBillByDate
	@checkIn date,@checkOut date
as
begin
	select t.name as [Tên bàn], b.totalPrice[Tổng tiền],DateCheckIn as [Ngày vào],DateCheckOut as [Ngày ra],discount as [Giảm giá]
	from dbo.Bill as b, dbo.TableFood as t
	where  DateCheckIn>=@checkIn and DateCheckOut<=@checkOut and b.status =1
	and t.id = b.idTable 
end
go



