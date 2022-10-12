insert into payment (amount,noOfInstallments,fundPercentage)
values(150,2,70)
insert into Installment (date,paymentId,amount,done)
values('2020-3-15',1,50,1);
insert into Installment (date,paymentId,amount,done)
values('2020-7-15',1,100,1);
insert into payment (amount,noOfInstallments,fundPercentage)
values(500,2,60)
insert into Installment (date,paymentId,amount,done)
values('2020-4-5',2,200,1);
insert into Installment (date,paymentId,amount,done)
values('2020-9-5',2,300,1);
insert into payment (amount,noOfInstallments,fundPercentage)
values(180,1,80)
insert into Installment (date,paymentId,amount,done)
values('2020-3-15',3,180,1);
insert into payment (amount,noOfInstallments,fundPercentage)
values(170,2,70)
insert into Installment (date,paymentId,amount,done)
values('2020-1-20',4,70,1);
insert into Installment (date,paymentId,amount,done)
values('2020-9-30',4,100,1);
insert into payment (amount,noOfInstallments,fundPercentage)
values(130,1,70)
insert into Installment (date,paymentId,amount,done)
values('2020-6-15',5,130,1);
insert into payment (amount,noOfInstallments,fundPercentage)
values(125,2,68)
insert into Installment (date,paymentId,amount,done)
values('2020-5-1',6,50,1);
insert into Installment (date,paymentId,amount,done)
values('2020-8-15',6,75,1);
insert into payment (amount,noOfInstallments,fundPercentage)
values(150,2,72)
insert into Installment (date,paymentId,amount,done)
values('2020-3-1',7,50,1);
insert into Installment (date,paymentId,amount,done)
values('2020-9-20',7,100,1);
insert into payment (amount,noOfInstallments,fundPercentage)
values(115,1,78)
insert into Installment (date,paymentId,amount,done)
values('2020-3-5',8,115,1);
insert into payment (amount,noOfInstallments,fundPercentage)
values(150,2,90)
insert into Installment (date,paymentId,amount,done)
values('2020-6-15',9,50,1);
insert into Installment (date,paymentId,amount,done)
values('2020-12-15',9,100,1);
insert into payment (amount,noOfInstallments,fundPercentage)
values(200,2,80)
insert into Installment (date,paymentId,amount,done)
values('2020-2-15',10,100,1);
insert into Installment (date,paymentId,amount,done)
values('2020-8-15',10,100,1);
insert into payment (amount,noOfInstallments,fundPercentage)
values(140,1,40)
insert into Installment (date,paymentId,amount,done)
values('2020-4-15',11,50,1);
insert into Installment (date,paymentId,amount,done)
values('2020-7-15',11,90,1);
insert into payment (amount,noOfInstallments,fundPercentage)
values(170,2,75)
insert into Installment (date,paymentId,amount,done)
values('2020-1-15',12,50,1);
insert into Installment (date,paymentId,amount,done)
values('2020-8-15',12,120,1);
insert into payment (amount,noOfInstallments,fundPercentage)
values(180,2,80)
insert into Installment (date,paymentId,amount,done)
values('2020-2-1',13,50,1);
insert into Installment (date,paymentId,amount,done)
values('2020-9-15',13,130,1);
insert into payment (amount,noOfInstallments,fundPercentage)
values(150,1,70)
insert into Installment (date,paymentId,amount,done)
values('2020-6-15',14,150,1);
insert into payment (amount,noOfInstallments,fundPercentage)
values(200,1,65)
insert into Installment (date,paymentId,amount,done)
values('2020-6-12',15,200,1);

SET IDENTITY_INSERT thesis ON;  

