--Page no.48:Procedural Statements
--i. This example adds two numbers and prints the sum
Begin
	Declare @A int,@B int, @S int
	Set @A=10
	Set @B=20
	Set @S=@A+@B
		Print 'Sum is ' + cast(@S as varchar(5))
End
GO

--ii. This example will determine whether an integer is even or odd
Begin
	Declare @N int
	Set @N=10
	If @N%2=0
		Print 'Even Number'
	Else
		Print 'Odd Number'
End
GO

--iii. This Example will print integers from 1 to 10
Begin
	Declare @N int
	Set @N=1
		While @N<=20
		Begin
			Print @N
			Set @N=@N+1
		End
End
GO