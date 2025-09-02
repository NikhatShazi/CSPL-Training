--Page no. 51 : Functions [DB:MyDatabase]

--i. Create a Function that will calculate Sum of three integers
Create Function Total(@A int,@B int, @C int) returns int as
Begin
Return @A+@B+@C
End

--To execute an user defined function, you can use select statement as follows
--Select Dbo.Functionname(Arg1,Arg2,…)
Select Dbo.Total(11,5,6)
GO

--ii. Create A Function That Will Generate New DepartmentNo Automatically.
Create Function NewDeptno() returns int as
Begin
Declare @NDno int
Set @NDno=(Select isnull(max(DepartmentNo),0)+1 from Department)
Return @NDno
End
GO
Select Dbo.NewDeptno()
GO

--e.g2:Create Function NewDeptno() returns int as
Create Function NewDeptnum() returns int as
Begin
Declare @NDno int
Set @NDno=(Select isnull(max(DepartmentNo),0)+1 from Department)
Return @NDno
End
GO
Select Dbo.NewDeptnum()
GO
--To Delete a function, use Drop Function Command as follows.
Drop Function NewDeptnum