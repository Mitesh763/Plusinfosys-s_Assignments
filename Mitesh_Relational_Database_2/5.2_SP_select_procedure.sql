

-- SP for SELECT

--q1
EXEC sp_Select_tblUsers
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
EXEC sp_Select_subGroup
go

--q8
EXEC sp_Select_GroupPost
go

--q9
EXEC sp_Select_PostByUser
go

--q10
EXEC sp_Select_PostByRole