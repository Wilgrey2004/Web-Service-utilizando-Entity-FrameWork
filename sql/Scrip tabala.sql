--create database inventario

--use inventario 

create table InConteo(
id int identity(1,1) primary key not null,
Nombre varchar(50) not null, 
cantidad int, 
estatus int references estatus(id_Estatus)
)





create table estatus(
	id_Estatus int identity(1,1) primary key not null,
	Nombre varchar(10)
)

insert into estatus(Nombre) values ('ACTIVO'),('INACTIVO')


INSERT INTO InConteo (Nombre, cantidad, estatus) VALUES ('Laptop Dell', 50, 1);
INSERT INTO InConteo (Nombre, cantidad, estatus) VALUES ('Teclado Logitech', 30, 1);
INSERT INTO InConteo (Nombre, cantidad, estatus) VALUES ('Mouse HP', 25, 2);
INSERT INTO InConteo (Nombre, cantidad, estatus) VALUES ('Monitor Samsung', 15, 1);
INSERT INTO InConteo (Nombre, cantidad, estatus) VALUES ('Disco Duro Seagate', 40, 2);
INSERT INTO InConteo (Nombre, cantidad, estatus) VALUES ('Memoria USB Kingston', 100, 1);
INSERT INTO InConteo (Nombre, cantidad, estatus) VALUES ('Impresora Canon', 10, 1);
INSERT INTO InConteo (Nombre, cantidad, estatus) VALUES ('Cable HDMI', 75, 1);
INSERT INTO InConteo (Nombre, cantidad, estatus) VALUES ('Audífonos Sony', 20, 2);
INSERT INTO InConteo (Nombre, cantidad, estatus) VALUES ('Cargador Universal', 60, 1);