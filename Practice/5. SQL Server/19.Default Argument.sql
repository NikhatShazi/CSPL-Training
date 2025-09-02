--Page no. 53 : Default Argument
--This example will create a procedure that can be called with 2 or 3 or 4 or 5 integers to calculate Sum.
--In the following example C,D,and E are default arguments, if any value in not passed to these args, they take default value 0.
Create procedure MySum(@A int,@B int, @C int=0,@D int=0,@E int=0) As
Begin
Print @A+@B+@C+@D+@E
End
GO
Execute MySum 10,20
GO
Execute MySum 10,20,30
GO
Execute MySUm 10,20,30,40
GO
Execute mySum 10,20,30,40,50
GO

--e.g.2: 
Create procedure GreaterNo(@A int,@B int=0) As
Begin
	IF @A>@B
		Print 'Greater number is A = ' + cast(@A as varchar(3))
	Else
		Print  'Greater number is B = ' + cast(@B as varchar(3))
End
GO

Execute GreaterNo 10,30
GO