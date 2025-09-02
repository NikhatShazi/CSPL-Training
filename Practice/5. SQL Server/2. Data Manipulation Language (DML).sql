--PAGE NO.27: 
--Insert values into STUDENST table, in STUDENTSDATA database
Insert into STUDENTS values('John Deo','SQL')
Insert into STUDENTS values('Max ','C')
Insert into STUDENTS values('Arnold','SQL')
Insert into STUDENTS values('Krish ','CPP')
Insert into STUDENTS values('Mike','C')
Insert into STUDENTS values('Michal','SQL')

GO

--Insert values into MARKS table, in STUDENTSDATA database
Insert into [MARKS] Values(1001,40,47,46,null,null,null)
Insert into [MARKS] Values(1002,50,56,58,null,null,null)
Insert into [MARKS] Values(1003,60,65,67,null,null,null)
Insert into [MARKS] Values(1004,70,75,77,null,null,null)
Insert into [MARKS] Values(1005,80,85,87,null,null,null)
Insert into [MARKS] Values(1006,70,75,77,null,null,null,'Maths')

GO
Insert into [EMPLOYEE] Values('AKIL',1,30000,'Manager')
Insert into [EMPLOYEE] Values('Shahid',4,20000,'Assist.Manager')
Insert into [EMPLOYEE] Values('MAHIR',3,25000,'Programmer')
Insert into [EMPLOYEE] Values('Namy',2,22000,'JR. Programmer')
Insert into [EMPLOYEE] Values('James',22000, null)

GO

Insert into Department Values('Steffan',82000,'Male',3)
Insert into Department Values('Antonio',25000,'Male',1)
Insert into Department Values('Marco',47000,'Male',2)
Insert into Department Values('Eliana',46000,'Female',3)
Insert into Department Values('Peter',62000,'Male',3)
Insert into Department Values('James',78900,'Male',4)

GO



--Insert into MARKS( SID,C,CPP,SQL) values(55,88,77)

--This syntax is used when we have to insert rows from an existing table in to a new table, 
--provided no. of columns and their data types match in those two tables
Select * into MYTABLE From STUDENTS

--To update the course of a student with sid 1002 to SQL, the update command will be as follows.
Update STUDENTS set COURSE='CPP' WHERE SID=1002 

--: To update rows in marks table by calculating total, average columns, the update statement will be as follows
Update Marks Set Total = C+Cpp+Sql, AVEG = (C+Cpp+Sql)/3

--Calculating grades in MARKS table.
Update Marks set Grade = case
When AVEG>=90 then 'DISTINCTION'
When AVEG>=70 then 'FIRST CLASS'
When AVEG>=55 then 'SECOND CLASS'
When AVEG>=35 then 'THIRD CLASS'
Else 'FAIL'
End
GO

--Deleting a row using selected SID
Delete STUDENTS where SID=1017
Delete STUDENTS where SID=1016
Delete STUDENTS where SID=1015
GO

--Deleting a table
Delete MYTABLE
GO

--Used For Deleting All The Rows
Truncate Table [dbo].STUDENTS
Truncate Table [dbo].MARKS

--Used For Deleting Table
Drop Table [dbo].MARKS


