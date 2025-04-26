use PostDoc
go


-- 1
CREATE PROCEDURE sp_tblCitiesInsert
@City NVARCHAR(100)
AS
BEGIN
	INSERT INTO tblCities (CityName)
	VALUES (@City)
END;
go


-- 2
CREATE PROCEDURE sp_tblRolesInsert
@Role NVARCHAR(100)
AS
BEGIN
	INSERT INTO tblRoles (RoleName)
	VALUES (@Role)
END;
go

-- 3
CREATE PROCEDURE sp_tblUsersInsert
@FirstName NVARCHAR(100),
@LaststName NVARCHAR(100),
@Role INT,
@EmailId NVARCHAR(100),
@Password NVARCHAR(100),
@PhoneNumber BIGINT,
@Photo VARCHAR(MAX),
@BirthDate DATETIME2,
@Address NVARCHAR(MAX),
@City iNT,
@CreatedAt DATETIME2,
@IsActive BIT
AS
BEGIN
	INSERT INTO tblUsers (FirstName, LastName, [Role],EmailId,[Password],PhoneNumber,Photo,BirthDate,
	[Address],City,CreatedAt,IsActive)
	VALUES 
	(@FirstName, @LaststName,@Role,@EmailId,@Password, @PhoneNumber,@Photo,@BirthDate,@Address,@City,
	@CreatedAt,@IsActive)
END;
go

-- 4
CREATE PROCEDURE sp_tblGroupsInsert
@GroupName NVARCHAR(100),
@Description NVARCHAR(MAX),
@IsActive BIT,
@CreatedAt DATETIME2,
@CreatedBy INT
AS
BEGIN
	INSERT INTO tblGroups (GroupName,[Description],IsActive,CreatedAt,CreatedBy)
	VALUES 
	(@GroupName, @Description,@IsActive,@CreatedAt,@CreatedBy)
END;
go

--5
CREATE PROCEDURE sp_tblSubGroupsInsert
@tblSubGroups NVARCHAR(100),
@Group INT,
@Description NVARCHAR(MAX),
@IsActive BIT,
@CreatedAt DATETIME2,
@CreatedBy INT
AS
BEGIN
	INSERT INTO tblSubGroups (SubGroupName,[Group],[Description],IsActive,CreatedAt,CreatedBy)
	VALUES 
	(@tblSubGroups, @Group, @Description, @IsActive, @CreatedAt, @CreatedBy )
END;
go

-- 6
CREATE PROCEDURE sp_tblGroupPostInsert
@PostedBy INT,
@Title NVARCHAR(100),
@Content NVARCHAR(MAX),
@Image1 NVARCHAR(MAX),
@Image2 NVARCHAR(MAX),
@Reference INT,
@LikeCount INT,
@CreatedAt DATETIME2
AS
BEGIN
	INSERT INTO tblGroupPosts (PostedBy,Title,Content,Image1,Image2,Reference,LikeCount,CreatedAt)
	VALUES 
	(@PostedBy, @Title, @Content, @Image1, @Image2, @Reference,@LikeCount,@CreatedAt )
END;
go


---- Select table by name
CREATE PROCEDURE sp_Select_Anytable
@tableName NVARCHAR(MAX)
AS
BEGIN
	DECLARE @sql NVARCHAR(MAX)
	SET @sql = 'SELECT * FROM ' + @tableName
	EXECUTE sp_executesql  @sql
END
go