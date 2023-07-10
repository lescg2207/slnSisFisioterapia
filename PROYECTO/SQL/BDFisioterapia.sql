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
contraseña varchar(50),
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
create table Impuesto(
idImpuesto int primary key identity,
impuesto varchar(20),
porcentaje decimal(4,2)
)

create table Citas(
idCita int primary key identity,
dniPaciente char(8) foreign key references Pacientes(dniPaciente),
idEmpleado int foreign key references Empleado(idEmpleado),
fCita date,
hCita int foreign key references Horario(idHorario),
estadoPago int,
total money,
idImpuesto int foreign key references Impuesto(idImpuesto)null,
idDescuento int foreign key references Descuentos(idDescuento)null,
estadoCita bit
)

create table Boleta(
idPago int primary key identity,
idCita int foreign key references Citas(idCita),
dniPaciente char(8),
metodoPago varchar(50),
subtotal money,
impuesto decimal(4,2),
descuento decimal(4,2),
total money,
fpago datetime
)

create table Productos(
idProducto int primary key identity,
nomProducto varchar(100),
precio money,
stock int
)


CREATE TABLE Descuentos (
idDescuento int PRIMARY KEY IDENTITY,
nombreDescuento varchar(100),
valorDescuento decimal(4,2)
);

create table DetalleCita(
idDetalle int primary key identity,
idCita int foreign key references Citas(idCita),
idServicio int foreign key references Servicio(idServicio) null,
idProducto int foreign key references Productos(idProducto) null,
cantidad int,
precioU money,
subtotal money
);

insert into Descuentos values('Todas las citas',0.05)
insert into Descuentos values('Regular Citas',0.06)
insert into Descuentos values('Pocas Citas',0.03)


insert into Cargo(cargo) values('Doctor'),('Enfermera'),('Admin')

insert into Empleado(nombres,apellidos,usuario,contraseña,idCargo,estadoEmp) values('Camila','Lopez','maria','123',2,1),('Ernesto','Jimenez','juan','12',1,1),('Gisela','Ramirez','gise','123',3,1)

insert into horario(horario,estado) values('10:00',1),('11:00',1),('12:00',1),('13:00',1),('14:00',1),('15:00',1),('16:00',1),('17:00',1),('18:00',1)


insert into Servicio(servicio,precio) values('Diario',35),('Domiciliario',40),('Paquete',0)

insert into Sesiones(idTipo,sesiones,precio) values(3,10,315),(3,12,385),(3,15,490)

insert into Impuesto(impuesto,porcentaje) values ('IGV','0.18')



select*from Citas

SELECT d.idDetalle, c.idCita, p.nomProducto AS Producto, s.servicio AS Servicio, d.cantidad, d.precioU, d.subtotal
FROM DetalleCita d
JOIN Citas c ON d.idCita = c.idCita
LEFT JOIN Productos p ON d.idProducto = p.idProducto
LEFT JOIN Servicio s ON d.idServicio = s.idServicio;

SELECT d.idDetalle, c.idCita,
    CASE
        WHEN d.idProducto IS NOT NULL THEN (SELECT nomProducto FROM Productos WHERE idProducto = d.idProducto)
        WHEN d.idServicio IS NOT NULL THEN (SELECT servicio FROM Servicio WHERE idServicio = d.idServicio)
    END AS NOMBRE,
    d.cantidad, d.precioU, d.subtotal
FROM DetalleCita d
JOIN Citas c ON d.idCita = c.idCita;



