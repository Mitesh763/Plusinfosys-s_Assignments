-- DATABASE

CREATE DATABASE PostDoc
use PostDoc

-- T1: City(name)
CREATE TABLE tblCities (
	PK_tblCities INT IDENTITY(1,1) PRIMARY KEY,
	UQ_tblCities_Name NVARCHAR(100) UNIQUE NOT NULL 
)

go

SELECT * FROM tblCities

go

-- T2: Roles (name)
CREATE TABLE tblRoles(
	PK_tblRoles INT IDENTITY(1,1) PRIMARY KEY,
	UQ_tblRoles_Name NVARCHAR(100) UNIQUE NOT NULL
)
SELECT * FROM tblRoles

go

-- T3: Users (First name, Last name, role, email id, password, phone number, photo, birth date, address, city, Joining date, created date, photo, active)
CREATE TABLE tblUsers(
	PK_tblUsers INT IDENTITY(1,1) PRIMARY KEY,
	FirstName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR(100),
	FK_tblUsers_tblRoles INT,
	UQ_tbleUsers_Email NVARCHAR(100) UNIQUE NOT NULL,
	[Password] NVARCHAR(100) NOT NULL,
	UQ_tblUsers_Phone BIGINT UNIQUE,
	Photo NVARCHAR(MAX),
	BirthDate DATE,
	[Address] NVARCHAR(MAX) NOT NULL,
	FK_tblUsers_tblCities INT,
	JoiningDate DATETIME2 NOT NULL DEFAULT CAST(GETDATE() AS Date),
	CreatedAt DATE NOT NULL,
	IsActive BIT NOT NULL DEFAULT 1,
	FOREIGN KEY (FK_tblUsers_tblRoles) REFERENCES tblRoles(PK_tblRoles) ON UPDATE CASCADE ON DELETE SET NULL,
	FOREIGN KEY (FK_tblUsers_tblCities) REFERENCES tblCities(PK_tblCities) ON UPDATE CASCADE ON DELETE SET NULL,
)
SELECT * FROM tblUsers

-- T4: Groups (Name, Description, Active, Created date, Created by)
CREATE TABLE tblGroups(
	PK_tblGroups INT IDENTITY(1,1) PRIMARY KEY,
	UQ_tblGroups_Name NVARCHAR(100) UNIQUE NOT NULL,
	[Description] NVARCHAR(MAX),
	IsActive BIT NOT NULL DEFAULT 1,
	CreatedAt DATE NOT NULL,
	FK_tblGroups_tblUsers INT,
	FOREIGN KEY (FK_tblGroups_tblUsers) REFERENCES tblUsers(PK_tblUsers) ON UPDATE CASCADE ON DELETE SET NULL
)
SELECT * FROM tblGroups
go

-- T5:Sub Groups (Name, Group, Description, Active, Created date, Created by)
CREATE TABLE tblSubGroups(
	PK_tblSubGroup INT IDENTITY(1,1) PRIMARY KEY,
	UQ_tblSubGroup_Name NVARCHAR(100) NOT NULL UNIQUE,
	FK_tblSubGroups_tblGroups INT,
	[Description] NVARCHAR(MAX),
	IsActive BIT DEFAULT 1,
	CreatedAt DATE NOT NULL,
	FK_tblSubGroups_tblUsers INT,
	FOREIGN KEY (FK_tblSubGroups_tblGroups) REFERENCES tblGroups(PK_tblGroups),
	FOREIGN KEY (FK_tblSubGroups_tblUsers) REFERENCES tblUsers(PK_tblUsers)
)
SELECT * FROM tblSubGroups

go

