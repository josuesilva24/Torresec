
/*INSERT DEPARTAMENTOS*/
	INSERT INTO Departamento (Departamento)  VALUES	('GERENCIA GENERAL')
	INSERT INTO Departamento (Departamento)  VALUES	('ADQUISICION Y PERMISOS')
	INSERT INTO Departamento (Departamento)  VALUES	('CONSTRUCCION')
	INSERT INTO Departamento (Departamento)  VALUES	('LEGAL')
	INSERT INTO Departamento (Departamento)  VALUES	('FINANZAS')
/*INSERT DEPARTAMENTOS*/
-----------------------------------------------------------------------
-----------------------------------------------------------------------
/*INSERT VISTAS*/
	INSERT INTO Vistas (Vista) VALUES ('ANILLO')
	INSERT INTO Vistas (Vista) VALUES ('ALTERNATIVA')
	INSERT INTO Vistas (Vista) VALUES ('PERMISOS')
	INSERT INTO Vistas (Vista) VALUES ('ENERGIA')
	INSERT INTO Vistas (Vista) VALUES ('SITIOS')
	INSERT INTO Vistas (Vista) VALUES ('COLLO')
/*INSERT VISTAS*/
-----------------------------------------------------------------------
-----------------------------------------------------------------------
/*INSERT USUARIOS*/
	INSERT INTO Usuario (Nombre ,Nombre_Usuario ,Apellidos ,Contrasena ,Id_Departamento)
	VALUES('Pedro' ,'Pedro_Guzman' ,'Guzman','abc123',(SELECT d.Id_Departamento FROM Departamento d WHERE d.Departamento = 'GERENCIA GENERAL'))

	INSERT INTO Usuario (Nombre ,Nombre_Usuario ,Apellidos ,Contrasena ,Id_Departamento)
	VALUES('Rommel' ,'Rommel_Duran' ,'Duran','abc123',(SELECT d.Id_Departamento FROM Departamento d WHERE d.Departamento = 'ADQUISICION Y PERMISOS'))

	INSERT INTO Usuario (Nombre ,Nombre_Usuario ,Apellidos ,Contrasena ,Id_Departamento)
	VALUES('Angela' ,'Angela_Paucar' ,'Paucar','abc123',(SELECT d.Id_Departamento FROM Departamento d WHERE d.Departamento = 'ADQUISICION Y PERMISOS'))

	INSERT INTO Usuario (Nombre ,Nombre_Usuario ,Apellidos ,Contrasena ,Id_Departamento)
	VALUES('Lupe' ,'Lupe_Merino' ,'Merino','abc123',(SELECT d.Id_Departamento FROM Departamento d WHERE d.Departamento = 'ADQUISICION Y PERMISOS'))

	INSERT INTO Usuario (Nombre ,Nombre_Usuario ,Apellidos ,Contrasena ,Id_Departamento)
	VALUES('Julian' ,'Julian_Piedra' ,'Piedra','abc123',(SELECT d.Id_Departamento FROM Departamento d WHERE d.Departamento = 'CONSTRUCCION'))

	INSERT INTO Usuario (Nombre ,Nombre_Usuario ,Apellidos ,Contrasena ,Id_Departamento)
	VALUES('Milton' ,'Milton_Paredes' ,'Paredes','abc123',(SELECT d.Id_Departamento FROM Departamento d WHERE d.Departamento = 'CONSTRUCCION'))

	INSERT INTO Usuario (Nombre ,Nombre_Usuario ,Apellidos ,Contrasena ,Id_Departamento)
	VALUES('Hector' ,'Hector_Pacheco' ,'Pacheco','abc123',(SELECT d.Id_Departamento FROM Departamento d WHERE d.Departamento = 'CONSTRUCCION'))

	INSERT INTO Usuario (Nombre ,Nombre_Usuario ,Apellidos ,Contrasena ,Id_Departamento)
	VALUES('Luis' ,'Luis_Iturralde' ,'Iturralde','abc123',(SELECT d.Id_Departamento FROM Departamento d WHERE d.Departamento = 'CONSTRUCCION'))

	INSERT INTO Usuario (Nombre ,Nombre_Usuario ,Apellidos ,Contrasena ,Id_Departamento)
	VALUES('Karla' ,'Karla_Ortiz' ,'Ortiz','abc123',(SELECT d.Id_Departamento FROM Departamento d WHERE d.Departamento = 'LEGAL'))

	INSERT INTO Usuario (Nombre ,Nombre_Usuario ,Apellidos ,Contrasena ,Id_Departamento)
	VALUES('Lissette' ,'Lissette_Leon' ,'Leon','abc123',(SELECT d.Id_Departamento FROM Departamento d WHERE d.Departamento = 'LEGAL'))

	INSERT INTO Usuario (Nombre ,Nombre_Usuario ,Apellidos ,Contrasena ,Id_Departamento)
	VALUES('Paola' ,'Paola_Mosquera' ,'Mosquera','abc123',(SELECT d.Id_Departamento FROM Departamento d WHERE d.Departamento = 'FINANZAS'))

	INSERT INTO Usuario (Nombre ,Nombre_Usuario ,Apellidos ,Contrasena ,Id_Departamento)
	VALUES('Margarita' ,'Margarita_Huera' ,'Huera','abc123',(SELECT d.Id_Departamento FROM Departamento d WHERE d.Departamento = 'FINANZAS'))
