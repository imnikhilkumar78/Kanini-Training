use Northwind
select * from [Order Details]
select (((UnitPrice*Quantity)*Discount)/100) as 'Price' from [Order Details]
--1
select OrderID,sum((UnitPrice*Quantity)-(((UnitPrice*Quantity)*Discount)/100)) as 'SubTotal' 
from [Order Details] 
group by OrderID

--2
select * from Orders
select OrderID, YEAR(ShippedDate) as 'Shipped Year' from Orders

--3
select * from Employees
select E.EmployeeID,E.Country, sum((UnitPrice*Quantity)-(((UnitPrice*Quantity)*Discount)/100)) as 'Sales Amount'
from Employees E join Orders O on E.EmployeeID=O.EmployeeID join [Order Details] OD on O.OrderID=OD.OrderID 
group by E.EmployeeID, E.Country

--4 A simple query to get an alphabetical list of active products could be:
select * from Products
select distinct b.*, a.CategoryName
from Categories a 
inner join Products b on a.CategoryID = b.CategoryID
where b.Discontinued = '0'
order by b.ProductName;

--5
--a
select distinct a.CategoryID, 
    a.CategoryName,  
    b.ProductName,
    sum(round(y.UnitPrice * y.Quantity * (1 - y.Discount), 2)) as ProductSales
from [Order Details] y
inner join Orders d on d.OrderID = y.OrderID
inner join Products b on b.ProductID = y.ProductID
inner join Categories a on a.CategoryID = b.CategoryID
where d.OrderDate between '1997/1/1' and '1997/12/31'
group by a.CategoryID, a.CategoryName, b.ProductName
order by a.CategoryName, b.ProductName, ProductSales;

--b
select  a.CategoryName, 
    b.ProductName, 
    sum(c.ExtendedPrice) as ProductSales
from Categories a 
inner join Products b on a.CategoryID = b.CategoryID
inner join 
(
    select distinct y.OrderID, 
        y.ProductID, 
        x.ProductName, 
        y.UnitPrice, 
        y.Quantity, 
        y.Discount, 
        round(y.UnitPrice * y.Quantity * (1 - y.Discount), 2) as ExtendedPrice
    from Products x
    inner join [Order Details] y on x.ProductID = y.ProductID
    --order by y.OrderID
) c on c.ProductID = b.ProductID
inner join Orders d on d.OrderID = c.OrderID
where d.OrderDate between '1997/1/1' and '1997/12/31'
group by a.CategoryID, a.CategoryName, b.ProductName
order by a.CategoryName, b.ProductName, ProductSales;


select OrderID, ProductID, UnitPrice from [Order Details]

union
select ProductID, SupplierID, UnitPrice from Products

--DATE

CAST(GETDATE() AS DATE)

select YEAR(ShippedDate) as 'Shipped Year' from Orders
select GETDATE()

SELECT DATEADD(DAY,1,'2021-01-01') as 'Add 1 Day',
   DATEADD(WEEK,1,'2021-01-01') as 'Add 1 Week',
   DATEADD(MONTH,1,'2021-01-01') as 'Add 1 Month',
   DATEADD(YEAR,1,'2021-01-01') as 'Add 1 Year';

SELECT DATEDIFF(DAY,'2021-01-01','2021-02-01') as 'Number of Days in January',
   DATEDIFF(WEEK,'2021-01-01','2022-01-01') as 'Weeks in the Year',
   DATEDIFF(MONTH,'2021-01-01','2022-01-01') as 'Months in the Year',
   DATEDIFF(YEAR,'1900-01-01',GETDATE()) as 'Years Since 1900';

--NNumber

SELECT ABS(-243.5);

SELECT ACOS(0.25);

SELECT CEIL(25.75);

SELECT DEGREES(1.5);

SELECT FLOOR(25.75);

--STRING


