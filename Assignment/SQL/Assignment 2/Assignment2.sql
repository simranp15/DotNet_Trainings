Create database Assignment2
Use Assignment2;

-- Create table Department-------
Create table DEPT (
DeptNo int primary key,
Dname varchar(50),
Loc varchar(40)
);


-----Inserting Dept table-------------
Select*from DEPT
Insert into DEPT (DeptNo, Dname, Loc)values
(10, 'ACCOUNTING', 'NEW YORK'),(20, 'RESEARCH', 'DALLAS'),(30, 'SALES', 'CHICAGO'),(40, 'OPERATIONS', 'BOSTON');


----------Create Employee Table----------
CREATE TABLE EMP (
Empno int PRIMARY KEY,
Ename varchar(50), 
Job varchar(50), 
HireDate date,
Mgr_id int, 
Sal numeric(10),
Comm int,
DeptNo int, 
);

----Add constraints-----------

Alter table EMP
Add constraint fk_DeptNo foreign key(DeptNo) references DEPT(DeptNo)

Select* from EMP
-- Insert Employee Data-------------
Insert into EMP(Empno, Ename, Job, Mgr_id,	HireDate, Sal, Comm, DeptNo)values
 (7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
 (7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30), (7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20),
 (7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30), (7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
 (7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10),(7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000, NULL, 20),
 (7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10),(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
 (7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, NULL, 20),(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
 (7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),(7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10);


-------------1. List all employees whose name begins with 'A'. ---------------------------------------
Select*from EMP where Ename like'a%';

 ------------2. Select all those employees who don't have a manager-------------------------
Select*from EMP where Mgr_id is null;

----------3. List employee name, number and salary for those employees who earn in the range 1200 to 1400-------------------------
Select* from EMP where Sal between 1200 and 1400;

------------4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise. ------------------------------
Select Deptno from DEPT where Dname='Research'
-----Update the salary----------
Update EMP set SAL = (SAL*1.1) where Deptno =20;
Select* from  EMP where Deptno=20;


------------------5. Find the number of CLERKS employed. Give it a descriptive heading----------------------
Select count(*) as "Clerks Employed " from EMP where Job = 'CLERK';

------------------6. Find the average salary for each job type and the number of people employed in each job.----------------- 
Select Job,avg(SAL) as "Average Salary", count(*) as "Number of Employees" from EMP group by Job;

-----------------7. List the employees with the lowest and highest salary------------------------------------
Select * from EMP where Sal in (Select min(Sal) from EMP) or Sal in (select max(Sal) from EMP);

-------------8. List full details of departments that don't have any employees.-------------------
Select * from DEPT where DeptNo not in (select  DeptNo from EMP);

-------9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. ---------------------
Select Ename, Sal from EMP where JOB = 'ANALYST' and Sal> 1200 and DeptNo = 20 order by Ename ASC;

------10. For each department, list its name and number together with the total salary paid to employees in that department--------------------
Select d.Dname, D.DeptNo, sum(E.Sal) as "Total Salary Paid" from DEPT D left join EMP E ON D.DeptNo = E.DEPTNO group by D.DNAME, D.DEPTNO;

---------11. Find out salary of both MILLER and SMITH.-----------------------------------
Select Ename, Sal from EMP where Ename in ('MILLER', 'SMITH');

---------12. Find out the names of the employees whose name begin with ‘A’ or ‘M’. ----------------------------------
Select * from EMP where Ename like 'a%' or Ename like 'm%';

---------------13. Compute yearly salary of SMITH.-------------------------------------- 
Select Ename, Sal * 12 as "Yearly Salary" from EMP where Ename = 'SMITH';

-------------------14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850-----------------------------
Select Ename, Sal from EMP where SAL not between 1500 and 2850;
 
---------------------15. Find all managers who have more than 2 employees reporting to them--------------------------------
Select Mgr_id from EMP Group by Mgr_id Having Count(*)>2



Create view VW
as
Select Ename ,Sal , DName from  EMP  join Dept on EMP where  job = 'IT'