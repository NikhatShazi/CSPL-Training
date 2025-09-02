--Page no.44 : Indexes [use MyDatabase]
--Create an index on EmployeeId column of employee table.
create index DNoINdex on Employee(EmployeeId)
GO
--Create An Index On EmpName And Job Columns Of Employee Table.
Create Index DnoJobIDX on Employee(Job Asc,EmpName Desc)
GO

--Altering an index
Alter Index Job on Employee Disable

--Deleting an index
Drop Index EmployeeId on Employee  