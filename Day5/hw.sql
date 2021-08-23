use pubs

create table salary
(salId int identity(101,1) primary key,
basic float,
hra float,
da float,
deductions float)

create table employeesalary
(empID int identity(201,1) primary key,
salId int foreign key references salary(salId),
date date,
extra float,
saldate date)

drop table employeesalary

create proc proc_insert_in_salary(@basic float, @hra float, @da float, @deductions float)
as
begin
	insert into salary(basic,hra,da, deductions) values (@basic, @hra, @da, @deductions)
end

execute proc_insert_in_salary 5000,1000,500, 1500
execute proc_insert_in_salary 6000,1000,500, 1600
execute proc_insert_in_salary 4500,1000,400, 1300
execute proc_insert_in_salary 8000,1200,700, 1800
execute proc_insert_in_salary 5000,1000,500, 1600
execute proc_insert_in_salary 5000,9000,500, 1200
execute proc_insert_in_salary 10000,2000,1000, 25000

select * from salary


create proc proc_insert_in_empsalary(@salId int, @date date, @extra float, @saldate date)
as
begin
	insert into employeesalary(salId,date,extra, saldate) values (@salId, @date, @extra, @saldate)
end

select * from employeesalary


execute proc_insert_in_empsalary 101,'2020-01-20', -500, '2021-08-22'
execute proc_insert_in_empsalary 102,'2020-04-20', 500, '2021-08-22'
execute proc_insert_in_empsalary 103,'2020-03-13', 1500, '2021-08-22'
execute proc_insert_in_empsalary 104,'2020-12-14', -2500, '2021-08-22'
execute proc_insert_in_empsalary 101,'2020-10-29', 3500, '2021-08-22'

alter function fn_totalsalary()
returns @TotalSalaryTable table (empID int, totalSalary float)
as
begin
	insert into @TotalSalaryTable 
	select empID, (S.basic+S.hra+S.da)-(S.deductions+E.extra)
	from employeesalary E join salary S on E.salID=S.salId
	return
end

select * from dbo.fn_totalsalary()


alter function fn_totalsalary1(@empID int)
returns @TotalSalaryTable1 table (empID int, totalSalary float)
as
begin
	insert into @TotalSalaryTable1 
	select empID, (S.basic+S.hra+S.da)-(S.deductions+E.extra)
	from employeesalary E join salary S on E.salID=S.salId
	where empID=@empID
	return
end

select * from dbo.fn_totalsalary1(201)

alter proc proc_getTotalSal(@empID int)
as
begin
	declare @totalsal table (empID int, totalSalary float)
	insert into @totalsal values (dbo.fn_totalsalary1(@empID))
	select * from @totalsal
end

execute proc_getTotalSal 201



--IF
BEGIN
    DECLARE @x INT = 10,
            @y INT = 20;

    IF (@x > 0)
    BEGIN
        IF (@x < @y)
            PRINT 'x > 0 and x < y';
        ELSE
            PRINT 'x > 0 and x >= y';
    END			
END

--FOR
DECLARE @cnt INT = 0;

WHILE @cnt < 10
BEGIN
   PRINT @cnt;
   SET @cnt = @cnt + 1;
END;

PRINT 'DONE';
GO

