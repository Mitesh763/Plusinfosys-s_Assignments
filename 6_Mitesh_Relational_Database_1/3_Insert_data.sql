use PostDoc------ INSERTION 

 --T1:
 INSERT INTO tblCities (CityName) 
 VALUES ('Ahmedabad'),('Surat'),('Mumbai'),('Pune'),('Delhi')
 SELECT * FROM tblCities

 go
 --T2:
 INSERT INTO tblRoles (RoleName)
 VALUES ('Developer'),('Founder'),('HR'),('manager'),('Team Leader'),('Employee')
 SELECT * FROM tblRoles

 go
 --T3
 INSERT INTO tblUsers (FirstName, LastName, [Role],EmailId,[Password],PhoneNumber,Photo,BirthDate,[Address],City,CreatedAt,IsActive)
 VALUES 
 ('Dhruv', 'Bhatt',3,'dhruv@bhatt.com','dhruv@123', 5678963260,'https://www.freepik.com/free-psd/3d-icon-social-media-app_36190320.htm#fromView=keyword&page=1&position=16&uuid=77d9e246-dcae-4143-a0b4-f1766816e770&query=Default+User','2001-10-25','char rasta',3,'2024-10-02',0)
 ,('vraj', 'tiwari',1,'vraj@tiwari.com','vraj@123', 5678963248,'https://www.freepik.com/free-psd/3d-icon-social-media-app_36190320.htm#fromView=keyword&page=1&position=16&uuid=77d9e246-dcae-4143-a0b4-f1766816e770&query=Default+User','1996-12-12','Shivaji Chok',1,'2025-01-01',1),
 ('vishva', 'Patel',1,'vishva@patel.com','vishva@123', 9632589632,'https://www.freepik.com/free-psd/3d-icon-social-media-app_36190320.htm#fromView=keyword&page=1&position=16&uuid=77d9e246-dcae-4143-a0b4-f1766816e770&query=Default+User','2002-06-06','near SBI Bank',2,'2024-02-02',1) 
 SELECT * FROM tblUsers

 go
 --T4:
 INSERT INTO tblGroups (GroupName,[Description],IsActive,CreatedAt,CreatedBy)
 VALUES
 ('Entertainment','Post related to fun activities.',1,'2016-02-20',1),
 ('Technical','Post related to various technology',1,'2012-01-05',2),
 ('Book Corner','Post related to Books',0,'2020-08-20',3),
 ('Art Hub','Post of Art',0,'2021-02-02',1)
 SELECT * FROM tblGroups

 go
 -- T5:
 INSERT INTO tblSubGroups (SubGroupName,[Group],[Description],IsActive,CreatedAt,CreatedBy)
 VALUES 
 ('Animation',1,'Augemented Reality',1,'2024-01-02',1),
 ('Comics',1,'concerts',0,'2014-02-03',3),
 ('Social MEdia',1,'Sports Event',1,'2024-10-02',2),
 ('Software',2,'craze of AL/ML',1,'2013-01-01',1),
 ('PaintFusion',4,'Show casing varity of Pictures',0,'2022-10-25',3)
 SELECT * FROM tblSubGroups

 go
 --T6:
INSERT INTO tblGroupPosts (PostedBy,Title,Content,Image1,Image2,Reference,LikeCount,CreatedAt)
 VALUES 
 (1,'Doremon',Null,'C:Photos/img1','C:Photos/img2',3,4,'2024-08-05'),
 (4,'LNM',Null,'C:Photos/img4','C:Photos/img3',2,8,'2016-12-16'),
 (1,'oggy and the cockroaches',Null,'C:Photos/img5',Null,3,10,'2025-02-12')

 SELECT * FROM tblGroupPosts