use Northwind
--1
select * from Customers

--2
select * from Products
select ProductName, UnitPrice from Products

--3
select * from Suppliers
Select ProductName from Products where SupplierID = (Select SupplierID from Suppliers where CompanyName='Exotic Liquids')

--4
select* from Orders
select CustomerID, count(*) as 'Number Of Orders' from Orders group by CustomerID

--5
select * from Shippers
select CustomerID, count(*) as 'Number Of Orders' from Orders where ShipName='Hanari Carnes' group by CustomerID 

--6
select CustomerID, count(*) as 'Number Of Orders' from Orders group by CustomerID order by count(*) desc

--7
select SupplierID, avg(UnitPrice) as ' Average Price Of Products' from Products group by SupplierID

--8
select SupplierID, avg(UnitPrice) as ' Average Price Of Products' from Products group by SupplierID

--9
select * from [Order Details]
select OrderID, UnitPrice*Quantity as 'Total Price' from [Order Details]

--10
select * from Categories
select * from Products where CategoryID In (Select CategoryID from Categories where CategoryName='Condiments') 

--11
Select P.ProductName, S. CompanyName from Products P join Suppliers S on P.SupplierID=S.SupplierID

--12
select ContactName , count(*) as 'Number of sales' from Customers c join Orders oon c.CustomerID = o.CustomerIDgroup by ContactName

--13
select * from Customers
select ProductName,CategoryName,ContactName 'Supplier Name',CompanyName 'Customer Name' from Categories ca join Products p on ca.CategoryID = p.CategoryIDjoin Suppliers s on p.SupplierID = s.SupplierID 

--14
select * from Shippers
select S.CompanyName as 'ShipperName', C.CompanyName as 'Customer Name', P.ProductName, concat(E.Lastname,' ',E.FirstName) as 'Employee Name' 
from Shippers S join Orders O on S.ShipperID=O.ShipVia join Customers C on C.CustomerID=O.CustomerID join [Order Details] OD on O.OrderID=OD.OrderID join Products P on OD.ProductID=P.ProductID join Employees E on O.EmployeeID=E.EmployeeID

--15
select P.ProductName, OD.UnitPrice*OD.Quantity as 'Total Sales' from Products P join [Order Details] OD on P.ProductID=OD.ProductID 


select companyName 'ShipperName', ContactName'Customer Name',ProductName,concat(FirstName,'',lastname) from Employees e  join orders o on e.EmployeeID=o.EmployeeID  join Customers c on c.CustomerID=o.CustomerID  join Products p on p.ProductID=o.OrderID select productname,sum(unitprice*QuantityPerUnit) 'Total Price' from Products group by productname