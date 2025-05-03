CREATE DATABASE EmployeeManagement
go

use EmployeeManagement
go


-- Table : Department 
CREATE TABLE tblDepartments (
	DepartmentId INT IDENTITY(1,1),
	DepartmentName NVARCHAR(255) NOT NULL,
	CONSTRAINT PK_DepartmentName PRIMARY KEY (DepartmentId),
	CONSTRAINT UQ_DepartmentName UNIQUE (DepartmentName)
)
go

-- Table : Employee
CREATE TABLE tblEmployees (
	EmployeeId INT IDENTITY(1,1),
	FirstName NVARCHAR(255) NOT NULL,
	LastName NVARCHAR(255),
	Email NVARCHAR(255) NOT NULL,
	[Address] NVARCHAR(MAX) NOT NULL,
	Designation NVARCHAR(255) NOT NULL,
	Gender BIT NOT NULL DEFAULT 1,
	Salary DECIMAL(18,2) NOT NULL,
	IsActive BIT DEFAULT 1,
	DepartmentId INT NOT NULL,
	CONSTRAINT PK_tblEmployees PRIMARY KEY (EmployeeId),
	CONSTRAINT FK_tblEmployees_tblDepartments FOREIGN KEY (DepartmentId)
	REFERENCES tblDepartments(DepartmentId)
)
go

CREATE TABLE tblUsers (
	UserId INT IDENTITY(1,1),
	UserName NVARCHAR(255) NOT NULL,
	[Password] NVARCHAR(MAX) NOT NULL
	CONSTRAINT PK_UserId PRIMARY KEY (UserId),
	CONSTRAINT UQ_UserName UNIQUE (UserName)
)
go 

INSERT INTO tblUsers (UserName,[Password])
VALUES 
('Jaypal','123')