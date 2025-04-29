CREATE PROCEDURE u_validateUser
@username NVARCHAR(MAX),
@password NVARCHAR(MAX)
AS
BEGIN
	SELECT * FROM tblUsers
	WHERE @password = (SELECT [Password] FROM tblUsers WHERE UserName = @username)
END