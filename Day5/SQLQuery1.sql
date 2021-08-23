use pubs

--compiles and generate the execution plan once
--Encapsulate the underlying tables
-- No data Injection- more secure

create procedure proc_example
as
BEGIN
		print 'hello world'
END

execute proc_example

create procedure proc_example_parameter(@username varchar(20))
as
BEGIN
		print 'hello ' +@username
END

execute proc_example_parameter 'JAMES'

create procedure proc_example_parameter_out(@username varchar(20), @msg varchar(100) out)
as
BEGIN
		set @msg = 'hello ' +@username
END

declare
	@mymsg varchar(100)
	exec proc_example_parameter_out 'James', @mymsg out
	print @mymsg

create proc proc_GET_AUTHORS
as
BEGIN
	select * from authors
END

exec proc_GET_AUTHORS

create proc proc_get_author_by_id(@aid varchar(20))
as
	select * from authors where au_id = @aid

exec proc_get_author_by_id '172-32-1176'

create proc proc_get_title_by_id(@tid varchar(20))
as
	select * from titles where title_id = @tid

exec proc_get_title_by_id 'BU1111'

CREATE PROC proc_FullName_Authors_By_Id1(@aid VARCHAR(20), @fullname VARCHAR(50) out)
AS
 SET @fullname = (SELECT CONCAT(au_fname,' ',au_lname) FROM dbo.authors WHERE au_id=@aid)
    DECLARE
    @fullname1 VARCHAR(50)
    EXEC proc_FullName_Authors_By_Id1 '172-32-1176', @fullname1 OUT
    PRINT @fullname1



create proc proc_get_total_qty(@tid varchar(20),@tqty int out, @tprice float out)
as
begin
	set @tqty = (select sum(qty) from sales where title_id=@tid)
	set @tprice = (select price from titles where title_id=@tid)
end

declare
	@price float, @qty int, @amy float
Begin
 		exec proc_get_total_qty 'BU1111', @price out, @qty out
		set @amy = @price * @qty
		print 'The book Price is '+cast(@price as varchar(100))
		print 'The quantity sold is '+cast(@qty as varchar(100))
		print '____________________________'
		print 'The total amount is '+cast(@amy as varchar(100))
end


create table tblemp
(id int identity(101,1) primary key,
name varchar(20),
age int)



create proc insert_records_in_tblemp(@ename varchar(20), @age int)
as
begin
	insert into tblemp(name, age) values (@ename, @age)
end

execute insert_records_in_tblemp 'JAMES',20

create proc update_records_in_tblemp(@eid int)
as
begin
	update tblemp 
	set age = 20
	where id = @eid
end

execute update_records_in_tblemp 101

create function fn_sample()
returns varchar(10)
as
begin
	return 'hello'
end

select dbo.fn_sample()

create function fn_sample_with_value(@name varchar(20))
returns varchar(10)
as
begin
	return 'hello '+@name
end

select dbo.fn_sample_with_value('James')

select * from titles

CREATE FUNCTION fn_remaining_amount(@advance FLOAT, @price Float)
RETURNS float    
AS
BEGIN
DECLARE
    @net FLOAT
    SET @net = @advance-@price
    RETURN @net
END
SELECT dbo.fn_remaining_amount(advance,price) 'Remaining Amount' FROM dbo.titles

--Table valued Function which returns a table from a function

create function fn_table_sample(@id int, @name varchar(20))
returns @myTable table (f1 int, f2 varchar(20))
as
begin
	insert into @myTable values(@id, concat('hi ', @name))
	return
end

select * from dbo.fn_table_sample(1, 'James')

create function fn_GetSalesDetails(@tid varchar(20))
returns @saleTable table (ordernumber varchar(10), quantity int, price float)
as
begin
	insert into @saleTable
	select ord_num, qty, Price from sales join titles on sales.title_id=titles.title_id
	where sales.title_id=@tid
	return
end

select * from dbo.fn_GetSalesDetails('BU1032')


