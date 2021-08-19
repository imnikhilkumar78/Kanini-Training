use pubs

select pub_id, pub_name from publisherswhere pub_id not in(select distinct pub_id from titles)

select pub_name as 'Publisher Name', count(title_id) as 'Number of books published'
from publishers p left outer join titles t
on p.pub_id=t.pub_id
group by pub_name
order by 2

select title 'Book Name', concat(au_fname,' ', au_lname) as 'Authors Name'
from  titleauthor ta 
right outer join authors a  on a.au_id = ta.au_id
left outer join  titles t on t.title_id=ta.title_id
order by 1

select title 'Book Name', t.price*s.qty as 'Total Sales Amount' from titles t left join sales s on t.title_id=s.title_id order by 2

create table Cust
( id int identity(1,1) primary key,
name varchar(20),
reffBy int)

alter table Cust
add constraint fk_reff foreign key(reffBy) references Cust(id)

insert into Cust(name, reffBy) values('James' , null)

insert into Cust(name, reffBy) values('Jill' , 1)

insert into Cust(name, reffBy) values('Jack' , 1)

insert into Cust(name, reffBy) values('Phill' , 2)

-- Customer name and referred by name

select name,reffby from Cust

select C.name 'Customer Name', ref.name as 'Referred By' from
Cust C left outer join Cust ref
on C.reffBy = ref.id


select t.title_id,title from titles t join titleauthor ta on t.title_id=ta.title_id
union
select a.au_id, concat(au_fname,' ', au_lname) as 'Authors Name' from authors a join titleauthor ta on a.au_id=ta.au_id