Create database SchoolProject
use SchoolProject

Create table Comuna(
IdComuna int primary key,
NombreComuna varchar(30))

Create table Cargo(
IdCargo int primary key,
NombreCargo varchar(30))

Create table Login(
Rut varchar(20) primary key,
Clave varchar(50))

Create table Usuario(
Rut varchar(20) primary key,
NombreTrabajador varchar(50),
IdCargo int FOREIGN KEY REFERENCES Cargo(IdCargo))

Create table Colegio(
IdColegio int primary key,
NombreColegio varchar(50),
Telefono varchar(20),
IdComuna int FOREIGN KEY REFERENCES Comuna(IdComuna),
IdCargo int FOREIGN KEY REFERENCES Cargo(IdCargo))

Create table SalasColegio(
IdSala int primary key,
TipoSala varchar(20),
NombreSala varchar(50),
Capacidad int,
IdColegio int FOREIGN KEY REFERENCES Colegio(IdColegio))


insert into SalasColegio (IdSala, TipoSala, NombreSala, Capacidad, IdColegio) values (1, 'Biblioteca', 'Biblioteca', 60, 1)
insert into SalasColegio (IdSala, TipoSala, NombreSala, Capacidad, IdColegio) values (2, 'Sala media', 'Sala 4to Medio', 30, 2)

insert into Colegio (IdColegio, NombreColegio, Telefono, IdComuna, IdCargo) values (1, 'Colegio Life Support', '+56 9 9878 6589', 2, 2)
insert into Colegio (IdColegio, NombreColegio, Telefono, IdComuna, IdCargo) values (2, 'Trinity College', '+56 9 7895 7852', 3, 1)

Insert into Comuna (IdComuna, NombreComuna) values (1, 'Providencia')
Insert into Comuna (IdComuna, NombreComuna) values (2, 'Las Condes')
Insert into Comuna (IdComuna, NombreComuna) values (3, 'Rancagua')

Insert into Cargo(IdCargo, NombreCargo) values (1, 'Profesor')
Insert into Cargo(IdCargo, NombreCargo) values (2, 'Alumno')

Insert into Login(Rut, Clave) values ('20.907.416-8', 'Nuke')
Insert into Login(Rut, Clave) values ('18.856.980-K', '1234')

Insert into Usuario(Rut, NombreTrabajador, IdCargo) values ('20.907.416-8', 'Manuel', 2)
Insert into Usuario(Rut, NombreTrabajador, IdCargo) values ('18.856.980-K', 'Cosme Fulanito', 1)

Select * from Comuna
Select * from Cargo
Select * from Login
Select * from Usuario
Select * from Colegio
Select * from SalasColegio
