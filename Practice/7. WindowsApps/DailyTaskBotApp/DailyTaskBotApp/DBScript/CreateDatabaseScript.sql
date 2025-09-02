-- =============================================                                
-- Author      : Rashid Akhtar                                
-- Create date : 2021-12-10                              
-- Description : To Create Daily Task Bot Database                         
-- =============================================  

USE [MASTER] 
GO

-- 1) Check for the Database Exists .If the database is not exist then create new DB  
IF NOT EXISTS (SELECT [name] FROM sys.databases WHERE [name] = 'DailyTaskBot' )  
BEGIN 
CREATE DATABASE DailyTaskBot  
END  
GO

--2) Check for the Database Exists .If the database is exist then use DB  
IF EXISTS (SELECT [name] FROM sys.databases WHERE [name] = 'DailyTaskBot' )  
BEGIN 
USE DailyTaskBot;  
END  
GO