
--q1
CREATE PROCEDURE sp_tblUsersSelect
AS
BEGIN
	SELECT u.FirstName + ' ' + u.LastName AS FullName, u.EmailId, u.BirthDate, c.CityName , u.JoiningDate   
	FROM tblUsers u JOIN tblCities c ON c.CityId = u.City
	WHERE u.IsActive = 1
END
go

--q2,q3
CREATE PROCEDURE sp_Select_table
@tableName NVARCHAR(MAX),
@Id NVARCHAR(MAX),
@Name NVARCHAR(MAX)
AS
BEGIN
	DECLARE @sql NVARCHAR(MAX)
	SET @sql = 'SELECT ' + @Id + ','+ @Name + ' FROM ' + @tableName
	EXEC sp_executesql @sql
END
go

--q4
CREATE PROCEDURE sp_Select_activeGroup
AS
BEGIN
	SELECT * FROM tblGroups WHERE IsActive = 1 ORDER BY GroupName
END
go

--q5
CREATE PROCEDURE sp_Select_GroupByUser
AS
BEGIN
	SELECT grp.GroupId, grp.GroupName, grp.CreatedAt,u.FirstName AS CreatedBy
	FROM tblGroups grp JOIN tblUsers u ON u.UserId = grp.CreatedBy 
	ORDER BY grp.GroupName
END
go


--q6
CREATE PROCEDURE sp_Select_GroupByRole
AS
BEGIN
	SELECT grp.GroupId, grp.GroupName, grp.CreatedAt,u.FirstName AS CreatedBy, r.RoleName AS [Role] 
	FROM tblGroups grp 
	JOIN tblUsers u ON u.UserId = grp.CreatedBy 
	JOIN tblRoles r ON r.RoleId = u.Role 
	ORDER BY grp.GroupName
END
go

--q7
CREATE PROCEDURE sp_Select_subGroupWithGroup
AS
BEGIN
	SELECT subGrp.SubGroupName,grp.GroupName FROM tblSubGroups subGrp 
	JOIN tblGroups grp ON grp.GroupId = subGrp.[Group]  
	ORDER BY grp.GroupName
END
go


--q8
CREATE PROCEDURE sp_tblGroupPostSelect
AS
BEGIN
	SELECT * FROM tblGroupPosts post ORDER BY CreatedAt DESC
END
go

--q9
CREATE PROCEDURE sp_Select_PostByUser
@user NVARCHAR(100)
AS
BEGIN
	SELECT post.Title, u.FirstName AS Reference, post.CreatedAt , post.LikeCount 
	FROM tblGroupPosts post JOIN tblUsers u On u.UserId = post.Reference
	WHERE u.FirstName = @user
END
go

--q10
CREATE PROCEDURE sp_Select_PostByRole
@roleName NVARCHAR(100)
AS
BEGIN
	SELECT post.Title, u.FirstName AS Reference, r.RoleName AS [Role] , 
	post.CreatedAt, post.LikeCount 
	FROM tblGroupPosts post 
	JOIN tblUsers u ON u.UserId = post.Reference 
	JOIN tblRoles r ON r.RoleId = u.[Role]
	WHERE r.RoleName = @roleName
END
go


--Below queries
CREATE PROCEDURE sp_Select_usersWithRoleCity
AS
BEGIN
	SELECT FirstName + ' ' + LastName AS FullName,r.RoleName AS [Role], EmailId AS Email,
	PhoneNumber AS PhoneNumber,BirthDate,c.CityName AS City 
	FROM tblUsers u JOIN tblRoles r ON r.RoleId=u.[Role] 
	JOIN tblCities c ON c.CityId=u.City order by r.RoleName
END
go

CREATE PROCEDURE sp_Select_SubGroupGroupName
AS
BEGIN
	 SELECT SubGroupName AS SubGroupName,grp.GroupName AS GroupName 
 FROM tblSubGroups sub 
 JOIN tblGroups grp ON sub.CreatedBy = grp.GroupId 
 ORDER BY grp.GroupName
END
go

CREATE PROCEDURE sp_Select_BirthDayUser
AS
BEGIN
	 SELECT * From tblUsers WHERE BirthDate = GETDATE()
END
go

CREATE PROCEDURE sp_Select_TwoDaysPost
AS
BEGIN
	SELECT * FROM tblGroupPosts WHERE CreatedAt > CAST(GETDATE()-2 AS Date) 
 ORDER BY CreatedAt DESC  --Including today
END
go

CREATE PROCEDURE sp_Select_ActiveUsers
AS
BEGIN
	SELECT FirstName + ' ' + LastName AS FullName,r.RoleName,post.Title,u.FirstName,
	post.LikeCount,post.CreatedAt FROM tblUsers u 
	JOIN tblRoles r ON r.RoleId=u.[Role] 
	JOIN tblGroupPosts post ON post.Reference = u.UserId 
	WHERE u.IsActive = 1

END
go

CREATE PROCEDURE sp_Select_FirstJoinUser
AS
BEGIN
	SELECT * FROM tblGroupPosts post JOIN tblUsers u ON u.UserId = post.Reference 
	WHERE JoiningDate = (SELECT TOP 1 JoiningDate FROM tblUsers ORDER BY JoiningDate)
END



go


-- SP for SELECT

--q1
EXEC sp_tblUsersSelect
go

--q2
EXEC sp_Select_table 'tblCities', 'CityId', 'CityName'
go
--q3
EXEC sp_Select_table 'tblRoles', 'RoleId', 'RoleName'

--q4
EXEC sp_Select_activeGroup
go

--q5
EXEC sp_Select_GroupByUser
go

--q6
EXEC sp_Select_GroupByRole
go

--Q7
EXEC sp_Select_subGroupWithGroup
go

--q8
EXEC sp_tblGroupPostSelect
go

--q9
EXEC sp_Select_PostByUser 'Jay'
go

--q10
EXEC sp_Select_PostByRole 'Tester'




---Below queries

--Q5:
EXEC sp_Select_usersWithRoleCity
go

--Q6:
EXEC sp_Select_SubGroupGroupName
go

--Q7: 
EXEC sp_Select_BirthDayUser
go

 --Q8: 
--EXEC sp_Update_CreatedDate
--go
EXEC sp_Select_TwoDaysPost
go

--Q9:
EXEC sp_Select_ActiveUsers
go

--Q10:
EXEC sp_Select_FirstJoinUser