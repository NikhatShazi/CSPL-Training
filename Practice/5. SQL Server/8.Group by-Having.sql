--Page no.36 : Group by / Having  [STUDENTDATA Database]
--calculate sum of salaries of employees department wise
SELECT job, SUM(salary) FROM employee GROUP BY job

--iii. Find the number of employees working in each department
Select Gender,Count(*) from DEPARTMENT group by Gender 

--iv. Find the total salary paid to employees job wise In each department

--HAVING
--In THE below query condition is Count(*)>=3. This contains an aggregate function. Hence we must use having instead of where clause.
--if you want to find the departments with three or more employees then the query will be as follows.
SELECT [Name],COUNT(*) FROM Department GROUP BY [Name] HAVING COUNT (*)>=3
SELECT Job,COUNT(*) FROM Employee GROUP BY Job HAVING COUNT (*)>=2

--Find the Jobs whose average salary is more than 22000
Select Job,Avg(Salary) from employee group by job having Avg(salary)>22000

--Roll up and cube 
--Roll up and Cube can be used only with group by. For example if you want to calculate sub totals at the end of each department,
--when grouping data on both Deptno and Job, then the following query is used.
Select Deptno, Job, Sum(Salary) from employee group by Deptno,Job with rollup 

Select Deptno, Job, Sum(Salary) from employee group by Deptno,Job with cube