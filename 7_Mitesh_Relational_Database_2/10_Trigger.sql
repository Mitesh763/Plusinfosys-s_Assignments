CREATE TABLE tblRoleLogs (
	RoleLogId INT IDENTITY(1,1),
	RoleName NVARCHAR(100),
	UpdatedDate DATETIME2,
	UpdatedBy INT
	CONSTRAINT PK_tblRoleLogs PRIMARY KEY (RoleLogId)
)
go

CREATE TABLE tblUserLogs(
	UserLogId INT IDENTITY(1,1),
	FirstName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR(100),
	[Role] INT,
	EmailId NVARCHAR(100) NOT NULL,
	[Password] NVARCHAR(100) NOT NULL,
	PhoneNumber BIGINT,
	Photo NVARCHAR(MAX),
	BirthDate DATETIME2,
	[Address] NVARCHAR(MAX) NOT NULL,
	City INT,
	JoiningDate DATETIME2 NOT NULL DEFAULT GETDATE(),
	CreatedAt DATE NOT NULL,
	IsActive BIT NOT NULL DEFAULT 1,
	UpdatedDate DATETIME2,
	UpdatedBy INT
	CONSTRAINT PK_tblUserLogs PRIMARY KEY (UserLogId),
	CONSTRAINT FK_tblUserLogs_tblRoles FOREIGN KEY ([Role]) REFERENCES tblRoles(RoleId),
	CONSTRAINT FK_tblUserLogs_tblCities FOREIGN KEY (City) REFERENCES tblCities(CityId),
)
go

CREATE  PROCEDURE sp_Update_RoleName
@newRoleId INT,
@newRoleName NVARCHAR(100)
AS
BEGIN
	UPDATE tblRoles SET RoleName = @newRoleName,UpdatedDate=GETDATE() WHERE RoleId = @newRoleId
END

go



--trigger


-- tr1: role
CREATE TRIGGER tr_roles ON tblRoles
AFTER UPDATE
AS
BEGIN
	INSERT INTO tblRoleLogs 
		( RoleName,UpdatedDate, UpdatedBy ) 
		SELECT 
			d.RoleName,
			GETDATE(),
			d.UpdateBy
		FROM
			deleted d
END
go


-- tr1: role
CREATE TRIGGER tr_users ON tblUsers
AFTER  UPDATE
AS
BEGIN
	INSERT INTO tblUserLogs
		( FirstName,LastName, [Role],EmailId,[Password],PhoneNumber,Photo,BirthDate,[Address],City,JoiningDate
		,CreatedAt,IsActive,UpdatedDate,UpdatedBy ) 
		SELECT 
			d.FirstName,
			d.LastName,
			d.[Role],
			d.EmailId,
			d.[Password],
			d.PhoneNumber,
			d.Photo,
			d.BirthDate,
			d.[Address],
			d.City,
			d.JoiningDate,
			d.CreatedAt,
			d.IsActive,
			GETDATE(),
			d.UpdateBy
		FROM
			deleted d
END
go


--EXEC sp_Update_RoleName 1,'Owner'
--EXEC sp_Select_Anytable 'tblRoles'
--EXEC sp_Select_Anytable 'tblRoleLogs'
--go

--EXEC sp_Update_UserActiveStatus
--EXEC sp_Select_Anytable 'tblUsers'
--EXEC sp_Select_Anytable 'tblUserLogs'

