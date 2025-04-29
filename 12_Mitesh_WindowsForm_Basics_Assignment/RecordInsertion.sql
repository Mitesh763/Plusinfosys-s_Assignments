use Intranet
go


-- 1
CREATE PROCEDURE sp_tblCitiesInsert
@CityName NVARCHAR(100)
AS
BEGIN
	INSERT INTO tblCities (CityName)
	VALUES (@CityName)
END;
go

 EXEC sp_tblCitiesInsert 'Ahmedabad'
 EXEC sp_tblCitiesInsert 'Surat'
 
 go

-- 2
CREATE PROCEDURE sp_tblRolesInsert
@RoleName NVARCHAR(100)
AS
BEGIN
	INSERT INTO tblRoles (RoleName)
	VALUES (@RoleName)
END;
go

 EXEC sp_tblRolesInsert 'Admin'
 EXEC sp_tblRolesInsert 'User'

go

-- 3
CREATE PROCEDURE sp_tblUsersInsert
@UserName NVARCHAR(100),
@Role INT,
@EmailId NVARCHAR(100),
@PhoneNumber BIGINT,
@Password NVARCHAR(100),
@BirthDate DATE,
@City iNT,
@IsActive BIT
AS
BEGIN
	INSERT INTO tblUsers (UserName, [Role],EmailId, PhoneNumber, [Password],BirthDate,
	City,IsActive)
	VALUES 
	(@UserName,@Role,@EmailId, @PhoneNumber, @Password,@BirthDate,@City,
	 @IsActive)
END;

go

EXEC sp_tblUsersInsert 'm',1,'mit@gmail.com',5678963260, 'm','2003-02-20',1,1
 
go

-- 4
CREATE PROCEDURE sp_tblGroupsInsert
@GroupName NVARCHAR(100),
@Description NVARCHAR(MAX),
@IsActive BIT,
@CreatedBy INT
AS
BEGIN
	INSERT INTO tblGroups (GroupName,[Description],IsActive,CreatedAt,CreatedBy)
	VALUES 
	(@GroupName, @Description,@IsActive,GETDATE(),@CreatedBy)
END;

go

EXEC sp_tblGroupsInsert 'Entertainment','Post related to fun activities.',1,1
 
go


--5
CREATE PROCEDURE sp_tblSubGroupsInsert
@tblSubGroups NVARCHAR(100),
@Group INT,
@Description NVARCHAR(MAX),
@IsActive BIT,
@CreatedBy INT
AS
BEGIN
	INSERT INTO tblSubGroups (SubGroupName,[Group],[Description],IsActive,CreatedAt,CreatedBy)
	VALUES 
	(@tblSubGroups, @Group, @Description, @IsActive, GETDATE(), @CreatedBy )
END;
go

EXEC sp_tblSubGroupsInsert 'Animation',1,'Augemented Reality',1,1
 
go

-- 6
CREATE PROCEDURE sp_tblGroupPostInsert
@PostedBy INT,
@Title NVARCHAR(100),
@Content NVARCHAR(MAX),
@Image1 VARBINARY(MAX),
@Image2 VARBINARY(MAX)
AS
BEGIN
	INSERT INTO tblGroupPosts (PostedBy,Title,Content,Image1,Image2,PostedDate)
	VALUES 
	(@PostedBy, @Title, @Content, @Image1, @Image2,GETDATE() )
END;
go

--EXEC sp_tblGroupPostInsert 1,'Doremon',Null,'C:Photos/img1','C:Photos/img2'
 
 go


---- Select table by name

--CREATE PROCEDURE sp_Select_Anytable
--@tableName NVARCHAR(MAX)
--AS
--BEGIN
	--DECLARE @sql NVARCHAR(MAX)
	--SET @sql = 'SELECT * FROM ' + @tableName
	--EXECUTE sp_executesql  @sql
--END
--go