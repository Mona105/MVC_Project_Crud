select * from Locations;
select * from Students;

insert into Locations values ('Noida');
insert into Locations values ('Delhi');
insert into Locations values ('Sikandrabad');
insert into Locations values ('Lucknow');
insert into Locations values ('Gzb');

insert into Students values ('Mona','mona123@gmail.com','Female','234567',1),
('Pinku','pinku3@gmail.com','Female','4567832',2),
('Harshit','harshit67@gmail.com','Male','987634',3),
('Ashant','ashant89@gmail.com','Male','98531345',4),
('Yash','yash80@gmail.com','Male','5678889',5)
drop table Locations;
drop table Students;