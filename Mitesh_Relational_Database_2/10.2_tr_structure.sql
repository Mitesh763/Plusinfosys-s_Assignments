

--trigger


-- tr1: role
CREATE TRIGGER tr_roles ON tblRoles
AFTER UPDATE
AS
BEGIN
	INSERT INTO tblRoleLogs 
		( RoleName,UpdatedDate, UpdatedBy ) 
		SELECT 
			d.RoleName,
			CAST(GETDATE() AS DATE),
			d.UpdateBy
		FROM
			deleted d
END
go


-- tr1: role
CREATE TRIGGER tr_users ON tblUsers
AFTER  UPDATE
AS
BEGIN
	INSERT INTO tblUserLogs
		( FirstName,LastName, [Role],EmailId,[Password],PhoneNumber,Photo,BirthDate,[Address],City,JoiningDate
		,CreatedAt,IsActive,UpdatedDate,UpdatedBy ) 
		SELECT 
			i.FirstName,
			i.LastName,
			i.[Role],
			i.EmailId,
			i.[Password],
			i.PhoneNumber,
			i.Photo,
			i.BirthDate,
			i.[Address],
			i.City,
			i.JoiningDate,
			i.CreatedAt,
			i.IsActive,
			CAST(GETDATE() AS DATE),
			i.UpdateBy
		FROM
			deleted i
END
go


--EXEC sp_Update_RoleName 'CEO',1
--EXEC sp_Select_Anytable 'tblRoles'
--EXEC sp_Select_Anytable 'tblRoleLogs'
--go

--UPDATE tblUsers SET IsActive = 0 WHERE UserId = 2
--EXEC sp_Select_Anytable 'tblUsers'
--EXEC sp_Select_Anytable 'tblUserLogs'

