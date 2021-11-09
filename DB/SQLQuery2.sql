--INSERT INTO Especialidades (Denominacion, Inactivo)
--VALUES ('Nutricion', 0)

--INSERT INTO Especialidades (Denominacion, Inactivo)
--VALUES ('Pediatria', 0), ('Kinesiologo', 0)




--BEGIN TRANSACTION

--UPDATE Especialidades SET Inactivo = 0 WHERE ID = 2


--ROLLBACK
--COMMIT


BEGIN TRAN
INSERT INTO Personas (Apellido, Nombre, Celular, Email)
values ('Stark', 'Tony', '+1568656516', 'tony@stark.com')

INSERT INTO Personas (Apellido, Nombre, Celular, Email)
values ('Connor', 'Shara', '+1568656517', 'shara@stark.com')

INSERT INTO Personas (Apellido, Nombre, Celular, Email)
values ('Banner', 'Bruce', '+1568656518', 'bruce@stark.com')


COMMIT


SELECT ID, Denominacion, Inactivo 
  FROM Especialidades 
 WHERE Inactivo = 0
 ORDER BY Denominacion

SELECT * FROM Personas


begin tran
UPDATE Personas SET EspecialidadID = 2 WHERE ID = 1
commit

begin tran
UPDATE Personas SET EspecialidadID = 1 WHERE ID = 2

rollback
commit


SELECT Personas.Nombre, Personas.Apellido, Personas.Celular, Personas.Email,
       Personas.EspecialidadID, Especialidades.Denominacion
  FROM Personas
  LEFT JOIN Especialidades ON Especialidades.ID = Personas.EspecialidadID


