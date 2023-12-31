create database bdFisioterapia
use bdFisioterapia

create table Pacientes(
dniPaciente char(8) primary key,
nombres varchar(100),
apellidos varchar(100),
direccion varchar(200),
fNacimiento date,
celular char(10)
)

create table HistoriaClinica(
Id int primary key identity,
idHistoria char(10),
dniPaciente char(8) foreign key references Pacientes(dniPaciente),
antecedentes varchar(200),
peso decimal(5,2),
talla decimal(5,2),
IMC decimal(4,2),
observaciones varchar(200)
)

create table Cargo(
idCargo int primary key identity,
cargo varchar(50)
)

create table Empleado(
idEmpleado int primary key identity,
nombres varchar(100),
apellidos varchar(100),
usuario varchar(50),
contraseņa varchar(50),
idCargo int foreign key references Cargo(idCargo),
estadoEmp bit
)

create table Horario(
idHorario int primary key identity,
horario varchar(20),
estado bit
)

create table Servicio(
idServicio int primary key identity,
servicio varchar(50),
precio money
)

create table Sesiones(
idSesion int primary key identity,
idTipo int foreign key references Servicio(idServicio),
sesiones int,
precio money
)

create table Citas(
idCita int primary key identity,
dniPaciente char(8) foreign key references Pacientes(dniPaciente),
idEmpleado int foreign key references Empleado(idEmpleado),
fCita date,
hCita int foreign key references Horario(idHorario),
estadoPago int,
descuento decimal(4,2),
total money,
estadoCita bit

)

create table Pago(
idPago int primary key identity,
idCita int foreign key references Citas(idCita),
metodoPago varchar(50),
monto money,
fpago datetime
)

create table Productos(
idProducto int primary key identity,
nomProducto varchar(100),
precio money,
stock int
)


create table Impuesto(
idImpuesto int primary key identity,
impuesto varchar(20),
porcentaje decimal(4,2)
)

create table DetalleCita(
idDetalle int primary key identity,
idCita int foreign key references Citas(idCita),
idServicio int foreign key references Servicio(idServicio),
idProducto int foreign key references Productos(idProducto),
cantidad int,
precioU money,
subtotal money,
idImpuesto int foreign key references Impuesto(idImpuesto)
);



CREATE TABLE Descuentos (
    idDescuento int PRIMARY KEY IDENTITY,
    --dniPaciente char(8) REFERENCES Pacientes(dniPaciente),
    nombreDescuento varchar(100),
    valorDescuento decimal(4,2)
);
select *from Descuentos

insert into Descuentos values('Mas Citas',0.10)
insert into Descuentos values('Regular Citas',0.06)
insert into Descuentos values('Pocas Citas',0.03)

SELECT nombreDescuento,valorDescuento FROM Descuentos

SELECT*FROM Cargo

insert into Cargo values('Doctor'),('Enfermera'),('Admin')

insert into Empleado values('Camila','Lopez','maria','123',2,1),('Ernesto','Jimenez','juan','12',1,1),('Gisela','Ramirez','gise','123',3,1)

insert into horario(horario,estado) values('10:00',1),('11:00',1),('12:00',1),('13:00',1),('14:00',1),('15:00',1),('16:00',1),('17:00',1),('18:00',1)

SELECT*FROM Pacientes
go

select*from Horario

insert into Horario values('01:00',1)

select*from Empleado

update Empleado set estadoEmp=1

select*from Servicio

insert into Servicio values('Diario',35),('Domiciliario',40),('Paquete',0)

insert into Sesiones values(3,10,315),(3,12,385),(3,15,490)

select servicio,sesiones,sesiones.precio from Servicio
inner join Sesiones
on sesiones.idtipo=servicio.idServicio

select*from Citas

select idEmpleado,nombres+apellidos as nombre,usuario,cargo from Empleado e
inner join Cargo c
on e.idCargo=c.idCargo


drop table servicio