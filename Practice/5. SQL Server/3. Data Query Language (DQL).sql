--Page No. 30
--This syntax is used to retrieve every row from the table with information from every column of the table. Here * represents “all columns”.
 --display details of all students from STUDENTS table
SELECT * FROM STUDENTS
--display detail marks of all students from MARKS table
SELECT * FROM MARKS 
GO 

--Retreiving Data from table with condition
select SID,SNAME from STUDENTS
Select * from STUDENTS where COURSE='SQL'
Select * from MARKS where TOTAL>=180 AND AVEG > 64 
GO


Select * from MARKS where AVEG>=60

--Retreive course from students table.
Select COURSE from STUDENTS 

--To display the result without duplicates we have to write the query with 'distinct'.
Select Distinct COURSE from STUDENTS 

--Display all records in the order of highest average marks to lowest from marks table.
Select * from MARKS order by AVEG desc  

--Display all students in alphabetical order of their name.
select * from STUDENTS order by SNAME 
