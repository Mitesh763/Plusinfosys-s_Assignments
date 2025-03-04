CREATE DATABASE EmployeeManagement
go

use EmployeeManagement
go

CREATE TABLE tblDepartments (
	DepartmentId INT IDENTITY(1,1),
	DepartmentName NVARCHAR(255),
	CONSTRAINT PK_DepartmentName PRIMARY KEY (DepartmentId),
	CONSTRAINT UQ_DepartmentName UNIQUE (DepartmentName)
)
go

CREATE TABLE tblEmployees (
	EmployeeId INT IDENTITY(1,1),
	[Name] NVARCHAR(255) NOT NULL,
	[Address] NVARCHAR(MAX) NOT NULL,
	Designation NVARCHAR(255) NOT NULL,
	Gender NVARCHAR(50),
	Salary FLOAT,
	Department INT NOT NULL,
	CONSTRAINT PK_tblEmployees PRIMARY KEY (EmployeeId),
	CONSTRAINT FK_tblEmployees_tblDepartments FOREIGN KEY (Department) 
	REFERENCES tblDepartments(DepartmentId)
)