
use EmployeeManagement
go

----- SP : Employee -------------------

-- Get All Employee
CREATE or ALTER PROCEDURE sp_tblEmployeesSelect
AS
BEGIN
	SELECT * FROM tblEmployees e JOIN tblDepartments d ON d.DepartmentId = e.DepartmentId WHERE IsActive = 1 ORDER BY EmployeeId
END
go

--  Select employee by ID
CREATE or ALTER PROCEDURE sp_tblEmployeesSelectByID
@employeeId INT
AS
BEGIN
	SELECT * FROM tblEmployees e
	JOIN tblDepartments d ON d.DepartmentId = e.DepartmentId 
	WHERE EmployeeId = @employeeId 
END
go

-- ADD, Update employee
CREATE PROCEDURE sp_tblEmployeesInsertUpdate
@employeeId INT = NULL,
	@firstName NVARCHAR(255),
	@lastName NVARCHAR(255) = NULL,
	@email NVARCHAR(255),
	@address NVARCHAR(MAX),
	@designation NVARCHAR(255),
	@gender BIT,
	@salary DECIMAL(18,2),
	@isActive BIT = NULL,
	@department INT
AS
BEGIN
	if @employeeId > 0
	BEGIN
		UPDATE tblEmployees SET FirstName = @firstName, LastName = @lastName, Email = @email,
		[Address] = @address, 
		Designation = @designation, Gender = @gender, Salary = @salary, IsActive = @isActive,
		DepartmentId = @department
		WHERE EmployeeId = @employeeId
	END
	ELSE
	BEGIN
		INSERT INTO tblEmployees (FirstName, LastName, Email, [Address], Designation, Gender, Salary, IsActive ,DepartmentId) 
		VALUES 
		(@firstName, @lastName, @email, @address, @designation, @gender, @salary, @isActive, @department)
	END
END
go

--  Delete employee
CREATE or ALTER PROCEDURE sp_tblEmployeesDelete
@employeeId INT
AS
BEGIN
	UPDATE tblEmployees SET IsActive = 0 WHERE EmployeeId = @employeeId
END
go

--------- SP : Department 

--SELECT Department
CREATE  PROCEDURE sp_tblDepartmentsSelect
AS
BEGIN
	SELECT * FROM tblDepartments ORDER BY DepartmentId
END
go

--SELECT Department by id
CREATE PROCEDURE sp_tblDepartmentsSelectById
@departmentId INT
AS
BEGIN
	SELECT * FROM tblDepartments WHERE DepartmentId = @departmentId
END
go

-- department addedit
CREATE PROCEDURE sp_tblDepartmentsInsertUpdate
@departmentId INT = NULL,
@departmentName NVARCHAR(MAX)
AS
BEGIN
	if @departmentId > 0
	BEGIN
		UPDATE tblDepartments SET DepartmentName = @departmentName
		WHERE DepartmentId = @departmentId
	END
	ELSE
	BEGIN
		
	INSERT INTO tblDepartments (DepartmentName) VALUES (@departmentName)
	END
END
go

--  delete department
CREATE PROCEDURE sp_tblDepartmentsDelete
@departmentId INT
AS
BEGIN
	DELETE FROM tblDepartments WHERE DepartmentId = @departmentId
END
go
 
 -- department exist
 CREATE  PROCEDURE sp_tblDepartmentsExist
 AS
 BEGIN
	SELECT COUNT(DepartmentId) FROM tblDepartments
 END
 go

 -- login user
 CREATE  PROCEDURE sp_validateUser
 @userName NVARCHAR(255),
 @password NVARCHAR(MAX)
 AS
 BEGIN
	SELECT * FROM tblUsers WHERE UserName = @userName AND [Password] = @password
 END