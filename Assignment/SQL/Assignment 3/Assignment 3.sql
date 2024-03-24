Use Assignment2
Select* from EMP
Select*from DEPT

-------1. Retrieve a list of MANAGERS. ------------------
Select * from EMP where Job = 'Manager'; 

-------2.Find out the names and salaries of all employees earning more than 1000 per month.----------
Select  Ename ,Sal from EMP where Sal >1000;

------3.Display the names and salaries of all employees except JAMES-------------
Select Ename , Sal from EMP where Ename not in ('James');

------------4. Find out the details of employees whose names begin with ‘S’.---------------------- 
Select *from EMP  where Ename like 'S%';

-------------5. Find out the names of all employees that have ‘A’ anywhere in their name.-----------------
Select Ename from EMP where  Ename like '%A%';

--------6. Find out the names of all employees that have ‘L’ as their third character in their name ------------------------
Select Ename from EMP where Ename like '__L%';

--------7. Compute daily salary of JONES.-------------
Select  Ename,Sal/Day(EOMONTH(getdate())) as daily_sal from emp where  Ename='Jones';

-----------8. Calculate the total monthly salary of all employees.----------------------------------  
Select Ename as 'Employee name' ,sum(Sal)  as ' Monthly salary' from EMP group by rollup(ename);

------------9. Print the average annual salary .-----------------
Select  Avg(sal) as 'Average Salary' from EMP;

--------10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30.--------------------------
Select Ename ,Job, Sal ,DeptNo from EMP where Job!= 'Salesman' and DeptNo = 30;

--------------11. List unique departments of the EMP table.-----------------------------
Select Distinct DeptNo from EMP;

-----------12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively--------------------
Select Ename as Employee ,Sal as  MonthlySalary from EMP where Sal > 1500 and  DeptNo in (10,30);

-------------13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000-------------------------- 
Select Ename, Sal, Job from  EMP where Job not in ('MANAGER','ANALYST') and  Sal not in (1000,3000,5000);

----------------14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%.-------------- 
Select Ename,Sal,Comm from EMP where Comm>(Sal*0.1);

-------15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.---------------------------- 
Select * from EMP where Ename like '%L%L' and DeptNo =30 or  Mgr_id = 7782; 

---------16. Display the names of employees with experience of over 30 years and under 40 yrs Count the total number of employees.--------------------------
Select Ename from Emp where DateDiff(year,HireDate,Getdate()) between 30 and 39 
Select Count(*) as 'total number of employee' from EMP where DateDiff(year,HireDate,Getdate()) between 30 and 39;

-------17. Retrieve the names of departments in ascending order and their employees in descending order.------------------
Select d.DeptNo,e.ename from DEPT d  join emp e  on  d.DeptNo=e.DeptNo order by d.Dname asc , e.ename desc

--------------18. Find out experience of MILLER.-----------------
Select DateDiff(year,HireDate,Getdate()) from EMP where Ename ='MILLER';