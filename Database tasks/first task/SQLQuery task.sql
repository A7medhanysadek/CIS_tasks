create database Company
on
(
	name= company_dat,
	filename='C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER1\MSSQL\DATA\companydat.mdf',
	size=10,
	maxsize=50,
	filegrowth=5
)
log on
(
	name = company_log,
	filename ='C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER1\MSSQL\DATA\saleslog.ldf',
	size=10,
	maxsize=50,
	filegrowth=5
);
--------------------------------------
use Company
go
--------------------------------------
create table Employees
(
	ID int primary key,
	Name varchar(50) not null,
	Salary numeric(5,2) not null
);
--------------------------------------
insert into Employees(ID,Name,Salary)
values(1,'ahmed',500.00),(2,'mohammed',999.99);
--------------------------------------
update Employees
set salary = 600.00
where ID=2;
--------------------------------------
alter table Employees
add Department int;
--------------------------------------
update Employees
set Department = 2
where ID=2;
--------------------------------------
update Employees
set Department = 2
where ID=2;
--------------------------------------
alter table Employees
alter column Department int not null;
--------------------------------------
create table Departments
(
	Dep_id int primary key,
	Dep_name varchar(20)
)
--------------------------------------
insert into Departments(Dep_id,Dep_name)
values (1,'food'),(2,'food');
--------------------------------------
alter table Employees
add constraint dep_fk foreign key(Department)
references Departments(Dep_id);
--------------------------------------
select *
from Employees
--------------------------------------
select *
from Employees
where Salary>550.00;
--------------------------------------
update Departments
set Dep_name='electronics'
where Dep_id=2
