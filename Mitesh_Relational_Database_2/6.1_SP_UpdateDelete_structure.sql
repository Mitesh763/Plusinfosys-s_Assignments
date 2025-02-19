

CREATE PROCEDURE sp_Update_CityName
@NewCityName NVARCHAR(100),
@cityId INT
AS
BEGIN
	UPDATE tblCities SET CityName = @NewCityName,UpdatedDate = CAST(GETDATE() AS Date) 
	WHERE CityId = @cityId
END
go


CREATE PROCEDURE sp_Update_RoleName
@newRoleName NVARCHAR(10),
@roleId INT
AS
BEGIN
	UPDATE tblCities SET CityName = @newRoleName,UpdatedDate = CAST(GETDATE() AS Date)
	WHERE CityId = @roleId
END
go


CREATE PROCEDURE sp_Update_PhoneAndAddress
@newNumber BIGINT,
@newAddress NVARCHAR(MAX),
@userId INT
AS
BEGIN
	UPDATE tblUsers SET PhoneNumber = @newNumber, [Address] = @newAddress, UpdatedDate = CAST(GETDATE() 
	AS Date)
	WHERE UserId = @userId
END
go

CREATE PROCEDURE sp_Update_GroupCreatedDate
@groupId INT
AS
BEGIN
	UPDATE tblGroups SET CreatedAt = CAST(GETDATE() AS Date), UpdatedDate = CAST(GETDATE() 
	AS Date) 
	WHERE GroupId = @groupId
END
go

CREATE PROCEDURE sp_Update_SubGroupDate
@newDate DATE,
@subGroupId INT
AS
BEGIN
	UPDATE tblSubGroups SET CreatedAt = @newDate, UpdatedDate = CAST(GETDATE() 
	AS Date)
	WHERE SubGroupId = @subGroupId
END
go

CREATE PROCEDURE sp_Update_GroupPostImage
@newImage NVARCHAR(MAX),
@postId INT
AS
BEGIN
	UPDATE tblGroupPosts SET Image2 = @newImage, UpdatedDate = CAST(GETDATE() 
	AS Date) 
	WHERE PostId = @postId
END
go

CREATE PROCEDURE sp_Delete_City
@cityId INT
AS
BEGIN
	DELETE FROM tblCities
	WHERE CityId = @cityId
END
go


CREATE PROCEDURE sp_Delete_Role
@roleId INT
AS
BEGIN
	DELETE FROM tblRoles 
	WHERE RoleId = @roleId
END
go


CREATE PROCEDURE sp_Update_user
@userId INT
AS
BEGIN
	UPDATE tblUsers SET IsActive = 0 
	WHERE UserId = @userId
END
go

CREATE PROCEDURE sp_Update_Group
@userId INT
AS
BEGIN
	UPDATE tblUsers SET IsActive = 0 
	WHERE UserId = @userId
END
go


CREATE PROCEDURE sp_Update_subGroup
@userId INT
AS
BEGIN
	UPDATE tblUsers SET IsActive = 0 
	WHERE UserId = @userId
END
go



CREATE PROCEDURE sp_Delete_Post
@postId INT
AS
BEGIN
	DELETE FROM tblGroupPosts WHERE PostId = @postId
END
go

CREATE PROCEDURE sp_Update_UserJoining
@newDate DATE,
@userId INT
AS
BEGIN
	UPDATE tblUsers SET JoiningDate = @newDate, UpdatedDate = CAST(GETDATE() 
	AS Date) WHERE UserId = @userId
END
go

CREATE PROCEDURE sp_Delete_groupByHR
AS
BEGIN
	 DELETE tblGroups FROM tblGroups JOIN tblUsers ON tblUsers.UserId = tblGroups.CreatedBy 
 JOIN tblRoles ON tblRoles.RoleId = tblUsers.[Role] WHERE tblRoles.RoleName = 'HR'
END
go

CREATE PROCEDURE sp_Update_ActiveGroup
@description NVARCHAR(MAX),
@active BIT,
@groupId INT
AS
BEGIN
	UPDATE tblGroups SET [Description]  = @description, IsActive = @active 
	WHERE  GroupId = @groupId
END
go

CREATE PROCEDURE sp_Update_CreatedDate
AS
BEGIN
	UPDATE tblGroupPosts SET CreatedAt = CAST(GETDATE() AS DATE) WHERE PostId = 1
	UPDATE tblGroupPosts SET CreatedAt = CAST(GETDATE()-1 AS DATE) WHERE PostId = 2
	UPDATE tblGroupPosts SET CreatedAt = CAST(GETDATE()-2 AS DATE) WHERE PostId = 3
END
