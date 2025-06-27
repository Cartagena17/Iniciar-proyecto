create database Hospital
--Creando tablas: Tabla doctor verificar siempre cuales son las tablas principales
go
use Hospital
go

create table doctores (
id_doctor int primary key identity (1,1),
nombre varchar (100) not null,
apellido varchar(100) not null,
especialidad varchar(100) not null,
cargp varchar(100) not null);

-- tabla pacientes

create table pacientes (
id_paciente int primary key identity (1,1),
Num_ISSS varchar (20) not null unique,
nombre varchar (100) not null,
apellido varchar(100) not null,
domicilio varchar (200) not null,
telefono varchar (20) not null,
sexo varchar (10) not null check (sexo in('masculino', 'Femenino', 'Otro')),
costo_tratamiento decimal (10,2) not null default 0.00);

create table ingresos (
id_ingreso int primary key identity (1,1),
id_paciente int not null,
fecha_ingreso datetime not null default getdate(),
id_doctor int not null,
diagnostico varchar (max) not null,
constraint FK_ingresos_pacientes foreign key (id_paciente) references
pacientes (id_paciente),
constraint FK_ingreso_doctores foreign key (id_doctor) references
doctores (id_doctor)
);

--Llenaremos nuestra base con datos 
--Probando el metodo select para traer todos los datos
--insertamos datos iniciales

insert into doctores (nombre,apellido,especialidad,cargp)
values
('Douglas','Cartagena','Cardiologia','Cardiologo'),
('Daniel','Arauz','Primeros auxilios','Enfermero'),
('Carlos','Molina','Neurologia','Neurologo');

select nombre,especialidad from doctores
select nombre, apellido, especialidad,cargp from doctores;