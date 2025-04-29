use Intranet

go

-- select all user
CREATE PROCEDURE sp_ValidateUse
@username NVARCHAR(MAX),
@password NVARCHAR(MAX)
AS
BEGIN
	SELECT * FROM tblUsers u
	JOIN tblCities city ON u.City = city.CityId
	JOIN tblRoles r ON u.Role = r.RoleId
	WHERE  u.UserName = @username AND u.[Password] = @password;
END

go

-- select all user
CREATE PROCEDURE sp_tblUsersSelect
AS
BEGIN
	SELECT * FROM tblUsers u
	JOIN tblCities city ON u.City = city.CityId
	JOIN tblRoles r ON u.Role = r.RoleId
	WHERE u.IsActive = 1
END

go

-- select role
CREATE PROCEDURE sp_tblRolesSelect
AS
BEGIN
	SELECT * FROM tblRoles
END

go


-- select partcular user
CREATE PROCEDURE sp_UserSelect
@UserId NVARCHAR(MAX)
AS
BEGIN
	SELECT * FROM tblUsers u
	JOIN tblCities city ON u.City = city.CityId
	JOIN tblRoles r ON u.Role = r.RoleId
	WHERE u.UserId = @UserId
END

go

-- select city
CREATE PROCEDURE sp_tblCitiesSelect
AS
BEGIN
	SELECT * FROM tblCities
END

go

-- select Group
CREATE PROCEDURE sp_tblGroupSelect
AS
BEGIN
	SELECT * FROM tblGroups g
	JOIN tblUsers u ON u.UserId = g.CreatedBy
	WHERE g.IsActive = 1
END

go


-- select Sub Group
CREATE PROCEDURE sp_tblSubGroupSelect
AS
BEGIN
	SELECT * FROM tblSubGroups sg
	JOIN tblUsers u ON u.UserId = sg.CreatedBy
	JOIN tblGroups g ON g.GroupId = sg.[Group]
	WHERE sg.IsActive = 1
END
go

-- select role
CREATE PROCEDURE sp_tblRolesSelectById
@RoleId INT
AS
BEGIN
	SELECT * FROM tblRoles WHERE RoleId = @RoleId
END
go

-- Update role
CREATE PROCEDURE sp_tblRolesUpdate
@RoleId INT,
@RoleName NVARCHAR(MAX)
AS
BEGIN
	UPDATE tblRoles SET RoleName = @RoleName, UpdatedDate = GETDATE(),UpdateBy = 1
	WHERE RoleId = @RoleId
END
go

-- Delete role
CREATE PROCEDURE sp_tblRolesDelete
@RoleId INT
AS
BEGIN
	DELETE FROM tblRoles WHERE RoleId = @RoleId
END
go

-- select City by id
CREATE PROCEDURE sp_tblCitiesSelectById
@CityId INT
AS
BEGIN
	SELECT * FROM tblCities WHERE CityId = @CityId
END
go

-- Update role
CREATE PROCEDURE sp_tblCitiesUpdate
@CityId INT,
@CityName NVARCHAR(MAX)
AS
BEGIN
	UPDATE tblCities SET CityName = @CityName, UpdatedDate = GETDATE(),UpdateBy = 1
	WHERE CityId = @CityId
END
go

-- Delete City
CREATE PROCEDURE sp_tblCitiesDelete
@CityId INT
AS
BEGIN
	DELETE FROM tblCities WHERE CityId = @CityId
END
go 

-- select all user name
CREATE PROCEDURE sp_tblUserNameSelect
AS
BEGIN
	SELECT * FROM tblUsers
END
go

-- select all Group name
CREATE PROCEDURE sp_tblGroupNameSelect
AS
BEGIN
	SELECT * FROM tblGroups 
END
go


-- select Group by id
CREATE PROCEDURE sp_tblGroupSelectById
@GroupId INT
AS
BEGIN
	SELECT * FROM tblGroups g
	JOIN tblUsers u ON g.CreatedBy = u.UserId
	WHERE GroupId = @GroupId
END
go

