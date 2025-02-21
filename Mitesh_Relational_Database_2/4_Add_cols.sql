
--T1
ALTER TABLE tblCities ADD UpdatedDate DATETIME2, UpdateBy INT 
CONSTRAINT FK_tblCities_tblUsers FOREIGN KEY (UpdateBy) REFERENCES tblUsers(userId)
go

--T2
ALTER TABLE tblRoles ADD UpdatedDate DATETIME2, UpdateBy  INT 
CONSTRAINT FK_tblRoles_tblUsers FOREIGN KEY (UpdateBy) REFERENCES tblUsers(userId)
go

--T3
ALTER TABLE tblUsers ADD UpdatedDate DATETIME2, UpdateBy VARCHAR(100)
go

--T4
ALTER TABLE tblGroups ADD UpdatedDate DATETIME2, UpdateBy  INT 
CONSTRAINT FK_tblGroups_tblUsers2 FOREIGN KEY (UpdateBy) REFERENCES tblUsers(userId)
go

--T5
ALTER TABLE tblSubGroups ADD UpdatedDate DATETIME2, UpdateBy  INT 
CONSTRAINT FK_tblSubGroups_tblUsers2 FOREIGN KEY (UpdateBy) REFERENCES tblUsers(userId)
go

--T6
ALTER TABLE tblGroupPosts ADD UpdatedDate DATETIME2