use pubs

create table tbTriggerCheck
(f1 int identity(1,1) primary key,
f2 varchar(20))

create trigger trg_checkInsert
on tbTriggerCheck
for insert
as
begin
	print 'Hello from Insert trigger'
end

Insert into tbTriggerCheck(f2) values ('One')

create trigger trg_checkInsert1
on tbTriggerCheck
for insert
as
begin
	declare
	@name varchar(10)
	set @name = (select f2 from inserted)
	print 'Hello'+@name
end

Insert into tbTriggerCheck(f2) values ('Jack')

--inserted is a dynamic table which gets created while insertion and gets deleted automatically

--employeesalary --salary


create table salary
(salId int identity(101,1) primary key,
basic float,
hra float,
da float,
deductions float)

select * from salary

create table tblemp1
(id int identity(1,1) primary key,
name varchar(20))

insert into tblemp1(name) values('Jack')
insert into tblemp1(name) values('Jill')
insert into tblemp1(name) values('Hill')
insert into tblemp1(name) values('Josh')

create table emplsal
(empid int references tblemp1(id),
salId int references salary(salId),
salDate date,
totalSal float)

create trigger trg_InsertEmpSal
on emplsal 
for insert
as
begin
	declare
	@totalsalary float
	set @totalsalary = (select (basic+hra+da-deductions) from salary where salId = (select salId from inserted))
	update emplsal 
	set totalsal = @totalsalary
	where empid = (select empid from inserted)
	and
	salId = (select salId from inserted)

end

insert into emplsal(empid,salId,salDate) values (1, 103, GETDATE())


select * from emplsal

declare
@empId int, @salId varchar(4), @totalSal float, @salDate date
print 'Salary Details'
declare cur_empsal cursor for
select * from emplSal

open cur_empsal

fetch next from cur_empsal into @empId,@salId, @salDate, @totalSal
while (@@FETCH_STATUS=0)
	begin
	print 'Employee ID '+cast(@empId as varchar(5))
	print 'Salary ID '+@salId
	print 'Salary '+cast(@totalSal as varchar(5))
	print 'Salary Date ' +cast(@salDate as varchar(20))
	fetch next from cur_empsal into @empId, @salId, @salDate, @totalSal
end

close cur_emplsal
Deallocate cur_empsal


create table anotherEmpl
(id int primary key,
name varchar(20))

create trigger insert_in_another_empl
on tblemp1
for insert
as
begin
declare
@id int, @name varchar(20)
set @id=(select id from inserted)
set @name=(select name from inserted)
	insert into anotherEmpl values(@id, @name)
end

insert into tblemp1(name) values('Nik')

select * from anotherEmpl

--cursor


sp_help sales

declare @bookname varchar(50);
declare @bprice float;
declare @author varchar(50);
declare @quantity float;
declare @tprice float;

declare cursor_book cursor for
Select t.title, t.price, a.au_fname, s.qty, (t.price*s.qty)
from titles t join titleauthor ta on t.title_id=ta.title_id 
join authors a on ta.au_id=a.au_id 
join sales s on t.title_id=s.title_id ;

open cursor_book;

fetch next from cursor_book into @bookname, @bprice, @author, @quantity, @tprice;
while @@FETCH_STATUS = 0
	begin
	print 'Book Name '+@bookname
	print 'Book Price '+cast(@bprice as varchar(50))
	print 'Book Author '+@author
	print 'Quantity '+cast(@quantity as varchar(50))
	print 'Total Price '+cast(@tprice as varchar(50))
	fetch next from cursor_book into @bookname, @bprice, @author, @quantity, @tprice;
	end

close cursor_book
deallocate cursor_book