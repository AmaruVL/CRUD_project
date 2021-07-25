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
insert into Docente values('Abdon','Rivas','Puga','Nombrado','Pincipal','Tiempo Completo','IN')
insert into Docente values('Ana Rocio','Cardenas','Maita','Contratado','Tipo B','B1','IN')
insert into Docente values('Dennis Ivan','Candia','Oviedo','Nombrado','Asociado','Tiempo Completo','IN')
insert into Docente values('Doris Sabina','Aguirre','Carbajal','Contratado','Tipo B','B3','IN')
insert into Docente values('Edwin','Carrasco','Poblete','Nombrado','Pincipal','Tiempo Completo','IN')
insert into Docente values('Efrina Gladys','Cutipa','Arapa','Contratado','Tipo B','B1','IN')
insert into Docente values('Emilio','Palomino','Olivera','Nombrado','Pincipal','Tiempo Completo','IN')
insert into Docente values('Enrique','Gamarra','Saldivar','Nombrado','Pincipal','Tiempo Completo','IN')
insert into Docente values('Esther Cristina','Pacheco','Vasquez','Nombrado','Auxiliar','Tiempo Completo','IN')
insert into Docente values('Guzman','Ticona','Pari','Nombrado','Asociado','Dedicacion Exclusiva','IN')
insert into Docente values('Harley','Vera','Olivera','Contratado','Tipo B','B1','IN')
insert into Docente values('Henry Samuel','Dueñas','De la Cruz','Contratado','Tipo B','B2','IN')
insert into Docente values('Hernan','Castañeda','Chirinos','Contratado','Tipo B','B2','IN')
insert into Docente values('Hernan','Nina','Hanco','Contratado','Tipo A','A1','IN')
insert into Docente values('Ivan Cesar','Medrano','Valencia','Nombrado','Asociado','Tiempo Completo','IN')
insert into Docente values('Javier Arturo','Rozas','Huacho','Nombrado','Principal','Dedicacion Exclusiva','IN')
insert into Docente values('Javier David','Chavez','Centeno','Nombrado','Auxiliar','Tiempo Completo','IN')
insert into Docente values('Jose Mauro','Pillco','Quispe','Nombrado','Auxiliar','Tiempo Completo','IN')
insert into Docente values('Julio Cesar','Carbajal','Luna','Nombrado','Principal','Tiempo Completo','IN')
insert into Docente values('Karelia','Medina','Miranda','Nombrado','Asociado','Tiempo Parcial','IN')
insert into Docente values('Lauro','Enciso','Rodas','Nombrado','Principal','Dedicacion Exclusiva','IN')
insert into Docente values('Lino Aquiles','Baca','Cardenas','Nombrado','Auxiliar','Tiempo Completo','IN')
insert into Docente values('Lino Prisciliano','Flores','Pacheco','Nombrado','Principal','Tiempo Completo','IN')
insert into Docente values('Luis Alvaro','Monzon','Condori','Contratado','Tipo B','B3','IN')
insert into Docente values('Luis Beltran','Palma','Ttito','Nombrado','Asociado','Tiempo Completo','IN')
insert into Docente values('Manuel Aurelio','Peñaloza','Figueroa','Nombrado','Asociado','Tiempo Parcial','IN')
insert into Docente values('Maritza Katherine','Irpanocca','Cusimayta','Contratado','Tipo B','B1','IN')
insert into Docente values('Nila Zonia','Acurio','Usca','Nombrado','Principal','Dedicacion Exclusiva','IN')
insert into Docente values('Robert Wilbert','Alzamora','Paredes','Nombrado','Asociado','Tiempo Completo','IN')
insert into Docente values('Rony','Villafuerte','Serna','Nombrado','Asociado','Tiempo Completo','IN')
insert into Docente values('Vanesa Maribel','Choque','Soto','Contratado','Tipo B','B2','IN')
insert into Docente values('Waldo Elio','Ibarra','Zambrano','Nombrado','Auxiliar','Tiempo Completo','IN')
insert into Docente values('Waldo','Villa','Rodriguez','Contratado','Tipo B','B1','IN')
insert into Docente values('Willian','Zamalloa','Paro','Contratado','Tipo B','B1','IN')
insert into Docente values('Yeshica Isela','Ormeño','Ayala','Nombrado','Asociado','Dedicacion Exclusiva','IN')