
--u1
CREATE PROCEDURE sp_tblCitiesUpadate
@cityId INT,
@NewCityName NVARCHAR(100)
AS
BEGIN
	UPDATE tblCities SET CityName = @NewCityName,UpdatedDate = GETDATE(), UpdateBy = 2
	WHERE CityId = @cityId
END
go

--u2
CREATE PROCEDURE sp_tblRolesUpdate
@roleId INT,
@newRoleName NVARCHAR(10)
AS
BEGIN
	UPDATE tblRoles SET RoleName = @newRoleName,UpdatedDate = GETDATE(), UpdateBy = 3
	WHERE RoleId = @roleId
END
go

--u3
CREATE PROCEDURE sp_tblUsersUpdate
@userId INT,
@newFirstName NVARCHAR(100),
@newLastName NVARCHAR(100),
@newRoleId INT,
@newEmail NVARCHAR(MAX),
@newPassword NVARCHAR(MAX),
@newNumber BIGINT,
@newPhoto NVARCHAR(MAX),
@newBirthDate DATETIME2,
@newAddress NVARCHAR(MAX),
@newCityId INT,
@newJoinDate DATETIME2,
@newCreatedDate DATETIME2,
@newActiveStatus BIT
AS
BEGIN
	UPDATE tblUsers SET 
	FirstName = @newFirstName, LastName=@newLastName,
	[Role] = @newRoleId,EmailId = @newEmail,
	[Password] = @newPassword, PhoneNumber = @newNumber, 
	Photo=@newPhoto, BirthDate = @newBirthDate, [Address] = @newAddress, 
	City = @newCityId, JoiningDate = @newJoinDate, CreatedAt = @newCreatedDate,
	IsActive = @newActiveStatus, UpdatedDate = GETDATE(), UpdateBy = 1
	WHERE UserId = @userId
END
go

--u4
CREATE PROCEDURE sp_tblGroupsUpdate
@groupId INT,
@newGroupName NVARCHAR(100),
@newDescription NVARCHAR(MAX),
@newActiveStatus BIT,
@newCreatedDate DATETIME2,
@newCreatedById INT
AS
BEGIN
	UPDATE tblGroups SET 
	GroupName = @newGroupName, [Description] = @newDescription, IsActive = @newActiveStatus,
	CreatedAt = @newCreatedDate, CreatedBy = @newCreatedById , 
	UpdatedDate = GETDATE() , UpdateBy = 2
	WHERE GroupId = @groupId
END
go

--u5
CREATE PROCEDURE sp_tblSubGroupsUpdate
@subGroupId INT,
@newSubGroupName NVARCHAR(100),
@newGroupId INT,
@newDescription NVARCHAR(MAX),
@newActiveStatus BIT,
@newCreatedAtDate DATETIME2,
@newCreatedById INT
AS
BEGIN
	UPDATE tblSubGroups SET 
	SubGroupName = @newSubGroupName, [Group] = @newGroupId, 
	[Description] = @newDescription, IsActive = @newActiveStatus,
	CreatedAt = @newCreatedAtDate, CreatedBy = @newCreatedById , 
	UpdatedDate = GETDATE(), UpdateBy = 1
	WHERE SubGroupId = @subGroupId
END
go

--u6
CREATE PROCEDURE sp_tblGroupPostsUpdate
@postId INT,
@newGrpId INT,
@newTitle NVARCHAR(100),
@newContent NVARCHAR(MAX),
@newImage1 NVARCHAR(MAX),
@newImage2 NVARCHAR(MAX),
@newReference INT,
@newLikes INT,
@newCreatedDate DATETIME2
AS
BEGIN
	UPDATE tblGroupPosts SET 
	PostedBy = @newGrpId, Title = @newTitle, Content = @newContent,
	Image1 = @newImage1, Image2 = @newImage2, Reference= @newReference,
	LikeCount = @newLikes, CreatedAt = @newCreatedDate,
	UpdatedDate = GETDATE()
	WHERE PostId = @postId
END
go


--d1
CREATE PROCEDURE sp_tblCitiesDelete
@cityId INT
AS
BEGIN
	DELETE FROM tblCities
	WHERE CityId = @cityId
END
go


--d2
CREATE PROCEDURE sp_tblRolesDelete
@roleId INT
AS
BEGIN
	DELETE FROM tblRoles 
	WHERE RoleId = @roleId
END
go

--d3
CREATE PROCEDURE sp_tblUsersDelete
@userId INT
AS
BEGIN
	UPDATE tblUsers SET IsActive = 0, UpdatedDate = GETDATE(), UpdateBy = 2
	WHERE UserId = @userId
END
go

--d4
CREATE PROCEDURE sp_tblGroupsDelete
@groupId INT
AS
BEGIN
	UPDATE tblGroups SET IsActive = 0, UpdatedDate = GETDATE(), UpdateBy = 1
	WHERE GroupId = @groupId
END
go

--d5
CREATE PROCEDURE sp_tblSubGroupsDelete
@subGroupId INT
AS
BEGIN
	UPDATE tblSubGroups SET IsActive = 0, UpdatedDate = GETDATE(), UpdateBy = 2 
	WHERE SubGroupId = @subGroupId
END
go

--d6
CREATE PROCEDURE sp_tblGroupPostsDelete
@postId INT
AS
BEGIN
	DELETE FROM tblGroupPosts WHERE PostId = @postId
END
go


--- below queries

CREATE PROCEDURE sp_Update_UserJoining
@newDate DATE,
@userId INT
AS
BEGIN
	UPDATE tblUsers SET JoiningDate = @newDate, UpdatedDate = GETDATE(), UpdateBy = 1  WHERE UserId = @userId
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
	UPDATE tblGroups SET [Description] = @description, IsActive = @active, UpdateBy = 2
	WHERE  GroupId = @groupId
END
go


------- temp
CREATE PROCEDURE sp_Update_CreatedDate
AS
BEGIN
	UPDATE tblGroupPosts SET CreatedAt = GETDATE(), UpdatedDate = GETDATE() WHERE PostId = 1
	UPDATE tblGroupPosts SET CreatedAt = CAST(GETDATE()-1 AS DATE), UpdatedDate = GETDATE() 
	WHERE PostId = 2
	UPDATE tblGroupPosts SET CreatedAt = CAST(GETDATE()-2 AS DATE), UpdatedDate = GETDATE() 
	WHERE PostId = 3
END
go

CREATE PROCEDURE sp_Update_UserActiveStatus
AS
BEGIN
	UPDATE tblUsers SET IsActive = 1 WHERE UserId = 3
END