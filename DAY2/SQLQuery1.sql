create database AugKaninil17;
use AugKaninil17;

create table Areas
(area varchar(20),
zip char(5))

sp_help Areas

alter table Areas
alter column area varchar(20) not null

alter table Areas
add constraint pk_area primary key(area)