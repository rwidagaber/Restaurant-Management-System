Create database RMS

create table category(
	catID int primary key identity,
	catName varChar(50)
)
create table users(
	userID int primary key identity,
	username varChar(50),
	upass varchar(10) not null,
	uname varchar(50) not null,
	uphone varchar(20),
)

create table tables(
	tId int primary key identity,
	tName varchar(15)
)

create table tblMain
(
MainID int primary key identity,
aDate date,
aTime varchar(15),
TableName varchar(10),
WaiterName varchar(15),
status varchar(15),
orderType varchar(15),
total float,
recevied float,
change float,

)

create table tblDetails
(
DetailID int primary key identity,
MainID int,
proID int,
qty int,
priec float,
amount float
)

create table staff(
	staffID int primary key identity,
	sName varchar(50),
	sPhone varchar(15),
	sRole varchar(50),
	username varChar(50),
	upass varchar(10) not null,
)

create table product(
	pID int primary key identity,
	pName varChar(50),
	pPrice float,
	categoryID int FOREIGN KEY REFERENCES category(catID),
	pImage image,
)