insert into Thesis (serialNumber, field, type, title, startDate, endDate, defenseDate, grade,payment_id,noOfExtensions)
values(1,'Engineering','PhD','Computational fluid dynamics investigation', '2018-6-1','2019-6-1','2019-7-1', 95,1,1);
insert into Thesis (serialNumber, field, type, title, startDate, endDate, defenseDate, grade,payment_id,noOfExtensions)
values(2,'Engineering','Master','Model validation for an agile UAV', '2017-7-15','2018-8-1','2018-8-15', 85,2,0);
insert into Thesis (serialNumber, field, type, title, startDate, endDate, defenseDate, grade,payment_id,noOfExtensions)
values(3,'Engineering','PhD','Wind tunnel investigation in oblique flow', '2018-6-1','2018-12-1','2019-1-1', 67,3,1);
insert into Thesis (serialNumber, field, type, title, startDate, endDate, defenseDate, grade,payment_id,noOfExtensions)
values(4,'Engineering','PhD','Wind tunnel investigation of propeller slipstream', '2018-6-1','2018-12-1','2019-1-1', 82,4,0);
insert into Thesis (serialNumber, field, type, title, startDate, endDate, defenseDate, grade,payment_id,noOfExtensions)
values(5,'Engineering','Master','Reconfigurable metamaterials for soft robotics', '2018-6-15','2019-2-15','2019-3-1', 70,5,0);
insert into Thesis (serialNumber, field, type, title, startDate, endDate, defenseDate, grade,payment_id,noOfExtensions)
values(6,'Engineering','PhD','State Estimation on Matrix Lie Groups', '2019-2-1','2019-8-1','2019-9-1', 73,6,0);
insert into Thesis (serialNumber, field, type, title, startDate, endDate, defenseDate, grade,payment_id,noOfExtensions)
values(7,'Engineering','PhD','Nonlinear vibrations of architected materials', '2020-1-1','2020-6-1','2020-7-1', 85,7,2);
insert into Thesis (serialNumber, field, type, title, startDate, endDate, defenseDate, grade,payment_id,noOfExtensions)
values(8,'Engineering','Master','Multi-robot collaborative state estimation', '2018-6-1','2019-6-1','2019-7-1', 79,8,1);
insert into Thesis (serialNumber, field, type, title, startDate, endDate, defenseDate, grade,payment_id,noOfExtensions)
values(9,'Engineering','PhD','Dynamics of photon-driven lightsails', '2018-7-1','2019-1-1','2019-1-15', 90,9,0);
insert into Thesis (serialNumber, field, type, title, startDate, endDate, defenseDate, grade,payment_id,noOfExtensions)
values(10,'Engineering','PhD','Dynamic soaring on a shock wave', '2018-3-1','2018-9-1','2018-10-1', 78,10,2);
insert into Thesis (serialNumber, field, type, title, startDate, endDate, defenseDate, grade,payment_id,noOfExtensions)
values(11,'Engineering','PhD','Impact of dust grain on lightsails', '2018-6-1','2019-6-1','2019-7-1', 68,11,0);
insert into Thesis (serialNumber, field, type, title, startDate, endDate, defenseDate, grade,payment_id,noOfExtensions)
values(12,'Engineering','Master','Pellet stream propulsion for interstellar flight', '2018-6-1','2019-6-1','2019-7-1', 93,12,0);
insert into Thesis (serialNumber, field, type, title, startDate, endDate, defenseDate, grade,payment_id,noOfExtensions)
values(13,'Engineering','Master','Device fabrication for the imaging of protein', '2019-6-1','2020-6-1','2020-7-1', 82,13,0);
insert into Thesis (serialNumber, field, type, title, startDate, endDate, defenseDate, grade,payment_id,noOfExtensions)
values(14,'Engineering','PhD','Sailing strategies for improved fuel efficiency', '2018-7-15','2019-6-1','2019-7-15', 89,14,1);
insert into Thesis (serialNumber, field, type, title, startDate, endDate, defenseDate, grade,payment_id,noOfExtensions)
values(15,'Engineering','PhD','The use of warm mix asphalt in road construction', '2018-6-1','2019-6-1','2019-7-1', 95,15,1);

insert into PostGradUser (email,password) 
values('one@gmail.com','12345678')
insert into PostGradUser (email,password) 
values('two@gmail.com','11345678')
insert into PostGradUser (email,password) 
values('ahmedahmed@gmail.com','12245678')
insert into PostGradUser (email,password) 
values('mahmoudmahmoud@gmail.com','12335678')
insert into PostGradUser (email,password) 
values('mostafamostafa@gmail.com','12344678')
insert into PostGradUser (email,password) 
values('alialli@gmail.com','12346678')
insert into PostGradUser (email,password) 
values('sarasara@gmail.com','12345778')
insert into PostGradUser (email,password) 
values('engyengy@gmail.com','12345178')
insert into PostGradUser (email,password) 
values('magedmaged@gmail.com','12345278')
insert into PostGradUser (email,password) 
values('karimkarima@gmail.com','12345478')
insert into PostGradUser (email,password) 
values('ayaaya@gmail.com','12345378')
insert into PostGradUser (email,password) 
values('monamona@gmail.com','12345978')
insert into PostGradUser (email,password) 
values('momo@gmail.com','19345678')
insert into PostGradUser (email,password) 
values('hanyhany@gmail.com','19345678')
insert into PostGradUser (email,password) 
values('slimslim@gmail.com','19745678')
insert into PostGradUser (email,password) 
values('nadanada@gmail.com','19645678')

