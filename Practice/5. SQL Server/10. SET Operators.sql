--pAGE NO.39: SET Operators [DB:STUDENTS DATA]
--1. UNION: Find Employee names and jobs available in departmenents 1002,1004
Select EmpName,Job From Employee Where Deptno=1002
Union
Select EmpName,Job From Employee Where Deptno=1004
GO

--2. INTERSECT : The intersection of two tables is the set of rows belonging to both tables
Select Job From Employee Where Deptno=1004
Intersect
Select Job From Employee Where Deptno=1005
GO

--3.EXCEPT: Find jobs available in departmenent 1002 And not in 1004
Select Job From Employee Where Deptno=1002
Except
Select Job From Employee Where Deptno=1004
GO
