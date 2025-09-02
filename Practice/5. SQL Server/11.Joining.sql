--Page no 40. : Joining
--[USE MyDatabase]
--1.EQUI JOIN
SELECT * FROM EMPLOYEE E INNER JOIN DEPARTMENT D ON E.DepartmentId=D.DepartmentId
GO

--2. NATURAL JOIN
Select EMPLOYEE.EMPNAME Name, EMPLOYEE.Gender, EMPLOYEE.JOB,EMPLOYEE.Mobile, DEPARTMENT.DEPTNAME 
From DEPARTMENT join EMPLOYEE  on EMPLOYEE.DepartmentId =DEPARTMENT.DepartmentId 
GO

--3. OUTER JOIN
SELECT * FROM EMPLOYEE E LEFT  JOIN DEPARTMENT D ON E.DepartmentId=D.DepartmentId
GO
Select * From Employee E RIGHT OUTER JOIN Department D on E.DepartmentId=D.DepartmentId
GO
Select * From EMPLOYEE E FULL OUTER JOIN Department D on E.DepartmentId=D.DepartmentId
GO

--4.THETA JOIN
SELECT *
FROM Employee E JOIN Department D
ON E.DepartmentId < D.DepartmentId
order by E.DepartmentId asc



--5.cross join
Select * From Employee E Cross join Department D

DELETE FROM EMP
WHERE Empno BETWEEN 9 AND  19; 

--6.self join
--Select E.EmpId,E.MgrId,E.ename Emploee,M.ename Manager,E.Job,E.Salary
Select E.ename Emploee,M.ename Manager,E.Job,E.Salary
From EMP E join Emp M on
E.MgrId=M.EmpId

Select ct.AreaName as [City], st.AreaName as [State], cn.AreaName as [Country]
From AreaStructure cn
inner join AreaStructure st
on st.ParentId = cn.AreaId
inner join AreaStructure ct
on ct.ParentId = st.AreaId