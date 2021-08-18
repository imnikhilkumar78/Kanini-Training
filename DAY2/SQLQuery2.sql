create database AugKaninil17;
use AugKaninil17;

create table Areas
(area varchar(20) constraint pk_area primary key,
zip char(5))

create table Areas
(area varchar(20) primary key,
zip char(5))

sp_help Areas

alter table Areas
alter column area varchar(20) not null

alter table Areas
add constraint pk_area primary key(area)

drop table Areas

create table employees
(eid int identity(101,1) primary key,
name varchar(20),
phone varchar(15),
emp_area varchar(20) foreign key references Areas(area))

sp_help employees

create table skill
(skill varchar(20) primary key,
skill_description varchar(20))

sp_help skill

create table employee_skill
(Emp_id int foreign key references employees(eid),
skill_name varchar(20) foreign key references skill(skill),
skill_level float default(5),
primary key(Emp_id,skill_name))

sp_help employee_skill

insert into Areas values('AAA', '12345')
insert into Areas values('BBB', '12445')
insert into Areas values('CCC', '12344')
select * from Areas

insert into employees(name, phone, emp_area) values('James', '1234567890', 'AAA')
insert into employees(name, phone, emp_area) values('Jack', '1234567980', 'BBB')
drop table employees

select * from employees

insert into skill values('SQL', 'RDBMS')
insert into skill values('C', 'PLT')
insert into skill values('Java', 'Web')

select * from skill

insert into employee_skill values(101, 'SQL', 7)
insert into employee_skill values(101, 'C', 8)
insert into employee_skill values(102, 'Java', 8)
insert into employee_skill values(102, 'SQL', 8)

delete from employee_skill where Emp_id=102

select * from employee_skill

create database Flower
use Flower

create table item
(id int primary key,
name varchar(20),
Price varchar(20),
Quantity_in_stock varchar(5),
Description_ varchar(20),
SupplierID varchar(20) foreign key references supplier(id),
CategoryID varchar(20) foreign key references category(id),
ratings varchar(5))

create table itempic
(ItemID int foreign key references item(id),
PicID varchar(15) foreign key references pic(id))

create table pic
(id varchar(15),
PicLink varchar(20))

create table city
(Itemid int foreign key references item(id)
City varchar(10))

create table supplier
(id varchar(10) primary key,
name_ varchar(10),
phone varchar(10),
email varchar(10),
addresss varchar(20))

create table category
(id varchar(10) primary key,
name_ varchar(10),
description_ varchar(10))

create table ocation
(id varchar(10) primary key,
name varchar(10),
sdate date,
edate date,
description varchar(10))

create table ocationID
(occid varchar(10) foreign key references ocation(id),
itemid int foreign key references item(id),
discountPercent float)

create table customer
(id varchar(10) primary key,
name varchar(10),
DOB date,
address varchar(10)
email varchar(10),
password varchar(10))

create table wallettransaction
(customerid varchar(10) foreign key references customer(id),
type varchar(10),
amount float,
orderid varchar(10) foreign key references order(id),
orderdate date foreign key references order(order_date))
Total_amount float,
status varchar(10),
paymentmethod varchar(10),
paymentstatus varchar(10))

create table supplier_order
(SupplierOrderNumber varchar(10),
ordertrackingnumber varchar(10),
órderdate date,
price float,
status float
primary key(SupplierOrderNumber, ordertrackingnumber))

create table orderdetails
(ordertrackingnumber varchar(10),
itemid int foreign key references item(id),
orderid varchar(10) foreign key references order(id),
Quantity int,
Price float,
status varchar(10),
rating varchar(5),
expdelvdate date,




