--Page no.37 : Compute / Over / Partition By [DB:STUDENTSDATA]
--COMPUTE CLAUSE
--Display Employee Details Along with Total salary department wise
Select * from Employee order by Deptno COMPUTE Sum salary BY Deptno

--Display Employee Details Along with Total salary department wise
Select *,Sum(Salary) over(partition by job) from Employee
Select *,Sum(Aveg) over(partition by Grade) from Marks

--RANK: Display employee details along with a rank based on salary
Select Deptno,empname,job,salary,rank() over(order by salary desc) as Rank from Employee
Select Deptno,empname,job,salary,rank() over(order by salary asc) as Rank from Employee


--2. DENSE_RANK() : This function works same as Rank(), except that it will not skip a rank when two or more rows got the same rank.
--Display employee details along with a rank based on salary
Select Deptno,Empname,job,salary,Dense_rank() over(order by salary desc) as Rank from Employee

SELECT Total, Aveg,Grade, RANK() OVER (ORDER BY Grade DESC) AS RANK FROM Marks
SELECT Total, Aveg,Grade, DENSE_RANK() OVER (ORDER BY Grade DESC) AS RANK FROM Marks

--Top 'n' clause
--i. Find Top3 salaried employees
Select Top 3 Deptno,Empname,job,Salary from Employee order by salary desc
