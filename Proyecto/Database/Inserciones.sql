USE BDTutoria
GO

/*ELIMINAR ELEMENTOS DE TODAS LAS TABLAS*/
--Desactivar limitaciones de todas las tablas
EXEC sys.sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL' 

--Eliminar elementos de todas las tablas
EXEC sys.sp_msforeachtable 'DELETE FROM ?'

--Activar limitaciones de todas las tablas
EXEC sys.sp_MSForEachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL'
go


--INSERCION ESTUDIANTES
insert into Estudiante values('182456','Norma','Jimenez','Padilla','IN','Normal')
insert into Estudiante values('145678','Marcelo','Lopez', 'Ortega','ME','En riesgo')
insert into Estudiante values('134521','Carlos' ,'Quispe',' Puma','IN','En riesgo')
insert into Estudiante values('176542','Sara'   ,'Ezquvel', 'Hernanadez','CO','Normal')
insert into Estudiante values('189023','Rosalia','Sanchez','Flores','IQ','Normal')
insert into Estudiante values('196541','Mabel'  ,'Huaman','Huarca','IPQ','En riesgo')
insert into Estudiante values('187691','Juan'   ,'Mamani',' Quispe','ME','En riesgo')
insert into Estudiante values('184567','Pedro','Perez','Sarmiento','ME','Normal')
insert into Estudiante values('174512','Vanesa','Gutierrez','Choque','IN','En riesgo')
insert into Estudiante values('167734','Laura','Vilchez','Vilchez','IN','Normal')
insert into Estudiante values('202879','Efrain','Uribe','Quiroz','IN','En riesgo')
insert into Estudiante values('202478','Demian','Olimpo','Gallardo','IN','En riesgo')
insert into Estudiante values('183456','Angie','Garcia','Correa','IN','Normal')
insert into Estudiante values('161657','Armando','Casas','Delgado','ME','Normal')
insert into Estudiante values('144545','Rosmira','Benavidez','Ordoñez','ME','En riesgo')
insert into Estudiante values('155577','Marshal','Escalante','Luna','IN','Normal')
insert into Estudiante values('188976','Joel','Salcedo','Pinarez','IQ','En riesgo')

--INSERCION DOCENTES
insert into Docente values('10000','Abdon','Rivas','Puga','Nombrado','Principal','Tiempo Completo','IN')
insert into Docente values('10001','Ana Rocio','Cardenas','Maita','Contratado','Tipo B','B1','IN')
insert into Docente values('10002','Dennis Ivan','Candia','Oviedo','Nombrado','Asociado','Tiempo Completo','IN')
insert into Docente values('10003','Doris Sabina','Aguirre','Carbajal','Contratado','Tipo B','B3','IN')
insert into Docente values('10004','Edwin','Carrasco','Poblete','Nombrado','Principal','Tiempo Completo','IN')
insert into Docente values('10005','Efrina Gladys','Cutipa','Arapa','Contratado','Tipo B','B1','IN')
insert into Docente values('10006','Emilio','Palomino','Olivera','Nombrado','Principal','Tiempo Completo','IN')
insert into Docente values('10007','Enrique','Gamarra','Saldivar','Nombrado','Principal','Tiempo Completo','IN')
insert into Docente values('10008','Esther Cristina','Pacheco','Vasquez','Nombrado','Auxiliar','Tiempo Completo','IN')
insert into Docente values('10009','Guzman','Ticona','Pari','Nombrado','Asociado','Dedicacion Exclusiva','IN')
insert into Docente values('10010','Harley','Vera','Olivera','Contratado','Tipo B','B1','IN')
insert into Docente values('10011','Henry Samuel','Dueñas','De la Cruz','Contratado','Tipo B','B2','IN')
insert into Docente values('10012','Hernan','Castañeda','Chirinos','Contratado','Tipo B','B2','IN')
insert into Docente values('10013','Hernan','Nina','Hanco','Contratado','Tipo A','A1','IN')
insert into Docente values('10014','Ivan Cesar','Medrano','Valencia','Nombrado','Asociado','Tiempo Completo','IN')
insert into Docente values('10015','Javier Arturo','Rozas','Huacho','Nombrado','Principal','Dedicacion Exclusiva','IN')
insert into Docente values('10016','Javier David','Chavez','Centeno','Nombrado','Auxiliar','Tiempo Completo','IN')
insert into Docente values('10017','Jose Mauro','Pillco','Quispe','Nombrado','Auxiliar','Tiempo Completo','IN')
insert into Docente values('10018','Julio Cesar','Carbajal','Luna','Nombrado','Principal','Tiempo Completo','IN')
insert into Docente values('10019','Karelia','Medina','Miranda','Nombrado','Asociado','Tiempo Parcial','IN')
insert into Docente values('10020','Lauro','Enciso','Rodas','Nombrado','Principal','Dedicacion Exclusiva','IN')
insert into Docente values('10021','Lino Aquiles','Baca','Cardenas','Nombrado','Auxiliar','Tiempo Completo','IN')
insert into Docente values('10022','Lino Prisciliano','Flores','Pacheco','Nombrado','Principal','Tiempo Completo','IN')
insert into Docente values('10023','Luis Alvaro','Monzon','Condori','Contratado','Tipo B','B3','IN')
insert into Docente values('10024','Luis Beltran','Palma','Ttito','Nombrado','Asociado','Tiempo Completo','IN')
insert into Docente values('10025','Manuel Aurelio','Peñaloza','Figueroa','Nombrado','Asociado','Tiempo Parcial','IN')
insert into Docente values('10026','Maritza Katherine','Irpanocca','Cusimayta','Contratado','Tipo B','B1','IN')
insert into Docente values('10027','Nila Zonia','Acurio','Usca','Nombrado','Principal','Dedicacion Exclusiva','IN')
insert into Docente values('10028','Robert Wilbert','Alzamora','Paredes','Nombrado','Asociado','Tiempo Completo','IN')
insert into Docente values('10029','Rony','Villafuerte','Serna','Nombrado','Asociado','Tiempo Completo','IN')
insert into Docente values('10030','Vanesa Maribel','Choque','Soto','Contratado','Tipo B','B2','IN')
insert into Docente values('10031','Waldo Elio','Ibarra','Zambrano','Nombrado','Auxiliar','Tiempo Completo','IN')
insert into Docente values('10032','Waldo','Villa','Rodriguez','Contratado','Tipo B','B1','IN')
insert into Docente values('10033','Willian','Zamalloa','Paro','Contratado','Tipo B','B1','IN')
insert into Docente values('10034','Yeshica Isela','Ormeño','Ayala','Nombrado','Asociado','Dedicacion Exclusiva','IN')

--INSERCION USUARIO
--pass: 1234
insert into Usuario values('10000','81dc9bdb52d04dc20036dbd8313ed055');