------ INSERTION 

 --T1:
 EXEC sp_tblCitiesInsert 'Ahmedabad'
 EXEC sp_tblCitiesInsert 'Surat'
 EXEC sp_tblCitiesInsert 'Mumbai'
 EXEC sp_tblCitiesInsert 'Pune'
 EXEC sp_tblCitiesInsert 'Delhi'
 
 EXEC sp_Select_Anytable 'tblCities'
 go
 
 --T2:
 EXEC sp_tblRolesInsert 'Founder'
 EXEC sp_tblRolesInsert 'Team Leader'
 EXEC sp_tblRolesInsert 'Developer'
 EXEC sp_tblRolesInsert 'HR'
 EXEC sp_tblRolesInsert 'Employee'
 EXEC sp_tblRolesInsert 'Tester'
 
 EXEC sp_Select_Anytable 'tblRoles'
 go

 --T3
 EXEC sp_tblUsersInsert 'Kalpesh', 'Vekariya',1,'kalpeshV@gmail.com','kalpesh@123', 5678963260,'https://www.freepik.com/free-psd/3d-icon-social-media-app_36190320.htm#fromView=keyword&page=1&position=16&uuid=77d9e246-dcae-4143-a0b4-f1766816e770&query=Default+User','2003-02-20 13:45:52.553','Pavan Villa',3,'2024-10-02 01:45:52.553',1  SELECT GETDATE()
 EXEC sp_tblUsersInsert 'Jay', 'Dave',3,'jayD@gmail.com','jay@123', 5678963248,'https://www.freepik.com/free-psd/3d-icon-social-media-app_36190320.htm#fromView=keyword&page=1&position=16&uuid=77d9e246-dcae-4143-a0b4-f1766816e770&query=Default+User','1996-12-12 12:15:52.553','Shivaji Chok',1,'2025-01-01 11:20:52.553',1
 EXEC sp_tblUsersInsert 'Mamta', 'Patel',6,'mamtaP@gmail.com','mamta@123', 5678658964,'https://www.freepik.com/free-psd/3d-icon-social-media-app_36190320.htm#fromView=keyword&page=1&position=16&uuid=77d9e246-dcae-4143-a0b4-f1766816e770&query=Default+User','2004-05-02 19:28:56.452','Near Court',1,'2024-10-01 13:45:52.553',0
 EXEC sp_tblUsersInsert 'Reema', 'Prajapati',4,'reemaP@gmail.com','reema@123', 9654896328,'https://www.freepik.com/free-psd/3d-icon-social-media-app_36190320.htm#fromView=keyword&page=1&position=16&uuid=77d9e246-dcae-4143-a0b4-f1766816e770&query=Default+User','2003-05-02 18:25:12.553','Shyam City',1,'2022-05-23 02:34:12.053',1
 
 EXEC sp_Select_Anytable 'tblUsers'
 go

 --T4:
 EXEC sp_tblGroupsInsert 'Entertainment','Post related to fun activities.',1,'2016-02-20 13:45:52.553',4
 EXEC sp_tblGroupsInsert 'Technical','Post related to various technology',1,'2012-01-05 09:47:52.251',1
 EXEC sp_tblGroupsInsert 'Book Corner','Post related to Books',0,'2020-08-20 07:25:09.123',3
 EXEC sp_tblGroupsInsert 'Art Hub','Post of Art',0,'2021-02-02 12:12:32.153',4
 
 EXEC sp_Select_Anytable 'tblGroups'
 go

 -- T5:
 EXEC sp_tblSubGroupsInsert 'Animation',1,'Augemented Reality',1,'2024-01-02 16:34:46.251',1
 EXEC sp_tblSubGroupsInsert 'Comics',1,'concerts',0,'2014-02-03 13:45:52.553',3
 EXEC sp_tblSubGroupsInsert 'Social MEdia',1,'Sports Event',1,'2024-10-02 02:55:55.555',2
 EXEC sp_tblSubGroupsInsert 'Software',2,'craze of AL/ML',1,'2013-01-01 10:45:52.550',1
 EXEC sp_tblSubGroupsInsert 'PaintFusion',4,'Show casing varity of Pictures',0,'2022-10-25 23:15:12.235',3
 
 EXEC sp_Select_Anytable 'tblSubGroups'
 go

 --T6:
 EXEC sp_tblGroupPostInsert 1,'Doremon',Null,'C:Photos/img1','C:Photos/img2',3,4,'2024-08-05 01:10:26.156'
 EXEC sp_tblGroupPostInsert 4,'LNM','LNM stands for Large Language Model','C:Photos/img4','C:Photos/img3',2,8,'2016-12-16 13:45:52.553'
 EXEC sp_tblGroupPostInsert 1,'oggy and the cockroaches',Null,'C:Photos/img5',Null,3,15,'2025-02-12 11:15:12.253'
 EXEC sp_tblGroupPostInsert 2,'The Huntress','Interesting comics.','C:Photos/img7',Null,4,37,'2025-02-02 03:22:03.153'
 
 EXEC sp_Select_Anytable 'tblGroupPosts'