-- T6: Group Posts (Posted by, Title, Content, Image 1, Image 2, Reference, Like count, Created date)
CREATE TABLE tblGroupPosts(
	PK_tblGroupPosts INT PRIMARY KEY IDENTITY(1,1),
	FK_tblGroupPosts_tblSubGroups INT NOT NULL,
	Title NVARCHAR(50),
	Content NVARCHAR(100),
	Image1 IMAGE,
	Image2 IMAGE,
	FK_tblGroupPosts_tblUsers INT,
	LikeCount INT DEFAULT 0,
	CreatedAt DATE NOT NULL,
	FOREIGN KEY (FK_tblGroupPosts_tblSubGroups) REFERENCES tblSubGroups(PK_tblSubGroup),
	FOREIGN KEY (FK_tblGroupPosts_tblUsers) REFERENCES tblUsers(PK_tblUsers)
)
 SELECT * FROM tblGroupPosts;

------ INSERTION 

 --T1:
 INSERT INTO tblCities (UQ_tblCities_Name) 
 VALUES ('Ahmedabad'),('Surat'),('Mumbai'),('Pune'),('Delhi')

 --T2:
 INSERT INTO tblRoles (UQ_tblRoles_Name)
 VALUES ('Developer'),('Founder'),('HR'),('manager'),('Team Leader'),('Employee')

 --T3
 INSERT INTO tblUsers (FirstName, LastName, FK_tblUsers_tblRoles,UQ_tbleUsers_Email,[Password],UQ_tblUsers_Phone,Photo,BirthDate,[Address],FK_tblUsers_tblCities,CreatedAt,IsActive)
 VALUES 
 ('Dhruv', 'Bhatt',3,'dhruv@bhatt.com','dhruv@123', 5678963260,'https://www.freepik.com/free-psd/3d-icon-social-media-app_36190320.htm#fromView=keyword&page=1&position=16&uuid=77d9e246-dcae-4143-a0b4-f1766816e770&query=Default+User','2001-10-25','char rasta',3,'2024-10-02',0)
 ,('vraj', 'tiwari',1,'vraj@tiwari.com','vraj@123', 5678963248,'https://www.freepik.com/free-psd/3d-icon-social-media-app_36190320.htm#fromView=keyword&page=1&position=16&uuid=77d9e246-dcae-4143-a0b4-f1766816e770&query=Default+User','1996-12-12','Shivaji Chok',1,'2025-01-01',1),
 ('vishva', 'Patel',1,'vishva@patel.com','vishva@123', 9632589632,'https://www.freepik.com/free-psd/3d-icon-social-media-app_36190320.htm#fromView=keyword&page=1&position=16&uuid=77d9e246-dcae-4143-a0b4-f1766816e770&query=Default+User','2002-06-06','near SBI Bank',2,'2024-02-02',1) 

 --T4:
 INSERT INTO tblGroups (UQ_tblGroups_Name,[Description],IsActive,CreatedAt,FK_tblGroups_tblUsers)
 VALUES
 ('Entertainment','Post related to fun activities.',1,'2016-02-20',2),
 ('Technical','Post related to various technology',1,'2012-01-05',3),
 ('Book Corner','Post related to Books',0,'2020-08-20',5),
 ('Art Hub','Post of Art',0,'2021-02-02',2)

 -- T5:
 INSERT INTO tblSubGroups (UQ_tblSubGroup_Name,FK_tblSubGroups_tblGroups,[Description],IsActive,CreatedAt,FK_tblSubGroups_tblUsers)
 VALUES 
 ('Animation',1,'Augemented Reality',1,'2024-01-02',2),
 ('Comics',1,'concerts',0,'2014-02-03',4),
 ('Social MEdia',1,'Sports Event',1,'2024-10-02',3),
 ('Software',2,'craze of AL/ML',1,'2013-01-01',2),
 ('PaintFusion',4,'Show casing varity of Pictures',0,'2022-10-25',5)

 --T6:
INSERT INTO tblGroupPosts (FK_tblGroupPosts_tblSubGroups,Title,Content,Image1,Image2,FK_tblGroupPosts_tblUsers,LikeCount,CreatedAt)
 VALUES 
 (1,'Doremon',Null,'C:Photos/img1','C:Photos/img2',8,4,'2024-08-05'),
 (4,'LNM',Null,'C:Photos/img4','C:Photos/img3',8,6,'2016-12-16'),
 (1,'oggy and the cockroaches',Null,'C:Photos/img5',Null,8,10,'2025-02-12')

 -- Q1: All the cities
 SELECT UQ_tblCities_Name FROM tblCities

 -- Q2:  All roles
 SELECT UQ_tblRoles_Name FROM tblRoles 

