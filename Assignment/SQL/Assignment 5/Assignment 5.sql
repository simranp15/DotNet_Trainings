Use Assignment2
Select* from EMP 


---------1. Write a T-Sql based procedure to generate complete payslip of a given employee with respect to the following condition
   --a) HRA as 10% of Salary----
   --b) DA as 20% of Salary----
   --c) PF as 8% of Salary---
   --d) IT as 5% of Salary---
   --e) Deductions as sum of PF and IT---
   --f) Gross Salary as sum of Salary,HRA,DA---
   --g) Net Salary as Gross Salary - Deductions-----

 Create or alter proc Employee_payslip(@EmployeeName varchar(25))
as 
begin
    declare @Salary Decimal(10, 2);
    declare @HRA Decimal(10, 2);
    declare @DA Decimal(10, 2);
    declare @PF Decimal(10, 2);
    declare @IT Decimal(10, 2);
    declare @Deductions Decimal(10, 2);
    declare @GrossSalary Decimal(10, 2);
    declare @NetSalary Decimal(10, 2);

-------- Calculate values according to given data------
Select @Salary = Sal from EMP where Ename  = @EmployeeName
    set @HRA = @salary * 0.10;  
    set @DA = @salary * 0.20;
    set @PF = @salary * 0.08 ;
    set @IT = @salary * 0.05;
    set @Deductions = @PF + @IT;
    set @GrossSalary = @Salary + @HRA + @DA;
    set @NetSalary = @GrossSalary - @Deductions;
	
--------print the value---------
Print'Employee name: ' + cast(@EmployeeName as varchar(20))
Print'Salary :-  ' + cast(@Salary as varchar(30))
Print'HRA :-  ' + cast(@HRA as varchar(30))
Print'DA :-  ' + cast(@DA as  varchar(30))
Print'PF :-  ' + cast(@PF as varchar(20))
Print'IT :-  ' + cast(@IT as varchar(20))
Print'Deductions :-  ' + cast(@Deductions as varchar(20))
Print'Gross Salary :-  ' + cast(@GrossSalary as varchar(20))
Print'Net Salary :-  ' + cast(@NetSalary as varchar(20))
Print 'Here is the Employee_payslipdetail'
end
 
 ------call the proc---------
exec Employee_payslip 'King'