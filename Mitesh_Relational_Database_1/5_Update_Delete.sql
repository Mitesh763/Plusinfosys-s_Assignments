
use PostDoc

----update and delete
 UPDATE tblCities SET CityName = 'Ayodhya' WHERE CityId = 5
 SELECT * FROM tblCities
 go
 UPDATE tblRoles SET RoleName = 'CEO' WHERE RoleId = 2
 SELECT *FROM tblRoles
 go
 UPDATE tblUsers SET PhoneNumber = '9635215679',[Address]='Krishna Park' WHERE UserId = 3
 SELECT * FROM tblUsers
 go
 UPDATE tblUsers SET BirthDate = CAST(GETDATE() AS Date) WHERE UserId = 1
 SELECT * FROM tblUsers
 go
 UPDATE tblGroups SET CreatedAt = CAST(GETDATE() AS Date) WHERE GroupId = 1
 SELECT * FROM tblUsers
 go
 UPDATE  tblSubGroups SET CreatedAt = '2023-02-02'
 SELECT * FROM tblSubGroups
 go
 UPDATE tblGroupPosts SET Image2 = 'C:Photos/img10' WHERE PostId = 2
 SELECT * FROM tblGroupPosts

 go
 
DELETE FROM tblCities WHERE CityId = 4
go
DELETE FROM tblRoles WHERE RoleId = 2
go
DELETE FROM tblUsers WHERE UserId = 3
go
DELETE FROM tblGroups WHERE GroupId = 1
go
DELETE FROM tblSubGroups WHERE SubGroupId = 2
go
DELETE FROM tblGroupPosts WHERE PostId = 3
go

 UPDATE tblUsers SET JoiningDate = '2024-01-20' WHERE UserId = 2
 SELECT * FROM tblUsers

 go
 DELETE tblGroups FROM tblGroups JOIN tblUsers ON tblUsers.UserId = tblGroups.CreatedBy JOIN tblRoles ON tblRoles.RoleId = tblUsers.[Role] WHERE tblRoles.RoleName = 'HR'
 SELECT * FROM tblGroups
 go
 
 UPDATE tblGroupPosts SET Content = 'funny cartoon' WHERE PostId = 2
 SELECT * FROM tblGroupPosts
 go

 UPDATE tblGroups SET [Description]  = 'Technology Make life easy',IsActive = 1 WHERE  GroupId =3
 SELECT * FROM tblGroups
 go

 
 --ALTER TABLE tblRoles RENAME COLUMN UQ_tblRoles_Name TO RoleName

 go
 EXEC sp_rename 'tblRoles','Roles'
 go
 EXEC sp_rename 'Roles','tblRoles'
 go

 EXEC sp_rename 'tblRoles.RoleName','RoleName','COLUMN'
 EXEC sp_rename 'tblRoles.RoleName','RoleName','COLUMN'
 SELECT * FROM tblRoles

 ALTER TABLE tblGroupPosts Drop COLUMN Image2
 ALTER TABLE tblGroupPosts ADD Image2 NVARCHAR(MAX) DEFAULT NULL