------ INSERTION 

 --T1:
 EXEC sp_Insert_tblCities 'Ahmedabad'
 EXEC sp_Insert_tblCities 'Surat'
 EXEC sp_Insert_tblCities 'Mumbai'
 EXEC sp_Insert_tblCities 'Pune'
 EXEC sp_Insert_tblCities 'Delhi'
 
 EXEC sp_Select_Anytable 'tblCities'
 go
 
 --T2:
 EXEC sp_Insert_tblRoles 'Founder'
 EXEC sp_Insert_tblRoles 'Team Leader'
 EXEC sp_Insert_tblRoles 'Developer'
 EXEC sp_Insert_tblRoles 'HR'
 EXEC sp_Insert_tblRoles 'Employee'
 EXEC sp_Insert_tblRoles 'Tester'
 
 EXEC sp_Select_Anytable 'tblRoles'
 go

 --T3
 EXEC sp_Insert_tblUsers 'Kalpesh', 'Vekariya',1,'kalpeshV@gmail.com','kalpesh@123', 5678963260,'https://www.freepik.com/free-psd/3d-icon-social-media-app_36190320.htm#fromView=keyword&page=1&position=16&uuid=77d9e246-dcae-4143-a0b4-f1766816e770&query=Default+User','2001-10-25','Pavan Villa',3,'2024-10-02',1
 EXEC sp_Insert_tblUsers 'Jay', 'Dave',3,'jayD@gmail.com','jay@123', 5678963248,'https://www.freepik.com/free-psd/3d-icon-social-media-app_36190320.htm#fromView=keyword&page=1&position=16&uuid=77d9e246-dcae-4143-a0b4-f1766816e770&query=Default+User','1996-12-12','Shivaji Chok',1,'2025-01-01',1
 EXEC sp_Insert_tblUsers 'Mamta', 'Patel',6,'mamtaP@gmail.com','mamta@123', 5678658964,'https://www.freepik.com/free-psd/3d-icon-social-media-app_36190320.htm#fromView=keyword&page=1&position=16&uuid=77d9e246-dcae-4143-a0b4-f1766816e770&query=Default+User','2004-05-02','Near Court',1,'2024-10-01',0
 EXEC sp_Insert_tblUsers 'Reema', 'Prajapati',4,'reemaP@gmail.com','reema@123', 9654896328,'https://www.freepik.com/free-psd/3d-icon-social-media-app_36190320.htm#fromView=keyword&page=1&position=16&uuid=77d9e246-dcae-4143-a0b4-f1766816e770&query=Default+User','2003-05-02','Shyam City',1,'2022-05-23',1
 
 EXEC sp_Select_Anytable 'tblUsers'
 go

 --T4:
 EXEC sp_Insert_tblGroups 'Entertainment','Post related to fun activities.',1,'2016-02-20',4
 EXEC sp_Insert_tblGroups 'Technical','Post related to various technology',1,'2012-01-05',1
 EXEC sp_Insert_tblGroups 'Book Corner','Post related to Books',0,'2020-08-20',3
 EXEC sp_Insert_tblGroups 'Art Hub','Post of Art',0,'2021-02-02',3
 
 EXEC sp_Select_Anytable 'tblGroups'
 go

 -- T5:
 EXEC sp_Insert_tblSubGroups 'Animation',1,'Augemented Reality',1,'2024-01-02',1
 EXEC sp_Insert_tblSubGroups 'Comics',1,'concerts',0,'2014-02-03',3
 EXEC sp_Insert_tblSubGroups 'Social MEdia',1,'Sports Event',1,'2024-10-02',2
 EXEC sp_Insert_tblSubGroups 'Software',2,'craze of AL/ML',1,'2013-01-01',1
 EXEC sp_Insert_tblSubGroups 'PaintFusion',4,'Show casing varity of Pictures',0,'2022-10-25',3
 
 EXEC sp_Select_Anytable 'tblSubGroups'
 go

 --T6:
 EXEC sp_Insert_tblGroupPosts 1,'Doremon',Null,'C:Photos/img1','C:Photos/img2',3,4,'2024-08-05'
 EXEC sp_Insert_tblGroupPosts 4,'LNM','LNM stands for Large Language Model','C:Photos/img4','C:Photos/img3',2,8,'2016-12-16'
 EXEC sp_Insert_tblGroupPosts 1,'oggy and the cockroaches',Null,'C:Photos/img5',Null,3,15,'2025-02-12'
 
 EXEC sp_Select_Anytable 'tblGroupPosts'