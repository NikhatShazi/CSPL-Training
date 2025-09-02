--Creating a database. Syntax1:
CREATE DATABASE MyDatabase
CREATE DATABASE STUDENTSDATA

-- Creating a database. Syntax2:
CREATE DATABASE MyDatabase
on (Name= MyDatabase,
	fileName='D:\MyDatabase.Mdf',
	size=5,
	MaxSize=100,
	fileGrowth=5
	)
Log on
(Name = MyDatabase_log,
FileName = 'D:\MyDatabase.Ldf',
Size = 5,
MaxSize = 20,
FileGrowth = 1
)
GO

--Create database syntax1:
CREATE TABLE STUDENTS
([SID] int constraint SID_PK primary key identity(1001,1), 
SNAME varchar(20) not null,
COURSE varchar(25) not null
)
GO

--Create database syntax2:
CREATE TABLE STUD
([SID] int ,
SNAME varchar(20),
COURSE varchar (25)
)
DROP TABLE STUD
DROP TABLE STUDENTS2

GO
Create table MARKS
(SID int Constraint SID_FK references STUDENTS(SID),
C int Constraint C_CHK Check(C<=100) default 0,
CPP int Constraint CPP_CHK Check(CPP<=100) default 0,
SQL int Constraint SQL_CHK Check(SQL<=100) default 0,
TOTAL int,
AVEG Decimal(5,2),
GRADE varchar(30)
)
GO
Sp_help 'Marks'

--Adding New Column
--Syntax:- Alter Table TableName Add Col1 Datatype [Constraints],Col2 Datatype [Constraints],
--Alter Table MARKS Add NewCol1 int constraint NewCol1_CHK check(NewCol1<=100)
GO
--Changing Data Type of a Column
--Syntax:- Alter Table TableName Alter Column Col1 Datatype 
--Alter Table MARKS Alter Column Addcol1 tinyint 

GO

--Renaming a table
--Syntax Sp_Rename ‘OldName’,’NewName’
--Sp_Rename 'STUD','STUDENTS2'

--Renaming column name
--Sp_Rename ‘TableName.OldName’,’NewNam
--SP_Rename 'MARKS.AVEG','AVERAGE'

CREATE TABLE Employee(
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_Emp] PRIMARY KEY CLUSTERED ,
	[EMPNAME] VARCHAR(20) not null,
	[Gender] [varchar](50) NULL,
	[Mobile] [int] NULL,
	[JOB] VARCHAR(20) not null,
	[DepartmentId] INT
	);
go

--Department table
CREATE TABLE [dbo].[Department](
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_Dept] PRIMARY KEY CLUSTERED ,
	[DeptName] [varchar](50) NULL,
	[Salary] [int] NULL,
	[DepartmentNo] [int] NULL,
 )
 GO

CREATE TABLE [dbo].[Emp]( Id int not null Constraint ID_FK references department (Id),
EmpAdress varchar(50) null,
EmpContact int null)
GO