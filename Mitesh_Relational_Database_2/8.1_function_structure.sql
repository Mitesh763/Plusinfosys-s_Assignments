

--UDF

-- scalar function
CREATE FUNCTION fn_GetDate(@dateTime DATETIME)
RETURNS DATE
AS
BEGIN
	RETURN CAST(@dateTime AS DATE)
END
go

-- inline table function
CREATE FUNCTION fn_PostByHR(@roleName NVARCHAR(100))
RETURNS TABLE
AS
	RETURN
		(
			SELECT post.Title, post.Content, post.LikeCount, u.FirstName AS Reference, post.UpdatedDate,r.RoleName 
			FROM tblGroupPosts post 
			JOIN tblUsers u ON u.UserId = post.Reference 
			JOIN tblRoles r ON r.RoleId = u.[Role]
			WHERE r.RoleName = @roleName
		)
