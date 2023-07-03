create database bdFisioterapia
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
idCargo int foreign key references Cargo(idCargo)
)

create table Horario(
idHorario int primary key identity,
horario varchar(20),
estado int
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
estadoCita varchar(20)

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
)

SELECT*FROM HistoriaClinica