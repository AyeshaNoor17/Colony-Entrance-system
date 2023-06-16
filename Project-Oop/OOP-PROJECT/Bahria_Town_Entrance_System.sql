CREATE database Bahria_Town_Entrance_System1;
DROP DATABASE Bahria_Town_Entrance_System1;

CREATE TABLE tbl_Visitor
(
	CNIC varchar(20) Primary Key,
	Name varchar(50) Not Null,
	PhoneNumber varchar(20) unique,
	VisitNo int,
	HouseNo int Foreign Key References tbl_Resident(HouseNo)
);
DROP TABLE tbl_Visitor;
CREATE TABLE tbl_Resident
(
	CNIC varchar(20) NOT NULL Unique,
	Name varchar(50) NOT NULL,
	R_Address varchar(20),
	CardNo int unique NOT NULL,
	PhoneNo varchar(20) unique,
	HouseNo int Primary key
);
Drop TABLE tbl_Resident;

INSERT INTO tbl_Resident(CNIC,Name,R_Address,CardNo,PhoneNo,HouseNo)
values('1355-34','ayesha','manawala',23,'3466',434),('1234-56','BJ','H Block',34,'+92300456723',261);
SELECT * FROM dbo.tbl_Resident
Select * FROM dbo.tbl_Visitor