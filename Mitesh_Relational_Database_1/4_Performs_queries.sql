use PostDoc

-- Q1: All the cities
 SELECT * FROM tblCities
 go

 -- Q2:  All roles
 SELECT * FROM tblRoles 
 go

--Q3 :All Users
SELECT * FROM tblUsers
go

--Q4: All Groups
SELECT * FROM tblGroups
go

 --Q5: “All” Users (First Name + Last Name, Role name, Email id, Phone number, Birth Date, City) – and users - role wise
 SELECT FirstName + ' ' + LastName AS FullName,r.RoleName AS [Role], EmailId AS Email,PhoneNumber AS PhoneNumber,BirthDate,c.CityName AS City FROM 
 tblUsers u JOIN tblRoles r ON r.RoleId=u.[Role] JOIN tblCities c ON c.CityId=u.City order by r.RoleName
go

 --Q6: “All” Sub Groups – and Sub groups – group wise
 SELECT SubGroupName AS SubGroupName,grp.GroupName AS GroupName FROM tblSubGroups sub JOIN tblGroups grp ON sub.CreatedBy = grp.GroupId 
 ORDER BY grp.GroupName
go

 --Q7: Select Users whose birthdate is today
 SELECT * From tblUsers WHERE BirthDate = CAST(GETDATE() AS Date)
go

UPDATE tblGroupPosts SET CreatedAt = '2025-02-16' WHERE PostId = 1
UPDATE tblGroupPosts SET CreatedAt = '2025-02-17' WHERE PostId = 2
UPDATE tblGroupPosts SET CreatedAt = '2025-02-15' WHERE PostId = 3
go
 --Q8: Select posts of last 2 days – l-test on top
 SELECT * FROM tblGroupPosts WHERE CreatedAt > CAST(GETDATE()-2 AS Date) ORDER BY CreatedAt DESC  --Including today
go

 --Q9: Select posts of particular active user (First name + Last Name, Role, Post Title, Reference, Likes count, Post creation date)
 SELECT FirstName + ' ' + LastName AS FullName,r.RoleName,post.Title,u.FirstName,post.LikeCount,post.CreatedAt FROM tblUsers u JOIN tblRoles r ON r.RoleId=u.[Role] JOIN tblGroupPosts post ON post.Reference = u.UserId WHERE u.IsActive = 1
go

 --Q10: Select posts of employee who had joined company first.
 SELECT * FROM tblGroupPosts post JOIN tblUsers u ON u.UserId = post.Reference WHERE JoiningDate = (SELECT MIN(JoiningDate) FROM tblUsers)
