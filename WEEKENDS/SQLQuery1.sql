create database moviestore
use moviestore

Create table Movie_Category 
(category_id int primary key, 
 category_name varchar(20))

CREATE TABLE Movies (
    movie_id int IDENTITY(1,1) PRIMARY KEY,
    movie_title varchar(255) NOT NULL,
    category_id int foreign key references Movie_Category(category_id),
    movie_desc varchar(500),
	price float  
);


create table Member_type 
(id varchar(10) primary key,
type_name_ varchar(10),
max_mov_rent int)



 Create table Members (
member_id int identity(201,1)  primary key,
category_id int foreign key references Movie_Category (category_id),
phone_no varchar(10),
member_name varchar(20),
Type_id varchar(10) foreign key references Member_type(id))

CREATE TABLE Dependents (
    dep_id int IDENTITY(1,1) PRIMARY KEY,
    dep_fname varchar(50),
    dep_lname varchar(50),
    member_id int foreign key references Members(member_id))

Create table Formats(
format_id int primary key,
format_name varchar(20))

Create table Movie_Format
(MovFor_id int primary key,
movie_id int foreign key references Movies(movie_id),
format_id int foreign key references Formats(format_id))

Create table Rental
(rent_id int primary key,
Rent_date date,
Return_date date,
Member_id int foreign key references Members(member_id))

Create table RentalDetails
(rentdetail_id int primary key,
movie_id  int foreign key references Movies(movie_id),
member_id  int foreign key references Members(member_id),
dep_id  int foreign key references Dependents(dep_id))
