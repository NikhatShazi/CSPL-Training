--Page no.54 : CUSROR [DB: MyDatabase] 
--we can access only one row at a time within a stored procedure. 
--But with the help of cursors we can access the rows of a table one by one sequentially. 
--To work with cursors we have to follow the following steps.

--This example will Read one by one record from Emp table and increments salary based on job

Create procedure Increment as
Begin
Declare @DId int,@DName varchar(30),@DSal int, @Dno int
Declare MyCur Cursor for select DepartmentId,DeptName,salary,DepartmentNo from Department
Open MyCur
Fetch next from mycur into @DId,@DName,@DSal,@Dno
While @@Fetch_Status=0
Begin
If @Dname='IT'
Set @DSal=@DSal+5000
Else if @Dname='Education'
Set @DSal=@DSal+3000
Else if @Dname='stenographer'
Set @DSal=@DSal+2000
Else if @Dname='Medical'
Set @DSal=@DSal+1500
Else
Set @DSal=@DSal+700
Update Department set Salary=@DSal where DepartmentNo=@Dno
Fetch Next From MyCUr into @DId,@DName,@DSal,@Dno
End
Close Mycur

Deallocate Mycur
End