--Page no.53 : Output parameters s
--Example : This example will create a procedure Swap that will swap two integers.
Create procedure Swap(@X int output, @Y int output) As
Begin
Declare @T int
Set @T=@X
Set @X=@Y
Set @Y=@T
End
GO

--To execute this procedure we have to create a block as follows.
Begin
Declare @A int,@B int
Set @A=10
Set @B=20
Print 'Before Swap A = ' + cast(@A as varchar(3)) + ' B = ' + cast(@B as varchar(3))
EXEC Swap @A output , @B output
Print 'After Swap A = ' + cast(@A as varchar(3)) + ' B = ' + cast(@B as varchar(3))
End
GO