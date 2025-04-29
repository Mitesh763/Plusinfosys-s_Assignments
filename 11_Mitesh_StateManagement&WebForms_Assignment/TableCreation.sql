CREATE DATABASE VolunteerOverseas
go

use VolunteerOverseas

go

CREATE TABLE tblUsers (
	UserId INT IDENTITY(1,1),
	UserName NVARCHAR(100) NOT NULL,
	[Password] NVARCHAR(MAX) NOT NULL,
	CONSTRAINT PK_UserId PRIMARY KEY (UserId),
	CONSTRAINT UQ_tblUsers_UserName UNIQUE (UserName)
)

go

INSERT INTO tblUsers (UserName,[Password]) 
VALUES
('nikhil','123'),('nikunj','345')