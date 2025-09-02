--17. Stored procedure : Page no. 52 [DB:MyDatabase]
--1.Create A Procedure that will insert a row into Department table.
Create Procedure InsertDept(@Dnm varchar(30),@sal int, @Deptno int) as
Begin
Insert into Department values(@Dnm,@Sal, @Deptno)
End
GO
Execute InsertDept tourism, 50000, 1009 
GO

--Create A Procedure To Update A Row Of Department Table.
--following query updated data in a row, where Departmentno is 1006
Create Procedure UpdateDept(@Dnm varchar(30),@sal int, @Deptno int) as
Begin
Update Department Set Deptname=@Dnm,Salary=@sal where DepartmentNo=@Deptno
End
Go
Execute UpdateDept Tourism, 50000, 1006
GO

--iii. Create A Procedure To Delete A Row From Department table.
--Follwing query deleted a row where Department Id was 9.
Create procedure DelDept(@Deptnum int) As
Delete Department Where DepartmentID=@Deptnum
GO
Execute DelDept 9
GO

Drop Procedure DelDept
Go

