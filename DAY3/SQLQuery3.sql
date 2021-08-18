use pubs
select * from titles
select title, price from titles
select title Book_Name, price Book_price from titles

select * from titles 
where price > 10


select * from titles 
where price > 5

select * from titles
where price >=5 and price <= 10

select * from titles
where price between 5 and 10

select * from titles where price>10 and type='psychology'

select title, price from titles where advance>3500

select title from titles where type ='business' or type='mod_cock'
select title from titles where type in('business','mod_cock')


select * from titles where pubdate > '1991-06-12'

select * from authors
select * from authors where state='CA' 
select * from authors where city='Oakland'or city='Salt Lake City'

select * from sales where qty > 2

select * from titles where price is null
select * from titles where price is not null

select count(au_id) as 'NUmber of Authors' from authors where state='CA'

select * from titles 

select min(price) from titles
select max(price) from titles
select avg(price) as 'Average Price' from titles

select avg(price) as 'Average Price' from titles where type in('business','mod_cook')

select type from titles
select type, avg(price) from titles
group by type 

select * from titles
select min(qty) as 'Minimum Quantity', title from sales group by title_id;

select city,count(*) as 'Number of Authors' from authors group by city

select * from titles

select count(*) as 'Number of books', avg(price) as 'Average Price'  from titles group by pub_id

select * from employee

select pub_id, min(hire_date) as'First DAte' from employee group by pub_id

select type, avg(price) from titles group by type having avg(price)>15

select pub_id,count(*) as 'Number of Employee' from employee group by pub_id having count(*)>2
select * from sales
select title_id, avg(qty) as 'Average Quantity' from sales group by title_id having avg(qty)>4

select pub_id,count(*) as 'Number of Books' from titles where type in('business','mad_cook') group by pub_id having count(*)>2

select * from titles order by price desc
select * from titles order by price

select  * from titles where price > 15 order by pubdate

select pub_id,count(*) as 'Number of Employee' from employee group by pub_id having count(*)>2 order by count(*)

select pub_id from publishers where pub_name = 'Algodata Infosystems'

select * from titles
where pub_id =(select pub_id from publishers where pub_name = 'Algodata Infosystems')

select * from titles
where pub_id in (select pub_id from publishers where country = 'USA')


select * from sales where title_id in (Select title_id from titles where price>10)select * from publishersselect * from authors where city in (select city from publishers where pub_name='Algodata Infosystems')select * from titlesselect fname from employee where pub_id in (select pub_id from titles where title= 'Straight Talk About Computers')select title, pub_name from  publishers join titles on publishers.pub_id= titles.pub_idselect concat(au_fname, ' ', au_lname) as 'Author Name', title as 'Book Name' from titles t join titleauthor ta on t.title_id=ta.title_id join authors a on a.au_id=ta.au_idselect title, t.price*s.qty as 'Total Price' from titles t join sales s on t.title_id=s.title_idselect concat(fname,' ',lname) as 'Employee Name', p.pub_name from employee e join publishers p on e.pub_id=p.pub_id