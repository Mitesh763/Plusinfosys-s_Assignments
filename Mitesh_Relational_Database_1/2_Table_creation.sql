use PostDoc

-- T1: City(name)
CREATE TABLE tblCities (
	CityId INT IDENTITY(1,1),
	CityName NVARCHAR(100) NOT NULL,
	CONSTRAINT PK_tblCities PRIMARY KEY (CityId),
	CONSTRAINT UQ_tblCities_Name UNIQUE (CityName)
)

go

SELECT * FROM tblCities

go

-- T2: Roles (name)
CREATE TABLE tblRoles(
	RoleId INT IDENTITY(1,1),
	RoleName NVARCHAR(100) NOT NULL,
	CONSTRAINT PK_tblRoles PRIMARY KEY (RoleId),
	CONSTRAINT UQ_tblRoles_Name UNIQUE (RoleName)
)

go
SELECT * FROM tblRoles
go

-- T3: Users (First name, Last name, role, email id, password, phone number, photo, birth date, address, city, Joining date, created date, photo, active)
CREATE TABLE tblUsers(
	UserId INT IDENTITY(1,1),
	FirstName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR(100),
	[Role] INT,
	EmailId NVARCHAR(100) NOT NULL,
	[Password] NVARCHAR(100) NOT NULL,
	PhoneNumber BIGINT UNIQUE,
	Photo NVARCHAR(MAX),
	BirthDate DATE,
	[Address] NVARCHAR(MAX) NOT NULL,
	City INT,
	JoiningDate DATETIME2 NOT NULL DEFAULT CAST(GETDATE() AS Date),
	CreatedAt DATE NOT NULL,
	IsActive BIT NOT NULL DEFAULT 1,
	CONSTRAINT PK_tblUsers PRIMARY KEY (UserId),
	CONSTRAINT UQ_tbleUsers_Email UNIQUE (EmailId),
	CONSTRAINT UQ_tblUsers_Phone UNIQUE (PhoneNumber),
	CONSTRAINT FK_tblUsers_tblRoles FOREIGN KEY ([Role]) REFERENCES tblRoles(RoleId),
	CONSTRAINT FK_tblUsers_tblCities FOREIGN KEY (City) REFERENCES tblCities(CityId),
)
go
SELECT * FROM tblUsers
go

-- T4: Groups (Name, Description, Active, Created date, Created by)
CREATE TABLE tblGroups(
	GroupId INT IDENTITY(1,1),
	GroupName NVARCHAR(100) NOT NULL,
	[Description] NVARCHAR(MAX),
	IsActive BIT NOT NULL DEFAULT 1,
	CreatedAt DATE NOT NULL,
	CreatedBy INT,
	CONSTRAINT PK_tblGroups PRIMARY KEY (GroupId),
	CONSTRAINT UQ_tblGroups_Name UNIQUE (GroupName),
	CONSTRAINT FK_tblGroups_tblUsers  FOREIGN KEY (CreatedBy) REFERENCES tblUsers(UserId)
)
go
SELECT * FROM tblGroups
go

-- T5:Sub Groups (Name, Group, Description, Active, Created date, Created by)
CREATE TABLE tblSubGroups(
	SubGroupId INT IDENTITY(1,1),
	SubGroupName NVARCHAR(100) NOT NULL,
	[Group] INT,
	[Description] NVARCHAR(MAX),
	IsActive BIT DEFAULT 1,
	CreatedAt DATE NOT NULL,
	CreatedBy INT,
	CONSTRAINT PK_tblSubGroups PRIMARY KEY (SubGroupId),
	CONSTRAINT UQ_tblSubGroup_Name UNIQUE (SubGroupName),
	CONSTRAINT FK_tblSubGroups_tblGroups FOREIGN KEY ([Group] ) REFERENCES tblGroups(GroupId),
	CONSTRAINT FK_tblSubGroups_tblUsers FOREIGN KEY (CreatedBy) REFERENCES tblUsers(UserId)
)
go
SELECT * FROM tblSubGroups
go

-- T6: Group Posts (Posted by, Title, Content, Image 1, Image 2, Reference, Like count, Created date)
CREATE TABLE tblGroupPosts(
	PostId INT IDENTITY(1,1),
	PostedBy INT,
	Title NVARCHAR(50),
	Content NVARCHAR(100),
	Image1 NVARCHAR(MAX),
	Image2 NVARCHAR(MAX),
	Reference INT,
	LikeCount INT DEFAULT 0,
	CreatedAt DATE NOT NULL,
	CONSTRAINT PK_tblGroupPosts PRIMARY KEY (PostId),
	CONSTRAINT FK_tblGroupPosts_tblSubGroups FOREIGN KEY (PostedBy) REFERENCES tblSubGroups(SubGroupId),
	CONSTRAINT FK_tblGroupPosts_tblUsers FOREIGN KEY (Reference) REFERENCES tblUsers(UserId)
)
go
 SELECT * FROM tblGroupPosts;