insert into Admin (id) values(1);
insert into Admin (id) values(2);
insert into Supervisor (id,name,faculty) values(3,'Ahmed','eng')
insert into Supervisor (id,name,faculty) values(4,'Mahmoud','eng')
insert into Supervisor (id,name,faculty) values(5,'Mostafa','eng')
insert into GucianStudent( id,firstName, lastName, type, faculty, address, GPA, undergradID)
values (6,'ali','fathy','mal','eng','elrehab',1.2,49112)
insert into GucianStudent( id,firstName, lastName, type, faculty, address, GPA, undergradID)
values (7,'sara','omar','fem','eng','elmaady',1.9,49614)
insert into GucianStudent( id,firstName, lastName, type, faculty, address, GPA, undergradID)
values (8,'engy','fekry','fem','eng','eltahrir',2.1,49531)
insert into GucianStudent( id,firstName, lastName, type, faculty, address, GPA, undergradID)
values (9,'maged','saber','mal','eng','elrehab',0.7,49012)
insert into GucianStudent( id,firstName, lastName, type, faculty, address, GPA, undergradID)
values (10,'karim','fawzy','mal','eng','nasr_city',2.3,49342)

insert into NonGucianStudent( id,firstName, lastName, type,faculty,address,GPA )
values (11,'aya','fawzy','fem','eng','madnity',2)
insert into NonGucianStudent( id,firstName, lastName, type,faculty,address,GPA )
values (12,'mona','ayman','fem','eng','6-oktober',2.1)
insert into NonGucianStudent( id,firstName, lastName, type,faculty,address,GPA )
values (13,'mo','salah','mal','eng','eltahrir',2.3)
select * from PostGradUser

insert into course (fees,creditHours, code)
values(5000,4,'501')
insert into course (fees,creditHours, code)
values(3000,2,'503')
insert into course (fees,creditHours, code)
values(4000,3,'602')
insert into course (fees,creditHours, code)
values(5500,5,'701')
insert into course (fees,creditHours, code)
values(6000,6,'502')
insert into NonGucianStudentTakeCourse (sid,cid ,grade)
values(11,1,73)
insert into NonGucianStudentTakeCourse (sid,cid ,grade)
values(11,2,72)
insert into NonGucianStudentTakeCourse (sid,cid ,grade)
values(12,3,85)
insert into NonGucianStudentTakeCourse (sid,cid ,grade)
values(12,4,40)
insert into NonGucianStudentTakeCourse (sid,cid ,grade)
values(13,5,20) 

insert into Examiner (id, name, fieldOfWork, isNational)
values(14,'Hany','Engineering',1)
insert into Examiner (id, name, fieldOfWork, isNational)
values(15,'slim','Engineering',1)
insert into Examiner (id, name, fieldOfWork, isNational)
values(16,'Nada','Engineering',1)

insert into GUCianProgressReport (no,sid ,date,eval,thesisSerialNumber,supid)
values(1,10,'2020-6-15',2,1,4)
insert into GUCianProgressReport (no,sid ,date,eval,thesisSerialNumber,supid)
values(2,9,'2020-8-5',3,2,3)
insert into GUCianProgressReport (no,sid ,date,eval,thesisSerialNumber,supid)
values(3,8,'2020-3-2',1,3,5)
insert into GUCianProgressReport (no,sid ,date,eval,thesisSerialNumber,supid)
values(4,7,'2020-5-1',2,4,3)
insert into GUCianProgressReport (no,sid ,date,eval,thesisSerialNumber,supid)
values(5,6,'2020-9-15',3,5,4)

insert into GUCianProgressReport (no,sid ,date,eval,thesisSerialNumber,supid)
values (6,11,'2020-3-9',3,6,5)
insert into GUCianProgressReport (no,sid ,date,eval,thesisSerialNumber,supid)
values (7,12,'2020-8-9',3,7,3)
insert into GUCianProgressReport (no,sid ,date,eval,thesisSerialNumber,supid)
values (8,13,'2020-7-9',2,8,4)


