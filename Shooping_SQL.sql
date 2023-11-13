create database shoping
go
use shoping
go

ALTER table Buy
add [count] INT

create table Category
(
id int identity primary key not null,
[name] nvarchar(30) not null,
[count] int not null,
Buy_id int,
foreign key (Buy_id) references Buy(id)
)

create table Product
(
id int identity primary key not null,
[name] nvarchar(30) not null,
[count] int not null,
Category_id int,
foreign key (Category_id) references Category(id)
)
