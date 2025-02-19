use PostDoc
go

CREATE PROCEDURE sp_Insert_tblCities
@City NVARCHAR(100)
AS
BEGIN
	INSERT INTO tblCities (CityName)
	VALUES (@City)
END;
go


-- 2
CREATE PROCEDURE sp_Insert_tblRoles
@Role NVARCHAR(100)
AS
BEGIN
	INSERT INTO tblRoles (RoleName)
	VALUES (@Role)
END;
go

-- 3
CREATE PROCEDURE sp_Insert_tblUsers
@FirstName NVARCHAR(100),
@LaststName NVARCHAR(100),
@Role INT,
@EmailId NVARCHAR(100),
@Password NVARCHAR(100),
@PhoneNumber BIGINT,
@Photo VARCHAR(MAX),
@BirthDate DATE,
@Address NVARCHAR(MAX),
@City iNT,
@CreatedAt DATE,
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
CREATE PROCEDURE sp_Insert_tblGroups
@GroupName NVARCHAR(100),
@Description NVARCHAR(MAX),
@IsActive BIT,
@CreatedAt DATE,
@CreatedBy INT
AS
BEGIN
	INSERT INTO tblGroups (GroupName,[Description],IsActive,CreatedAt,CreatedBy)
	VALUES 
	(@GroupName, @Description,@IsActive,@CreatedAt,@CreatedBy)
END;
go

--5
CREATE PROCEDURE sp_Insert_tblSubGroups
@tblSubGroups NVARCHAR(100),
@Group INT,
@Description NVARCHAR(MAX),
@IsActive BIT,
@CreatedAt DATE,
@CreatedBy INT
AS
BEGIN
	INSERT INTO tblSubGroups (SubGroupName,[Group],[Description],IsActive,CreatedAt,CreatedBy)
	VALUES 
	(@tblSubGroups, @Group, @Description, @IsActive, @CreatedAt, @CreatedBy )
END;
go

--5
CREATE PROCEDURE sp_Insert_tblGroupPosts
@PostedBy INT,
@Title NVARCHAR(100),
@Content NVARCHAR(MAX),
@Image1 NVARCHAR(MAX),
@Image2 NVARCHAR(MAX),
@Reference INT,
@LikeCount INT,
@CreatedAt DATE
AS
BEGIN
	INSERT INTO tblGroupPosts (PostedBy,Title,Content,Image1,Image2,Reference,LikeCount,CreatedAt)
	VALUES 
	(@PostedBy, @Title, @Content, @Image1, @Image2, @Reference,@LikeCount,@CreatedAt )
END;
go

CREATE PROCEDURE sp_Select_Anytable
@tableName NVARCHAR(MAX)
AS
BEGIN
	DECLARE @sql NVARCHAR(MAX)
	SET @sql = 'SELECT * FROM ' + @tableName
	EXECUTE sp_executesql  @sql
END
go