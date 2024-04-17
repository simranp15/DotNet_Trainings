Create database Employeemanagement
drop database Employeemanagement
Use Employeemanagement;

Create table Employee_Details (
    Empno int primary key,
    EmpName varchar(50) not null,
    Empsal numeric(10,2) check(Empsal >= 25000),
    Emptype char(1) check (Emptype in ('P', 'C'))
);

Create proc Add_Employeedetails
    @EmpName VARCHAR(50),
    @Empsal NUMERIC(10,2),
    @Emptype CHAR(1)
as
begin
    declare @Add_Empno int;

    ---- Generate the empno ---------
    select @Add_Empno = isnull(max(Empno), 0) + 1 from Employee_Details;
    -- Insert new employee -----
    insert into Employee_Details (Empno, EmpName, Empsal, Emptype)values(@Add_Empno, @EmpName, @Empsal, @Emptype)
end;

 exec Add_EmployeeDetails 'Shruti', 50000.00, 'C';


 Select* from Employee_Details

