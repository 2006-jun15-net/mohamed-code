-- -- Create a new database called 'NewDataBase'
-- -- Connect to the 'master' database to run this snippet
-- USE master
-- GO
-- -- Create the new database if it does not exist already
-- IF NOT EXISTS (
--     SELECT [name]
--         FROM sys.databases
--         WHERE [name] = N'NewDataBase'
-- )
-- CREATE DATABASE NewDataBase
-- GO

-- Create TABLE dbo.Employee
-- (    
--     ID int NOT NULL PRIMARY KEY, -- primary key column
--     FirstName nvarchar(50) NOT NULL,
--     LastName nvarchar(50) NOT NULL,
--     SSN int NOT NULL, 
--     DeptID int NOT NULL 
-- );
-- GO

-- INSERT into Employee Values
--     (1, 'Tina', 'Smith', 123456, 1),
--     (2, 'Mohamed', 'Salam', 123457, 1),
--     (3, 'Nick', 'Escolan', 123458, 1)

SELECT * From Employee

UPDATE Employee
SET d