--Page no.33: Built-in Functions
--SCALAR FUNCTION: 
--A) Numeric Functions.
--1. Abs(n) : Returns absolute value of the given n i.e. n value without any sign.
SELECT Abs(-243.5) AS AbsNum;

--2. Ceiling(n) : Returns smallest integer greater than or equal to n.
SELECT CEILING(25.75) AS CeilValue;

--3.Floor(n) : Returns largest integer less than or equal to n.
SELECT FLOOR(25.75) AS FloorValue;

--4. Radians(n) : Converts the given n in degrees to radians.
SELECT RADIANS(180);

--5. Degrees(n) : Converts the given n in radians to degrees.
SELECT DEGREES(1.5);

--6. Exp(n) : Returns e raised to the power of n. e is exponential whose value is constant and is 2.713
SELECT EXP(1);
SELECT EXP(2);

--7. Log(n) : Returns natural logarithm of n. i.e. base e logarithm.
SELECT LOG(2);

--8. Log10(n) : Returns base 10 logarithm of n.
SELECT LOG10(2);

--9. Power(m,n) : Returns m raised to the power of n.
SELECT POWER(7,2);

--10. Square(n) : Returns Square of given n.
SELECT SQUARE(8);

--11. Sqrt(n) : Returns Square Root of given n
SELECT SQRT(9);

--12. Pi() : Return mathematical constant pi value i.e. 3.14
SELECT PI();

--B)String function
--1. ASCII(char) : Converts the specified character to the equivalent ascii code.
SELECT ASCII('S');

--C)Date function
--1. GetDate() : Returns the current system date and time.
SELECT GETDATE();

--2. DatePart(item,D) : returns the specified item of a date D as an integer.
SELECT DATEPART(year, '2017/08/25');

--3. DateName(item,D) : returns the specified item of the date D as a string.
SELECT DATENAME(year, '2017/08/25');

--D)Conversion Functions
--4.converts an expression a into the specified data type type.
SELECT Cast(321.55 as int);
SELECT CAST(321.55 AS varchar);

--E)System Functions
--Returns the identifier of the database object objname.
SELECT (Object_ID('dbo.STUDENTS',1))AS [SNAME ]
--returns the id of specified user name.
SELECT User_Id('USER_NAME')
--returns the current timestamp of the database.
SELECT Current_TimeStamp
--returns the id of the database db_name
SELECT DB_Id('STUDENTSDATA')

--F)Aggregate Functions
--1. Convenient Aggregate Functions :
SELECT SUM(TOTAL) FROM MARKS
SELECT MAX(TOTAL) FROM MARKS
SELECT MIN(TOTAL) FROM MARKS
SELECT AVG(TOTAL) FROM MARKS

--2. Statistical Aggregate Functions :
SELECT VAR(TOTAL) FROM MARKS
SELECT VARP(TOTAL) FROM MARKS
SELECT Stdev(TOTAL) FROM MARKS
SELECT StdevP(TOTAL) FROM MARKS



