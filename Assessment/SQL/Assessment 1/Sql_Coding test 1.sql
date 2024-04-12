Create Database Coding_Test1
Use Coding_Test1;



----Question 5-----------------------
-----Create table for Employee---
Create Table Employee(
Employee_ID int primary key,
Employee_Name Varchar(40) Not Null,
Employee_Age int,
Employee_Adrdress Varchar(30),
Salary float
);

-----insert the table----
Insert into  Employee(Employee_ID,Employee_Name,Employee_Age,Employee_Adrdress,Salary)values(1,'Ramesh', 32,'Ahemdabad',2000.00),(2,'Khilan', 25, 'Delhi', 1500.00),(3,'Kaushik',23, 'Kota', 2000.00),(4,'Chaitali',25,'Mumbai',6500),(5,'Hardhik',27,'Bhopal',8500),(6,'Komal', 22, 'MP' ,Null),(7,'Muffy', 24, 'Indore',NUll);
Select *from Employee;
-----Display the Names of the Employee in lower case, whose salary is null----------- 
Select  lower(Employee_Name)  from Employee where Salary is null;

-----------Question 3--------
Create Table Customer(
Id int primary key,
Cname varchar(25),
Age numeric,
Caddress varchar(25),
Salary decimal(10,2)
);
----insert the table-----
Insert into Customer(Id,Cname,Age,Caddress,Salary )values(1,'Ramesh', 32,'Ahemdabad',2000.00),(2,'Khilan', 25, 'Delhi', 1500.00),(3,'Kaushik',23, 'Kota', 2000.00),(4,'Chaitali',25,'Mumbai',6500),(5,'Hardhik',27,'Bhopal',8500),(6,'Komal', 22, 'MP', 4500),(7,'Muffy', 24, 'Indore',10000);

-----Display the Name for the customer from above customer table who live in same address which has character o anywhere in address----------
Select*from Customer;
Select Cname, Caddress from Customer where Caddress like '%o%';

-------------Question 4------------
-----Create table orders----
Create  Table Orders(
O_Id int ,
Dates date,
Customer_Id int Foreign key references CUSTOMER(Id),
Amount numeric,
);
 -----insert the table-----------
Insert into Orders(O_Id ,Dates,Customer_Id,Amount)values(102,'2009/10/08 00:00:00',3,3000),(100,'2009/10/08 00:00:00',3,1500),(101,'2009/11/20 00:00:00',2,1560),(103,'2008/05/20 00:00:00',4,2060);
Select * from Orders;
---------Write a query to display the Date,Total no of customer placed order on same Date-----------
Select Count (Distinct Customer_Id) as Total_Customer
From Orders
Group by Dates;

----------Question 6------------
------Create Table from Student Details-------------
Create table Student_Details(
RegisterNo int, 
Name varchar(50),
Age numeric,
Qualification varchar(10),
MobileNo numeric(10),
Mail_id unique,
Location varchar(10),
Gender varchar(7),
);


----------Question 1--------------------------
--Create table for books-------
Create Table Books(
Id int primary key,
Title varchar(50), 
Author varchar(50), 
Isbn numeric,
Published_date date
);
 
--Insert the table----------
insert into Books(Id,Title,Author,Isbn,Published_date)values(1,'My first SQL book','Mary Parker',981483029127,'2012-02-22 12:08:17'),(2,'My Second SQL book','John Mayer',857300923713,'1972-07-03 09:22:45'),(3,'MY Third SQL book','Cary Flint',523120967812,'2015-10-18 14:05:44');
Select * from Books;
----------.Write a query to fetch the details of the books written by author whose name ends with er----------------------
Select * from Books where Author like '%er';

--------Question 1 (b)---------
Create table Reviews(
Id int,
BookId int,
Reviewer_Name  varchar(30),
Content varchar(50),
Rating int,
Published_date datetime,
foreign key (BookId) references Books(id)
);
--------insert the table---------------
insert into Reviews(id,BookId,Reviewer_Name,Content,Rating,Published_date)values(1,1,'John Smith','My first Review',4,'2017-12-10 05:50:11'),(2,2,'John Smith',' My Second Review',5,'2017-10-13 15:05:12'),(3,2,'Alice Review','Another Review',1,'2017-10-22 23:47:10')
 Select* from Reviews;
 ------------Display the Title ,Author and ReviewerName for all the books from the above table------------------
Select b.Title, b.Author, r.Reviewer_Name from Books b join Reviews r on b.Id = r.BookId;


----------Question 2--------------
 ---------Display the reviewer name who reviewed more than one book.--------------------------
Select Reviewer_Name from Reviews group by Reviewer_Name having COUNT(BookId) > 1;

