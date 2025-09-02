--Page no.42 : SUB QUERIES
--1. Single row sub query
--Find The Employee whose address is CCC.
Select * From Department where id=(Select Id From Emp Where EmpAdress='CCC')
GO

--Find The Employee Who is drawing highest salary.
Select * from Department where salary=(Select max(salary) from Department)
GO

--2. MULTI ROW SUB QUERIES
--Find highest salaried employees department wise
Select * from Department where salary in (Select max(salary) from Department group by DeptId)
GO

--Find Employees not working in dept 4 and drawing salary more than anyone employee in dept 4.
Select * from Department where DeptId!=4 and salary> ANY(Select Distinct salary from Department where deptId=4)
GO

--Find Employees not working in dept 2 and drawing salary more than all employees in dept 2.
Select * from Department where DeptId!=2 and salary> All(Select Distinct salary from Department where deptId=2)
GO

--3. NESTED SUB QUERIES
--Find Employees whose salary is more than average salary of Marketing Dept.
Select * from DEpartment where salary >=
(Select Avg(salary) from Department where Id=

(Select Id from Emp where DeptNM='MARKETING'))
GO

--4. CO-RELATED SUB QUERIES
--Find Employees To Whom At least one employee is Reporting.
--Select * From emp M where exists(Select * From Emp e where M.ID=E.Id)
GO

--Find Departments in which there are no employees
SELECT * FROM department WHERE id NOT IN (select id FROM emp);