--Q3 :All Users
SELECT FirstName,LastName FROM tblUsers

--Q4: All Groups
SELECT UQ_tblGroups_Name FROM tblGroups

--Q5: “All” Users (First Name + Last Name, Role name, Email id, Phone number, Birth Date, City) – and users - role wise
 --SELECT FirstName + ' ' + LastName AS FullName ,(SELECT UQ_tblRoles_Name FROM tblRoles WHERE PK_tblRoles = FK_tblUsers_tblRoles)  as [Role],UQ_tblUsers_Email,UQ_tblUsers_Phone,BirthDate,(SELECT UQ_tblCities_Name  FROM tblCities WHERE PK_tblCities=FK_tblUsers_tblCities) AS City FROM tblUsers

 SELECT FirstName + ' ' + LastName AS FullName,r.UQ_tblRoles_Name, UQ_tbleUsers_Email,UQ_tblUsers_Phone,BirthDate,c.UQ_tblCities_Name FROM tblUsers u JOIN tblRoles r ON r.PK_tblRoles=u.FK_tblUsers_tblRoles JOIN tblCities c ON c.PK_tblCities=u.FK_tblUsers_tblCities order by r.UQ_tblRoles_Name

 --Q6: “All” Sub Groups – and Sub groups – group wise
 SELECT UQ_tblSubGroup_Name FROM tblSubGroups sub JOIN tblGroups grp ON sub.FK_tblSubGroups_tblGroups = grp.PK_tblGroups ORDER BY UQ_tblSubGroup_Name

 --Q7: Select Users whose birthdate is today
 SELECT * From tblUsers WHERE BirthDate = CAST(GETDATE() AS Date)

 --Q8: Select posts of last 2 days – latest on top
 SELECT * FROM tblGroupPosts WHERE CreatedAt = CAST(GETDATE()-2 AS Date) ORDER BY CreatedAt DESC

 --Q9: Select posts of particular active user (First name + Last Name, Role, Post Title, Reference, Likes count, Post creation date)
 select FirstName + ' ' + LastName AS FullName,r.UQ_tblRoles_Name,post.Title,u.FirstName,post.LikeCount,post.CreatedAt from tblUsers u join tblRoles r on r.PK_tblRoles=u.FK_tblUsers_tblRoles join tblGroupPosts post on post.FK_tblGroupPosts_tblUsers = u.PK_tblUsers WHERE u.IsActive = 1

 --Q10 10: Select posts of employee who had joined company first.

 ----update and delete
 SELECT * FROM tblCities
 UPDATE tblCities SET UQ_tblCities_Name = 'Ayodhya' WHERE PK_tblCities = 5
 UPDATE tblRoles SET UQ_tblRoles_Name = 'CEO' WHERE PK_tblRoles = 2
 SELECT * FROM tblUsers
 UPDATE tblUsers SET UQ_tblUsers_Phone = '9635215679',[Address]='Krishna Park' WHERE PK_tblUsers = 8
 SELECT * FROM tblGroups
 UPDATE tblGroups SET IsActive = 1 WHERE PK_tblGroups =3
 SELECT * FROM tblSubGroups
 UPDATE  tblSubGroups SET CreatedAt = '2023-02-02' 
 SELECT * FROM tblGroupPosts 
 UPDATE tblGroupPosts SET Content = 'funny cartoon' WHERE PK_tblGroupPosts = 2

 SELECT * FROM tblUsers
 DELETE FROM tblCities WHERE PK_tblCities = 3
 --TRUNCATE TABLE tblCities

 UPDATE tblUsers SET JoiningDate = GETDATE() WHERE PK_tblUsers = 9
