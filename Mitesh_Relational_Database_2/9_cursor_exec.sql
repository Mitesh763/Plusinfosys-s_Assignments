

-- Cursor
DECLARE @firstName NVARCHAR(100)
DECLARE @lastName NVARCHAR(100)
DECLARE @role NVARCHAR(100)

DECLARE cursorNameWithRole CURSOR FOR SELECT FirstName, LastName, r.RoleName FROM tblUsers u 
										JOIN tblRoles r ON r.RoleId = u.[Role]
OPEN cursorNameWithRole

FETCH cursorNameWithRole INTO @firstName, @lastName, @role
WHILE(@@FETCH_STATUS = 0)
BEGIN
	Print @firstName + ' ' + @lastName  + ' is ' + @role + '.'
FETCH cursorNameWithRole INTO @firstName, @lastName, @role
END

CLOSE cursorNameWithRole

DEALLOCATE cursorNameWithRole