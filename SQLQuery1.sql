USE master
CREATE DATABASE CrudInBlazorSeverAppDB
GO
USE CrudInBlazorSeverAppDB
CREATE TABLE Course
(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50) NULL,
CourseDuration varchar(30) NULL
);
GO
USE CrudInBlazorSeverAppDB
CREATE TABLE Trainee
(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50) NULL,
EmailAddress varchar(30) NULL,
CellphoneNo varchar(30) NULL,
ContactAddress varchar(30),
CourseId INT FOREIGN KEY REFERENCES Course(Id)
);
GO