/*INSERT USUARIOS*/
-----------------------------------------------------------------------
-----------------------------------------------------------------------
/*INSERT USUARIO_VISTA*/
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ANILLO'),'Pedro_Guzman', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ALTERNATIVA'),'Pedro_Guzman', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'PERMISOS'),'Pedro_Guzman', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'SITIOS'),'Pedro_Guzman', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ENERGIA'),'Pedro_Guzman', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'COLLO'),'Pedro_Guzman', 1,0)

INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ANILLO'),'Rommel_Duran', 1,1)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ALTERNATIVA'),'Rommel_Duran', 1,1)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'PERMISOS'),'Rommel_Duran', 1,1)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'SITIOS'),'Rommel_Duran', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ENERGIA'),'Rommel_Duran', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'COLLO'),'Rommel_Duran', 1,1)

INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ANILLO'),'Angela_Paucar', 1,1)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ALTERNATIVA'),'Angela_Paucar', 1,1)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'PERMISOS'),'Angela_Paucar', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'SITIOS'),'Angela_Paucar', 1,0)

INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ANILLO'),'Lupe_Merino', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ALTERNATIVA'),'Lupe_Merino', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'PERMISOS'),'Lupe_Merino', 1,1)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'SITIOS'),'Lupe_Merino', 1,0)

INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ANILLO'),'Julian_Piedra', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ALTERNATIVA'),'Julian_Piedra', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'PERMISOS'),'Julian_Piedra', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'SITIOS'),'Julian_Piedra', 1,1)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ENERGIA'),'Julian_Piedra', 1,1)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'COLLO'),'Julian_Piedra', 1,1)

INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ALTERNATIVA'),'Milton_Paredes', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'PERMISOS'),'Milton_Paredes', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'SITIOS'),'Milton_Paredes', 1,1)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ENERGIA'),'Milton_Paredes', 1,1)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'COLLO'),'Milton_Paredes', 1,1)

INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ALTERNATIVA'),'Luis_Iturralde', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'PERMISOS'),'Luis_Iturralde', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'SITIOS'),'Luis_Iturralde', 1,1)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ENERGIA'),'Luis_Iturralde', 1,1)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'COLLO'),'Luis_Iturralde', 1,1)

INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ANILLO'),'Karla_Ortiz', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ALTERNATIVA'),'Karla_Ortiz', 1,1)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'PERMISOS'),'Karla_Ortiz', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'SITIOS'),'Karla_Ortiz', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'COLLO'),'Karla_Ortiz', 1,1)

INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ANILLO'),'Lissette_Leon', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ALTERNATIVA'),'Lissette_Leon', 1,1)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'PERMISOS'),'Lissette_Leon', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'SITIOS'),'Lissette_Leon', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'COLLO'),'Lissette_Leon', 1,0)

INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ALTERNATIVA'),'Paola_Mosquera', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'SITIOS'),'Paola_Mosquera', 1,0)

INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'ALTERNATIVA'),'Margarita_Huera', 1,0)
INSERT INTO Usuario_Vista (Id_Vista ,Nombre_Usuario ,Lectura ,Escritura) VALUES ((SELECT Id FROM Vistas WHERE Vista = 'SITIOS'),'Margarita_Huera', 1,0)
/*INSERT USUARIO_VISTA*/



