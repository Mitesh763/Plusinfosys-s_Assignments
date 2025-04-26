----update and delete

 EXEC sp_tblCitiesUpadate 5, 'Ayodhya'
 EXEC sp_Select_Anytable 'tblCities'
 go

 EXEC sp_tblRolesUpdate 1,'CEO'
 EXEC sp_Select_Anytable 'tblRoles'
 go

 EXEC sp_tblUsersUpdate 3, 'Ravi','Thummar', 6, 'raviP@gmail.com', 'ravi@123' ,3636363636, 'D://myPhoto1','2005-10-27 12:12:12.120','New India Colony',2, '2024-02-27 10:10:10.520','2025-01-17 02:02:02.520',1
 EXEC sp_Select_Anytable 'tblUsers'
 go

 EXEC sp_tblGroupsUpdate 1,'Movies', 'updates of latest movie.', 1, '2019-10-07 02:12:32.625', 3
 EXEC sp_Select_Anytable 'tblGroups'
 go

 EXEC sp_tblSubGroupsUpdate 5, 'Color Mixure', 4 , 'Make a new unique Color' , 1 , '2023-02-02 13:45:52.553', 2
 EXEC sp_Select_Anytable 'tblSubGroups'
 go

 EXEC sp_tblGroupPostsUpdate 3, 1,'oggy and the cockroaches In gujrati','In Gujrati', 'C:Photos/img10', 'C:Photos/img2222',4,50,'2005-10-27 12:12:12.120'
 EXEC sp_Select_Anytable 'tblGroupPosts'
 go
 
 EXEC sp_tblCitiesDelete 4
 EXEC sp_Select_Anytable 'tblCities'
go

 EXEC sp_tblRolesDelete 2
 EXEC sp_Select_Anytable 'tblRoles'
go

EXEC sp_tblUsersDelete 3
EXEC sp_Select_Anytable 'tblUsers'
go

EXEC sp_tblGroupsDelete 1
EXEC sp_Select_Anytable 'tblGroups'
go

EXEC sp_tblSubGroupsDelete 3
EXEC sp_Select_Anytable 'tblSubGroups'
go

EXEC sp_tblGroupPostsDelete 2
EXEC sp_Select_Anytable 'tblGroupPosts'
go

-- Below Queries
 EXEC sp_Update_UserJoining '2024-02-02 20:15:12.230', 3
 EXEC sp_Select_Anytable 'tblUsers'
 go

 EXEC sp_Delete_groupByHR
 EXEC sp_Select_Anytable 'tblGroups'
 go


 EXEC sp_Update_ActiveGroup 'Technology Make life easy!!!!!!', 0, 2
 EXEC sp_Select_Anytable 'tblGroups'
	