---------------{1-Join Tables}----------------
select e.Name +' who works in '+d.Dep_name+' department salary is:' as description, e.Salary
from Departments d, Employees e
where d.Dep_id=e.Department;
---------------------OR-----------------------
select e.Name +' who works in '+d.Dep_name+' department salary is:' as description, e.Salary
from Departments d join Employees e
on d.Dep_id=e.Department;
-----------{2-Aggregate Functions}------------
select AVG(Employees.Salary) as "Avrage salary for the employees"
from Employees;
------extra aggregate functions queries-------
select COUNT(*) "number of employees"
from Employees;
-----------------------------------------------
select min(Employees.Salary)"highest salary"
from Employees;
-----------------------------------------------
select max(Employees.Salary)"lowest salary"
from Employees;
----------{3-Grouping and Ordering }-----------
select Dep_name ,count(*)"no of employees"
from Departments join Employees
on Dep_id = Department
group by Dep_name
order by COUNT(*) desc;
----------{4-Selecting Top Records}------------
select top 10 Salary
from Employees
order by Salary desc;
--------------{5-Nested Queries}---------------
select Employees.Name
from Employees join Departments
on Employees.Department=Departments.Dep_id
where Departments.Dep_region in (select Dep_region from Employees where Dep_region='East');
-------------extra Nested Queries-------------
select Name,Salary
from Employees
where Salary> all (select Salary from Employees where Salary between 400 and 550)
----------------------------------------------
select Name,Salary
from Employees
where Salary> any (select Salary from Employees where Salary between 400 and 550)
-------{6-Creating and Modifying Views}-------
create view ActiveEmployees
as
select name as "active employees"
from Employees
where status='active';
select * from ActiveEmployees
------{7-Implementing Stored Procedures}------
create procedure GetEmployeeDetails
as
begin
select * from employees
end;

alter procedure GetEmployeeDetails
as
begin
select * from Employees;
end;

execute GetEmployeeDetails;
--------Stored Procedures with input---------
create procedure GetEmployeesWithname(@EmployeeName as varchar(50))
as
begin
select Employees.Name
from Employees
where Name=@EmployeeName;
end;

exec GetEmployeesWithname 'ahmed';
-------{8-Utilizing Built-in Functions}-------
select format(HireDate,'dd/MM/yyyy')		  
from Employees;								  
------{9-Creating User-defined Functions}------
create function CalculateBonus (@salary decimal(5,2))
returns decimal(5,2)
as
begin
return @salary*1.10;
end;
select Salary as "salary before",dbo.CalculateBonus(salary) as "salary after bonus"
from Employees;
-------{10-Working with Temporary Data}-------
declare @top_employees_performing table (emp_id int,emp_name varchar(20))
insert into @top_employees_performing 
select top 10 ID,Name
from Employees
order by performance desc

select * from @top_employees_performing
-----------{11-Handling Exceptions}-----------
declare @c as int ,@a int,@b int;
set @a=10;
set @b=0;
begin try
set @c=@a/@b;
print @c;
end try
begin catch
if ERROR_NUMBER()=8134
print 'you cannot divide by zero, you can enter a non zero value instead';
end catch
-------------without exception---------------
declare @c as int ,@a int,@b int;
set @a=10;
set @b=1;
begin try
set @c=@a/@b;
print 'the result is: '+ cast(@c as varchar);
end try
begin catch
if ERROR_NUMBER()=8134
print 'you cannot divide by zero, you can enter a non zero value instead';
end catch
---------{12-Implementing Triggers}----------
create or alter trigger increase_EmployeeCount
on employees
after insert
as
begin
update Departments
set EmployeeCount=EmployeeCount+1
where (select Department from inserted)=departments.dep_id;
end;


create or alter trigger decrease_EmployeeCount
on employees
after delete
as
begin
update Departments
set EmployeeCount=EmployeeCount-1
where (select Department from deleted)=departments.dep_id;
end;
-------------insertion-----------------
insert into Employees
values(6,'omar',005.00,1,'active',GETDATE(),0,null);
-------------deletion------------------
delete from Employees
where ID=6 ;
-----------checking the tables---------
select * from Departments;
select * from Employees;

----------------The End ):-------------