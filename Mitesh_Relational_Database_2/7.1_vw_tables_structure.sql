
-- View 1
CREATE VIEW vw_GroupSubGroupDetails
AS
	SELECT grp.GroupName,subG.SubGroupName,u.FirstName + ' ' + u.LastName AS UserName 
	FROM tblGroups grp
	JOIN tblSubGroups subG ON grp.GroupId = subG.[Group]
	JOIN tblUsers u ON u.UserId = grp.UpdateBy
	WHERE grp.UpdatedDate = CAST(GETDATE() AS DATE)
go

-- View 2
CREATE VIEW vw_GroupPost
AS
	SELECT post.Title, u.FirstName, post.LikeCount 
	FROM tblGroupPosts post 
	JOIN tblUsers u ON u.UserId = post.Reference 
	WHERE post.LikeCount > 10