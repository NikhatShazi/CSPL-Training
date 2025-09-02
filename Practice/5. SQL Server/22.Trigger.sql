--Page no.56: Triggers [DB:MyDatabase]
--1. This example will create a trigger that will restrict the user from performing DML operation on Dept table on Sunday.
Create trigger Sunday
On Department
For insert,update,delete
As begin
Declare @Day varchar(30)
Set @Day=(Select datename(dw,getdate()))
If @Day='sunday'
Begin
Print 'Transaction Are Not Allowed on Sunday'
Rollback Transaction
End
End
GO

CREATE TABLE Emp_Audit_Test  
(    
Id int IDENTITY (1,1),   
Audit_Action text   
)  
GO

Drop Table Emp_Audit_Test
GO

--2. This example will create a trigger on dept table that will record audit information of dept table, 
--into another table called auditdept.
Create trigger trAuditDepartment on Department for insert,update,delete as begin
Declare @ODId int,@ODnm varchar(30),@ODSal int,@ODno int
Declare @DId int,@Dnm varchar(30),@DSal int, @Dno int 

Set @ODId=(Select DepartmentId from Deleted)
Set @ODnm =(select DeptName from Deleted)
Set @ODSal=(Select Salary From Deleted)
Set @ODno=(Select DepartmentNo From Deleted)

Set @DId=(Select DepartmentId From Inserted)
Set @Dnm=(Select DeptName From Inserted)
Set @DSal=(Select Salary From Inserted)
Set @Dno=(Select DepartmentNo From Inserted)
Insert into Emp_Audit_Test values(@ODId,@ODnm,@ODSal,@ODno,@DId,@Dnm,@DSal,@Dno,Getdate())
End

Insert into Department (DeptName,Salary,DepartmentNo)  values('Medical Pharma',	70000,	1004)

Drop Trigger AuditDept
