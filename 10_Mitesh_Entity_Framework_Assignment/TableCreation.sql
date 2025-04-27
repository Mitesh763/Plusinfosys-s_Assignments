CREATE DATABASE EmployeeDoc
go

use EmployeeDoc
go

CREATE TABLE tblDepartments (
	DepartmentId INT IDENTITY(1,1),
	DepartmentName NVARCHAR(255) NOT NULL,
	CONSTRAINT PK_DepartmentName PRIMARY KEY (DepartmentId),
	CONSTRAINT UQ_DepartmentName UNIQUE (DepartmentName)
)
go

CREATE TABLE tblEmployees (
	EmployeeId INT IDENTITY(1,1),
	[Name] NVARCHAR(255) NOT NULL,
	[Address] NVARCHAR(MAX) NOT NULL,
	Designation NVARCHAR(255) NOT NULL,
	Gender BIT NOT NULL,
	Salary FLOAT NOT NULL,
	Department INT NOT NULL,
	CONSTRAINT PK_tblEmployees PRIMARY KEY (EmployeeId),
	CONSTRAINT FK_tblEmployees_tblDepartments FOREIGN KEY (Department) 
	REFERENCES tblDepartments(DepartmentId)
)