
use EmployeeManagement
go

-- insert employee
CREATE PROCEDURE sp_tblEmployeesInsert
	@name NVARCHAR(255),
	@address NVARCHAR(MAX),
	@designation NVARCHAR(255),
	@gender NVARCHAR(50),
	@salary FLOAT,
	@department INT
AS
BEGIN
	INSERT INTO tblEmployees ([Name], [Address], Designation, Gender, Salary, Department) 
	VALUES 
	(@name, @address, @designation, @gender, @salary, @department)
END
go

--  Select employee by ID
CREATE PROCEDURE sp_tblEmployeesSelectByID
@employeeId INT
AS
BEGIN
	SELECT * FROM tblEmployees e
	JOIN tblDepartments d ON d.DepartmentId = e.Department 
	WHERE EmployeeId = @employeeId 
END
go

-- Get All Employee
CREATE PROCEDURE sp_tblEmployeesSelect
AS
BEGIN
	SELECT * FROM tblEmployees e JOIN tblDepartments d ON d.DepartmentId = e.Department  ORDER BY EmployeeId
END
go

-- Update employee
CREATE PROCEDURE sp_tblEmployeesUpdate
@employeeId INT,
	@newName NVARCHAR(255),
	@newAddress NVARCHAR(MAX),
	@newDesignation NVARCHAR(255),
	@newGender NVARCHAR(50),
	@newSalary FLOAT,
	@newDepartment INT
AS
BEGIN
	UPDATE tblEmployees SET [Name] = @newName, [Address] = @newAddress, 
	Designation = @newDesignation, Gender = @newGender, Salary = @newSalary, 
	Department = @newDepartment 
	WHERE EmployeeId = @employeeId
END
go

--  Delete employee
CREATE PROCEDURE sp_tblEmployeesDelete
@employeeId INT
AS
BEGIN
	DELETE FROM tblEmployees WHERE EmployeeId = @employeeId
END
go

-- Insert Department
CREATE PROCEDURE sp_tblDepartmentsInsert
	@departmentName NVARCHAR(255)
AS
BEGIN
	INSERT INTO tblDepartments (DepartmentName) VALUES (@departmentName)
END
go

--SELECT Department
CREATE PROCEDURE sp_tblDepartmentsSelect
AS
BEGIN
	SELECT * FROM tblDepartments ORDER BY DepartmentId
END
go

--  update employee
CREATE PROCEDURE sp_tblDepartmentsDelete
@departmentId INT
AS
BEGIN
	DELETE FROM tblDepartments WHERE DepartmentId = @departmentId
END
go

--  Get Highest Salaried employee in department
CREATE PROCEDURE sp_tblEmployeeSelectHighSalary
@departmentId INT
AS
BEGIN
	SELECT * FROM (SELECT *, RANK() OVER (ORDER BY Salary DESC) AS SalaryRank 
	FROM tblEmployees 
	WHERE Department = @departmentId) AS rankedEmployees 
	WHERE SalaryRank = 1;

END
go

--  Get Highest Salaried employee in department
CREATE PROCEDURE sp_tblEmployeeSelectSecondHighSalary
@departmentId INT
AS
BEGIN
	SELECT * FROM (SELECT *, RANK() OVER (ORDER BY Salary DESC) AS SalaryRank 
	FROM tblEmployees 
	WHERE Department = @departmentId) AS rankedEmployees 
	WHERE SalaryRank = 2;
END
go

-- list of existed employee
CREATE PROCEDURE sp_tblEmployeesExistList
AS
BEGIN
	SELECT EmployeeId,Name FROM tblEmployees ORDER BY EmployeeId
END
go


-- list of existed employee ID
CREATE PROCEDURE sp_tblEmployeesExistEmployeeID
@id INT
AS
BEGIN
	SELECT EmployeeId FROM tblEmployees WHERE EmployeeId = @id
END
go


-- list of existed employee Boolean
CREATE PROCEDURE sp_tblEmployeesExistEmployee
AS
BEGIN
	SELECT EmployeeId FROM tblEmployees
END
go


-- list of existed Department
CREATE PROCEDURE sp_tblDepartmentExistList
AS
BEGIN
	SELECT DepartmentId FROM tblDepartments
END
go


-- list of existed Department ID
CREATE PROCEDURE sp_tblDepartmentExistID
@id INT
AS
BEGIN
	SELECT DepartmentId FROM tblDepartments WHERE DepartmentId = @id
END
go