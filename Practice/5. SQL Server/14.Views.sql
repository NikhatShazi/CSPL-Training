--14.Views : Page no.44 [use MyDatabase]
--Create a view that will provide access to only dept 10 rows from emp table
Create View VW_Employee3 
As 
Select * From Employee 
Where employeeID=3
GO
--DISPLAY CREATED VIEW
Select * From VW_Employee3;
GO
 --DISPLAY ALL COLUMNS OF DEPARTMENT TABLE & DEPTNAME FROM DEPARTMENT TABLE




CREATE VIEW VW_DEPT1
AS
SELECT D.*, E.EmpName FROM Department D 
INNER JOIN Employee E 
ON E.DepartmentId=D.DepartmentId
GO
SELECT * FROM VW_DEPT1

--Hide salary column from above VW_DEPT1.(column level security)
CREATE VIEW VW_DEPT2 
AS
SELECT D.DepartmentId, DeptName, DepartmentNo, E.Empname, E.Job FROM Department D 
INNER JOIN Employee E 
ON E.DepartmentId=D.DepartmentId
GO
SELECT * FROM VW_DEPT2
GO
--(Row level security) display record where DeptName=medical
CREATE VIEW VW_DEPT4 
AS
SELECT D.DepartmentId, DeptName, DepartmentNo, E.Empname, E.Job FROM Department D 
INNER JOIN Employee E 
ON E.DepartmentId=D.DepartmentId
WHERE DeptName='Medical';
GO
SELECT * FROM VW_DEPT4
GO

ALTER VIEW VW_DEPT4 
AS
SELECT D.DepartmentId, DeptName, DepartmentNo, E.Empname, E.Job FROM Department D 
INNER JOIN Employee E 
ON E.DepartmentId=D.DepartmentId
WHERE DeptName='Medical' OR DeptName='EDUCATION';
GO
SELECT * FROM VW_DEPT4
GO
--'SP_HELPTEXT': Displays the query of selecte view.
SP_HELPTEXT VW_DEPT4
GO

SELECT * FROM VW_EMPDEPT
GO
DROP VIEW VW_EMPDEPT
DROP VIEW VW_EMPDEPT1
GO
--If we insert/updat/delete values (or row) from view. It will also get insert/update/delete into original table.
--INSERT:New row 7 will be inserted in vw_department & department table
CREATE VIEW VW_DEPARTMENT
AS
SELECT * FROM DEPARTMENT
GO
--INSERT:New row 7 will be inserted in vw_department & department table
INSERT INTO VW_DEPARTMENT VALUES (7,'Accounts',60000,1006)
GO
INSERT INTO VW_DEPARTMENT VALUES (8,'Accounts',640000,1008)
GO
--DELETE FROM VIEW
DELETE FROM VW_DEPARTMENT WHERE DepartmentNo=1008
GO
SELECT * FROM VW_DEPARTMENT
GO
--UPDATE into view
UPDATE VW_DEPARTMENT SET DeptName='stenographer' where DepartmentNo=1003
UPDATE VW_DEPARTMENT SET DepartmentNo=1007 where DepartmentId=7
GO