--Update group
CREATE PROCEDURE sp_tblGroupsUpdate
@GroupId INT,
@GroupName NVARCHAR(MAX),
@Description NVARCHAR(MAX),
@IsActive BIT
AS
BEGIN
		UPDATE tblGroups 
		SET GroupName  = @GroupName, [Description] = @Description, IsActive = @IsActive, UpdatedDate = GETDATE(),UpdateBy = 1
		WHERE GroupId = @GroupId
END
go

-- DELETE group 
CREATE PROCEDURE sp_tblGroupDelete
@GroupId INT
AS 
BEGIN
	UPDATE tblGroups SET IsActive = 0, UpdatedDate = GETDATE(),UpdateBy = 1 WHERE GroupId = @GroupId 
END
go

-- SELECT SUBGROUP BY ID
CREATE PROCEDURE sp_tblSubGroupSelectById
@SubGroupId INT
AS 
BEGIN
	SELECT * FROM tblSubGroups sg
	JOIN tblGroups g ON sg.CreatedBy = g.GroupId
	WHERE SubGroupId = @SubGroupId
END
go

-- update subgroup 
CREATE PROCEDURE sp_tblSubGroupUpdate
@SubGroupId INT,
@tblSubGroups NVARCHAR(100),
@Group INT,
@Description NVARCHAR(MAX),
@IsActive BIT
AS
BEGIN
	UPDATE tblSubGroups 
	SET
	SubGroupName = @tblSubGroups, [Group] = @Group, 
	Description = @Description, IsActive = @IsActive, UpdatedDate = GETDATE(),UpdateBy = 1
	WHERE SubGroupId  =@SubGroupId
END;
go

--Delete SubGroup Id
CREATE PROCEDURE sp_tblSubGroupDelete
@subGroupId INT
AS
BEGIN
	UPDATE tblSubGroups SET IsActive = 0, UpdatedDate = GETDATE(),UpdateBy = 1 WHERE SubGroupId = @subGroupId 
END
go

-- select user by id
CREATE PROCEDURE sp_tblUsersSelectById
@UserId INT
AS
BEGIN
	SELECT * FROM tblUsers u
	JOIN tblRoles r ON u.[Role] = r.RoleId
	JOIN tblCities c ON c.CityId = u.City
	WHERE UserId = @UserId
END
go

-- update user
CREATE PROCEDURE sp_tblUsersUpdate
@UserId INT,
@UserName NVARCHAR(MAX),
@Role INT,
@EmailId NVARCHAR(MAX),
@PhoneNumber BIGINT,
@Password NVARCHAR(MAX),
@BirthDate DATE,
@City INT,
@IsActive BIT
AS
BEGIN
	UPDATE tblUsers SET
	UserName = @UserName, [Role] = @Role, EmailId = @EmailId, PhoneNumber = @PhoneNumber,
	[Password] = @Password, BirthDate = @BirthDate, City = @City, IsActive = @IsActive,
	UpdatedDate = GETDATE()
	WHERE UserId = @UserId
END
go

-- delete user
CREATE PROCEDURE sp_UserDelete
@UserId INT
AS 
BEGIN
	UPDATE tblUsers SET IsActive = 0 WHERE UserId = @UserId
END
go

-- select Subgroup
CREATE PROCEDURE sp_tblSubGroupNameSelect
AS 
BEGIN
	SELECT * FROM tblSubGroups
END
go

--select Post
CREATE PROCEDURE sp_tblGroupPostSelect
@PostId INT
AS
BEGIN
	SELECT * FROM tblGroupPosts WHERE PostId = @PostId
END
go

-- select all post
CREATE PROCEDURE sp_tblGroupPostSelectBySubGroup
AS
BEGIN
	SELECT * FROM tblGroupPosts post 
	JOIN tblSubGroups sg ON post.PostedBy = sg.SubGroupId
END
go	

-- like
CREATE PROCEDURE sp_tblGroupPostsLikePost
@PostId INT
AS
BEGIN
	SELECT LikeCount FROM tblGroupPosts WHERE PostId = @PostId
END
go

-- update like
CREATE PROCEDURE sp_tblGroupPostsUpdateLike
@PostId INT,
@LikeCount INT
AS
BEGIN
	UPDATE tblGroupPosts SET LikeCount = @LikeCount WHERE PostId = @PostId
END
go