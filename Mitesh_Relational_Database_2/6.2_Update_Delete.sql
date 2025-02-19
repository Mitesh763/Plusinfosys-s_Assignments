----update and delete

 EXEC sp_Update_CityName 'Ayodhya', 5
 EXEC sp_Select_Anytable 'tblCities'
 go

 EXEC sp_Update_RoleName 'CEO', 1
 EXEC sp_Select_Anytable 'tblRoles'
 go

 EXEC sp_Update_PhoneAndAddress '9635215679', 'Krishna Park', 3
 EXEC sp_Select_Anytable 'tblUsers'
 go

 --UPDATE tblUsers SET BirthDate = CAST(GETDATE() AS Date) WHERE UserId = 1
 --SELECT * FROM tblUsers
 --go

 EXEC sp_Update_GroupCreatedDate 1
 EXEC sp_Select_Anytable 'tblGroups'
 go

 EXEC sp_Update_SubGroupDate '2023-02-02', 2
 EXEC sp_Select_Anytable 'tblSubGroups'
 go

 EXEC sp_Update_GroupPostImage 'C:Photos/img10', 2
 EXEC sp_Select_Anytable 'tblGroupPosts'
 go
 
 EXEC sp_Delete_City 4
 EXEC sp_Select_Anytable 'tblCities'
go

 EXEC sp_Delete_Role 2
 EXEC sp_Select_Anytable 'tblRoles'
go

EXEC sp_Update_user 3
EXEC sp_Select_Anytable 'tblUsers'
go

EXEC sp_Update_Group 1
EXEC sp_Select_Anytable 'tblGroups'
go

EXEC sp_Update_subGroup 2
EXEC sp_Select_Anytable 'tblSubGroups'
go

EXEC sp_Delete_Post 2
EXEC sp_Select_Anytable 'tblGroupPosts'
go

-- Below Queries
 EXEC sp_Update_UserJoining '2024-02-02', 2
 EXEC sp_Select_Anytable 'tblUsers'
 go

 EXEC sp_Delete_groupByHR
 EXEC sp_Select_Anytable 'tblGroups'
 go


 EXEC sp_Update_ActiveGroup 'Technology Make life easy', 0, 3
 EXEC sp_Select_Anytable 'tblGroups'
	