--Q5: “All” Users (First Name + Last Name, Role name, Email id, Phone number, Birth Date, City) – and users - role wise
EXEC sp_Select_users
go

--Q6: “All” Sub Groups – and Sub groups – group wise
EXEC sp_Select_SubGrp
go

--Q7: Select Users whose birthdate is today
EXEC sp_Select_BirthDayUser
go

 --Q8: Select posts of last 2 days – l-test on top
--EXEC sp_Update_CreatedDate
--go
EXEC sp_Select_TwoDaysPost
go

--Q9: Select posts of particular active user (First name + Last Name, Role, Post Title, Reference, Likes count, Post creation date)
EXEC sp_Select_ActiveUsers
go

--Q10: Select posts of employee who had joined company first.
EXEC sp_Select_FirstJoinUser