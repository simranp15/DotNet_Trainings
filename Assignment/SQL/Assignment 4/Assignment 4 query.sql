Create Database Assignment4
Use Assignment4


 ---------------1.Write a T-SQL Program to find the factorial of a given number.-----------------------
declare @num int = 8
declare @fact int = 1
-- Calculate  the factorial
while @num > 1
begin
    set @fact = @fact * @num
    set @num = @num - 1
end
print 'factorial is: ' + cast(@fact as varchar(max))



 ------------------2.	Create a stored procedure to generate multiplication tables up to a given number.------------------------------
 Create or alter proc generate_multi(@val int)
 as
   begin
   declare @Multiplier int=1
   while @Multiplier <= 10   
      begin 
      print (cast(@val as varchar(30))+'* ' +cast(@Multiplier as varchar(30))+' ='+cast((@val*@Multiplier)as varchar(30)))
      set @Multiplier +=1; 
    end
end

-------call the procedure------------
exec generate_multi @val = 6;


-----------3.Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc------------------------------
         ------------Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation------------------------------------------ 

------Create table for Employee--------
 Create table Employee(
 Employee_Name varchar(20),
 Employee_Location varchar(20),
 Employee_Id int
 );
 select* from Employee
 -----insert table Employee---------
 insert into Employee(Employee_Name,Employee_Location,Employee_Id)values('Siya','Indore',121),('Karan','Delhi',122);
 
 -------Create table from Holiday------------------
 Create table Holiday(
 Holiday_Date date,
 Holiday_Name varchar(20),
 );
 select *from holiday;

 ---insert the holiday table------
 insert into Holiday(Holiday_Date,Holiday_Name)values( '2024-01-01' , 'Happy New Year'),('2024-01-26' , 'Independence Day'),('2024-03-25' ,'Holi'),('2024-10-02', 'Gandhi Jayanti');

 ----------Create Trigger-------------

Create or alter trigger Data_Manipulation_Trigger
ON Employee 
After insert ,update,delete
as
begin
    declare @GetHolidayValue int;
    set @GetHolidayValue=(select count(*)from Holiday where Holiday_Date=convert(date,getdate()))
    if @GetHolidayValue > 0
    begin 
	     declare @RaiseException  varchar(100)
		 declare @HolidayName varchar(30)
		 select @HolidayName= Holiday_Name from Holiday where Holiday_Date=convert(date,getdate());
	     set @RaiseException = 'There is a Holiday called '+ @HolidayName+' so you can not perform any dml operation';
         raiserror(@RaiseException, 16, 1);
         return
    end
end
  ------Update the Employee table------------
  ---insert the holiday table because date is changed----
insert into holiday values
('2024-03-26','Testing day')
Update Employee set Employee_Id='143' where Employee_Id=121
select *from Employee