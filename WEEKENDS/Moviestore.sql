create database videostores

use videostores

Create table Movie_Category 
(category_id int primary key, 
category_name varchar(20))

CREATE TABLE Movies (
    movie_id int IDENTITY(1,1) PRIMARY KEY,
    movie_title varchar(255) NOT NULL,
    category_id int foreign key references Movie_Category(category_id),
movie_desc varchar(500),
	price float  
)

create table Member_type 
(mtype_id int primary key,
mtype_name  varchar(10),
max_mov_rent int)

Create table Members (
member_id int identity(201,1)  primary key,
category_id int foreign key references Movie_Category (category_id),
phone_no varchar(10),
member_name varchar(20),
mType_id int foreign key references Member_type(mtype_id))

CREATE TABLE Dependents (
    dep_id int IDENTITY(1,1) PRIMARY KEY,
    dep_fname varchar(50),
dep_lname varchar(50),
member_id int foreign key references Members(member_id)
)

Create table Formats(
format_id int primary key,
format_name varchar(20))

Create table Movie_Format
(MovFor_id int primary key,
movie_id int foreign key references Movies(movie_id),
format_id int foreign key references Formats(format_id))

Create table RentalDetails
(rentdetail_id int primary key,
movie_id  int foreign key references Movies,
member_id  int foreign key references Members(member_id),
dep_id  int foreign key references Dependents(dep_id))


Create table Rental
(rent_id int primary key,
Rent_date date,
Return_date date,
rentdetail_id int foreign key references RentalDetails(rentdetail_id) )


select len('Hello')


Insert into Movie_Category (category_id, category_name)
values
(301, 'Action'),
(302, 'Comedy'),
(303, 'Adventure'),
(304, 'Fantasy'),
(305, 'Romantic');

alter table Movies 
add  rating float


Insert into Movies (movie_title, category_id, movie_desc, rating, price)
Values

('Justice League' , 303 , 'Bruce Wayne enlists the help of his new-found ally, Diana Prince, to face an even greater enemy.', 3.8 , 100),

('Extraction'  ,301 , 'A black-market mercenary who has nothing to lose is hired to rescue the kidnapped son of an imprisoned international crime lord.' , 4.3, 150),

('Tom and Jerry', 302, 'A legendary rivalry reemerges when Jerry moves into New York City''s finest hotel on the eve of the wedding of the century, forcing the desperate event planner to hire Tom to get rid of him' , 3.3, 70),

('Rebecca', 305, 'A young newlywed arrives at her husband''s imposing family estate',  3, 160),

('Venom' , 303 , 'While trying to take down Carlton, the CEO of Life Foundation, Eddie, a journalist, investigates experiments of human trials.' , 4.4 , 150) ,

('Me Before You' ,305, 'Vivacious, unassuming Lou faces pointed questions of the heart', 3.7, 130), 

('The Tomorrow War', 303, 'A family man is drafted to fight in a future war where the fate of humanity relies on his ability to confront the past.', 3.8, 105),

('Ted 2', 302, 'John''s help to prove in court that Ted is a person and qualified to parent', 3.1, 100 );

ALTER TABLE Member_type DROP COLUMN Max_Mov_Rent;


Insert into Member_type (mtype_id, mtype_name) 
values 
(401 , 'Golden'), 
(402 , 'Bronze' );

Insert into Members (category_id, phone_no, member_name, mtype_id) 
values 
(303 , '9473846274' , 'Bharath', 401),
(301 , '9758637484' , 'Akshatha', 401),
(304 , '9748572657' , 'Chaithanya', 402),
(303 , '9974857362' , 'Bindu', 401),
(305 , '9875674843' , 'Asmal', 402),
(302 , '8498810719' , 'Bohdan Mazhuga', 402),
(301 , '8310085985', 'Victor Hugo', 401),
(302 , '9600108389', 'Tatiana Lopatchenko', 401);

DBCC CHECKIDENT(Dependents, RESEED, 101)

Insert into Dependents (dep_fname, dep_lname, member_id)
Values 
('Kavan' , 'Changappa' , 205),
('Chaitra' ,'Devraj' , 202 ),
('Dasha' ,'Buria' , 204 ),
('Vasiliy' ,'Vaselenko' , 202 ),
('Adhya', 'Manjunath' , 203 ),
('Karthik','Kumar' , 205 ),
('Svitlana' , 'Pantiushenko' , 202 ),
('Marina', 'Van' , 205 );


Insert into Formats (format_id, format_name)
Values 
(501, 'DVD'),
(502, 'VCD'),
(503, 'VHS');

Insert into Movie_Format (MovFor_id, movie_id, format_id)
Values 
(601 , 4 , 501),
(602 , 5 , 501),
(603 , 7 , 502),
(604 , 1 , 501),
(605 , 8 , 502),
(607 , 4 , 502),
(608 , 2 , 501),
(609 , 7 , 503),
(610 , 3 , 502),
(611 , 4 , 503),
(612 , 2 , 503),
(613 , 1 , 502),
(614 , 7 , 501),
(615 , 8 , 503),
(616 , 6 , 503);

alter table RentalDetails
add rent_status varchar(10)

alter table RentalDetails
add MovFor_id int references Movie_Format(MovFor_id)

Insert into RentalDetails (rentdetail_id, movie_id, member_id, dep_id, rent_status, MovFor_id)
Values
(701 , 4 , 201 , NULL , 'Rented' , 601),
(702 , 5 , 206 , NULL , 'Rented', 602),
(703 , 1 , 202 , 102  , 'Returned' , 613),
(704 , 7 , 201 , NULL , 'Returned' , 609),
(705 , 8 , 202 , 102 , 'Rented' , 605),
(706 , 2 , 205 , 107 , 'Returned' , 608),
(707 , 3 , 203 , 105 , 'Rented' , 610),
(708 , 6 , 202 , 102 , 'Rented' , 616);

Insert into Rental ( Rent_ID, Rent_date, return_date, rentdetail_id)
Values
(801 , '2021-07-07' , '2021-07-14' , 703), 
(802 , '2021-08-20' , '2021-08-24' , 701), 
(803 , '2021-08-01' , '2021-08-05' , 707), 
(804 , '2021-09-17' , '2021-09-25' , 704), 
(805 , '2021-06-25' , '2021-07-05' , 706), 
(806 , '2021-01-05' , '2021-01-12' , 702), 
(807 , '2021-10-03' , '2021-10-10' , 708), 
(808 , '2021-08-07' , '2021-08-14' , 705); 


select M.movie_id, movie_title, rent_status from Movies M inner join  RentalDetails RD on M.movie_id=RD.movie_id order by 1

select rent_status,member_id from RentalDetails where rent_status='Returned'


