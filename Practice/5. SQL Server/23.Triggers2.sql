CREATE TABLE Employee2  
(  
  Id INT PRIMARY KEY,  
  EName VARCHAR(45),  
  Salary INT,  
  Gender VARCHAR(12),  
  DepartmentId INT,  
)  
GO

INSERT INTO Employee2 VALUES (6,'Steffan', 82000, 'Male', 3),  
(7,'Amelie', 52000, 'Female', 2),  
(8,'Antonio', 25000, 'male', 1),  
(9,'Marco', 47000, 'Male', 2),  
(10,'Eliana', 46000, 'Female', 3)  
GO

Select * from Employee2
GO

CREATE TABLE Employee_Audit_Test  
(    
Id int IDENTITY,   
Audit_Action text   
)  
GO
 
Drop Table Employee_Audit_Test
GO

CREATE TRIGGER trInsertEmployee   
ON Employee2  
FOR INSERT  
AS  
BEGIN  
  Declare @Id int  
  SELECT @Id = Id from inserted  
  INSERT INTO Employee_Audit_Test  
  VALUES ('New employee with Id = ' + CAST(@Id AS VARCHAR(10)) + ' is added at ' + CAST(Getdate() AS VARCHAR(22))) 
  SELECT Id,Audit_Action FROM Employee_Audit_Test WHERE Id = @Id
  PRINT 'New employee with Id = ' + CAST(@Id AS VARCHAR(10)) + ' is added at ' + CAST(Getdate() AS VARCHAR(22))
END  
GO

Drop trigger trInsertEmployee
GO

INSERT INTO Employee2 VALUES (14,'James', 77000, 'Male', 3) 
SELECT * FROM Employee2;
GO

CREATE TRIGGER trDeleteEmployee   
ON Employee2  
FOR DELETE  
AS  
BEGIN  
  Declare @Id int  
  SELECT @Id = Id from deleted  
  INSERT INTO Employee_Audit_Test  
  VALUES ('An existing employee with Id = ' + CAST(@Id AS VARCHAR(10)) + ' is deleted at ' + CAST(Getdate() AS VARCHAR(22)))  
END  
GO

DELETE FROM Employee2 WHERE Id = 9;  
GO