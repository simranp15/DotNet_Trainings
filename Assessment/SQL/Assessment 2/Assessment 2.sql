Create Database Assessment2
Use Assessment2


------1. Write a query to display your birthday( day of week)-----------
Create table Display_Birthday(
    Namee varchar(20),
    Birthday date
);
select* from Display_Birthday
insert into Display_Birthday(Namee ,Birthday)values('Shrija','2002-05-15');

select  Namee,Birthday,datename(weekday, Birthday) as dayofweek
from Display_Birthday where Namee = 'Shrija';


---------2.	Write a query to display your age in days----------------------
----Use above table-----
select Namee,Birthday, datediff(day, Birthday, getdate()) as ageindays
from Display_Birthday;



------3.Write a query to display all employees information those who joined before 5 years in the current month--------------
  --------(Hint : If required update some HireDates in your EMP table of the assignment)----------

  Use Assignment2
  Select*from EMP
 -----update the hiredate-------
 update EMP set HireDate = '2019-03-15' where Empno in (7839);
 update EMP set HireDate = '2019-03-16' where Empno in (7782);
 update EMP set HireDate = '2019-03-27' where Empno in (7934);
 ----who joined before 5 years in the currrent month---------
select*from EMP where HireDate <= dateadd(year, -5, getdate()) and month(HireDate) = month(getdate());



--  4.Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction------------
--	a. First insert 3 row--------------
--	b. Update the second row sal with 15% increment-------------------  
--  c. Delete first row---------------------
----------After completing above all actions how to recall the deleted row without losing increment of second row-----------------

Use Assessment2
Create table Employee(
empno int primary key,
ename varchar(25),
sal decimal(10,2),
doj date
);
Select* from Employee

--	a. First insert 3 row--------------
insert into Employee(empno, ename, sal, doj)values(101, 'Sita', 15000.00, '2022-03-16'),(102, 'Rita', 12000.00, '2021-03-11'),(103, 'Gita', 9000.00, '2022-01-03');
--b.Update the second row sal with 15% increment-----------  
begin transaction;
		update Employee set sal = sal * 0.15 where empno = 102;
		commit transaction;
--c. Delete first row.
		begin tran;
		delete from Employee where empno = 101;
		commit tran;

-- 5.Create a user defined function calculate Bonus for all employees of a  given job using following conditions-----------------------------
--	a.For Deptno 10 employees 15% of sal as bonus.------------------------------------------
--	b.For Deptno 20 employees  20% of sal as bonus------------------------------------------
--	c.For Others employees 5%of sal as bonus.-----------------------------------------------
  
Use Assignment2
Select * from Dept
Select* from EMP

Create function Bonus(@DeptNo int, @Sal decimal(10, 2))
returns decimal(10, 2)
as
begin
      declare @Bonus float;
    --	a.For Deptno 10 employees 15% of sal as bonus.------------------------------------------
    if @Deptno = 10
        set @Bonus = @Sal * 0.15;
 --	b.For Deptno 20 employees  20% of sal as bonus------------------------------------------
    else if @Deptno = 20
        set @Bonus = @Sal * 0.2;
--	c.For Others employees 5%of sal as bonus.-----------------------------------------------
    else
        set @Bonus = @Sal * 0.05;
    return @Bonus;
end;

select Empno, Ename, Sal, Deptno,dbo.Bonus(deptno, sal) as Bonus from EMP;









 