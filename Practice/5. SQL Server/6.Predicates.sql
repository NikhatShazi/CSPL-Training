
--Page no. 32 [PREDICATE- Four Types]
--1.BETWEEN...AND: Find all employees whose salary is more than equal to 20000 and less than equal to 25000
SELECT * FROM [EMPLOYEE] WHERE Salary BETWEEN 20000 AND 25000
SELECT * FROM [EMPLOYEE] WHERE Deptno BETWEEN 1002 AND 1004

GO

--2.IN: This predicate is used to verify whether the given value exists in a given table.
--Find all employees whose salary is either 20000 or 22000 or 25000
 SELECT * FROM [EMPLOYEE] WHERE Salary IN(20000,25000,22000)
 SELECT * FROM [EMPLOYEE] WHERE Empname IN('Shahid', 'Akil','NAmy')
 GO
--3.Like: Find all employees whose name starts with ‘S’
 SELECT * FROM [EMPLOYEE] WHERE Empname LIKE 'S%'

--Find all employees whose name ends with ‘L’
SELECT * FROM [EMPLOYEE] WHERE Empname LIKE '%L'

--Find all employees whose name starts with M and letter H in between 
SELECT * FROM [EMPLOYEE] WHERE Empname LIKE 'M%H%'

--4. Is Null : This predicate is used to verify for a null value in a given column.
--Find all employees who are not drawing commission
SELECT * FROM [EMPLOYEE] WHERE Job IS NULL 