insert into Defense (serialNumber, date, location, grade)
values (1, '2019-7-1' , 'C3.102' , 80 )
insert into Defense (serialNumber, date, location, grade)
values (2, '2018-8-15' , 'C2.302' , 70 )
insert into Defense (serialNumber, date, location, grade)
values (3, '2019-1-1' , 'B4.302' , 85 )
insert into Defense (serialNumber, date, location, grade)
values (4, '2019-3-1' , 'D2.201' , 90 )
insert into Defense (serialNumber, date, location, grade)
values (5, '2019-9-1' , 'C2.101' , 20 )
insert into Defense (serialNumber, date, location, grade)
values (6, '2020-7-1' , 'C3.303' , 30 )
insert into Defense (serialNumber, date, location, grade)
values (7, '2019-1-15' , 'D2,101' , 80 )
insert into Defense (serialNumber, date, location, grade)
values (8, '2018-10-1' , 'C5.201' , 84 )
insert into Defense (serialNumber, date, location, grade)
values (9, '2019-7-1' , 'B1.103' , 42 )
insert into Defense (serialNumber, date, location, grade)
values (10, '2019-6-1' , 'C1.111' , 70 )
insert into Defense (serialNumber, date, location, grade)
values (11, '2020-6-1' , 'B4.301' , 40 )
insert into Defense (serialNumber, date, location, grade)
values (12, '2019-6-1' , 'C5.201' , 35 )
insert into Defense (serialNumber, date, location, grade)
values (13, '2019-6-1' , 'B4.203' , 75 )
insert into Defense (serialNumber, date, location, grade)
values (14, '2019-8-1' , 'D4.302' , 50 )
insert into Defense (serialNumber, date, location, grade)
values (15, '2019-6-1' , 'B3.112' , 40 )


insert into ExaminerEvaluateDefense(date,serialNo,examinerId,comment)
values('2019-8-1',14,15,'good');
insert into ExaminerEvaluateDefense(date,serialNo,examinerId,comment)
values('2019-6-1',10,16,' very good');
insert into ExaminerEvaluateDefense(date,serialNo,examinerId,comment)
values('2019-6-1',15,14,'good');
insert into ExaminerEvaluateDefense(date,serialNo,examinerId,comment)
values('2019-1-1',3,15,'good');
insert into ExaminerEvaluateDefense(date,serialNo,examinerId,comment)
values('2019-3-1',4,16,' very good');
insert into ExaminerEvaluateDefense(date,serialNo,examinerId,comment)
values('2019-9-1',5,14,'good');

select * from GUCianStudentRegisterThesis 

insert into GUCianStudentRegisterThesis(sid,supid,serial_no)values(6,3,1)
insert into GUCianStudentRegisterThesis(sid,supid,serial_no)values(8,3,3)
insert into GUCianStudentRegisterThesis(sid,supid,serial_no)values(9,5,4)
insert into GUCianStudentRegisterThesis(sid,supid,serial_no)values(7,4,8)
insert into NonGUCianStudentRegisterThesis(sid,supid,serial_no)values(11,4,8)
insert into NonGUCianStudentRegisterThesis(sid,supid,serial_no)values(12,5,10)
insert into NonGUCianStudentRegisterThesis(sid,supid,serial_no)values(13,3,13)


insert into publication(title,dateOfPublication,place,accepted,host)
values ('abc','2017-11-3','kkk','1','gfgfg')
insert into publication(title,dateOfPublication,place,accepted,host)
values ('abc','2017-11-3','kkk','0','gfgfg') 

insert into ThesisHasPublication(serialNo,pubid) values(4,2)
insert into ThesisHasPublication(serialNo,pubid) values(8,2)
insert into ThesisHasPublication(serialNo,pubid) values(6,1)
insert into ThesisHasPublication(serialNo,pubid) values(7,1)


insert into NonGucianStudentPayForCourse(sid,paymentNo,cid)
values(11,11,2),
(12,12,1),
(13,13,1)

insert into GUCianStudentRegisterThesis (sid,supid,serial_no)
values
(7,4,7),
(7,5,3),
(8,5,4),
(9,3,1)


insert into NonGUCianStudentRegisterThesis (sid,supid,serial_no)
values(11,3,9),
(12,4,14),
(11,5,10),
(13,3,11)
select * from Thesis

select * from Supervisor
select * from Publication
select * from NonGucianStudent
 
select * from NonGUCianStudentRegisterThesis
select * from ThesisHasPublication
exec ViewAStudentPublications 13