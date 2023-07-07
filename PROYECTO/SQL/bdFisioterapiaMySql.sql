
create table Pacientes(
dniPaciente char(8) primary key,
nombres varchar(100),
apellidos varchar(100),
direccion varchar(200),
fNacimiento date,
celular char(10)
);


create table HistoriaClinica(
Id int primary key AUTO_INCREMENT,
idHistoria char(10),
dniPaciente char(8),
antecedentes varchar(200),
peso decimal(5,2),
talla decimal(5,2),
IMC decimal(4,2),
observaciones varchar(200),
CONSTRAINT `FK__PACIENTES_HISTORIA`
    FOREIGN KEY (`dniPaciente`)
    REFERENCES `bdFisioterapia`.`Pacientes` (`dniPaciente`)
);

create table Cargo(
idCargo int primary key AUTO_INCREMENT,
cargo varchar(50)
);

create table Empleado(
idEmpleado int primary key AUTO_INCREMENT,
nombres varchar(100),
apellidos varchar(100),
usuario varchar(50),
contraseña varchar(50),
idCargo int ,
estadoEmp TINYINT,
CONSTRAINT `FK__CARGO_EMPLEDO`
    FOREIGN KEY (`idCargo`)
    REFERENCES `bdFisioterapia`.`Cargo` (`idCargo`)
);

create table Horario(
idHorario int primary key AUTO_INCREMENT,
horario varchar(20),
estado TINYINT
);

create table Servicio(
idServicio int primary key AUTO_INCREMENT,
servicio varchar(50),
precio decimal(10,2)
);

create table Sesiones(
idSesion int primary key AUTO_INCREMENT,
idTipo int ,
sesiones int,
precio decimal(10,2),
CONSTRAINT `FK__Servicio_Sesiones`
    FOREIGN KEY (`idTipo`)
    REFERENCES `bdFisioterapia`.`Servicio` (`idServicio`)
);

create table Citas(
idCita int primary key AUTO_INCREMENT,
dniPaciente char(8) ,
idEmpleado int ,
fCita date,
hCita int ,
estadoPago TINYINT,
descuento decimal(4,2),
total decimal(10,2),
estadoCita TINYINT,
CONSTRAINT `FK__Paciente_Cita`
    FOREIGN KEY (`dniPaciente`)
    REFERENCES `bdFisioterapia`.`Pacientes` (`dniPaciente`),
    CONSTRAINT `FK__Citas_Empleado`
    FOREIGN KEY (`idEmpleado`)
    REFERENCES `bdFisioterapia`.`Empleado` (`idEmpleado`),
    CONSTRAINT `FK__Horario_Citas`
    FOREIGN KEY (`hCita`)
    REFERENCES `bdFisioterapia`.`Horario` (`idHorario`)

);

create table Pago(
idPago int primary key AUTO_INCREMENT,
idCita int,
metodoPago varchar(50),
monto decimal(10,2),
fpago datetime,
CONSTRAINT `FK__Pago_Citas`
    FOREIGN KEY (`idCita`)
    REFERENCES `bdFisioterapia`.`Citas` (`idCita`)
);

create table Productos(
idProducto int primary key AUTO_INCREMENT,
nomProducto varchar(100),
precio decimal(10,2),
stock int
);

create table Impuesto(
idImpuesto int primary key AUTO_INCREMENT,
impuesto varchar(20),
porcentaje decimal(4,2)
);

create table DetalleCita(
idDetalle int primary key AUTO_INCREMENT,
idCita int ,
idServicio int ,
idProducto int,
cantidad int,
precioU decimal(10,2),
subtotal decimal(10,2),
idImpuesto int ,
CONSTRAINT `FK__Dcita_Citas`
    FOREIGN KEY (`idCita`)
    REFERENCES `bdFisioterapia`.`Citas` (`idCita`),
    CONSTRAINT `FK__Dcita_Servicio`
    FOREIGN KEY (`idServicio`)
    REFERENCES `bdFisioterapia`.`Servicio` (`idServicio`),
    CONSTRAINT `FK__Dcita_Producto`
    FOREIGN KEY (`idProducto`)
    REFERENCES `bdFisioterapia`.`Productos` (`idProducto`),
    CONSTRAINT `FK__Dcita_Impuesto`
    FOREIGN KEY (`idImpuesto`)
    REFERENCES `bdFisioterapia`.`Impuesto` (`idImpuesto`)
);

insert into Cargo(cargo) values('Doctor'),('Enfermera');
insert into Empleado(nombres,apellidos,usuario,contraseña,idCargo,estadoEmp) values('Camila','Lopez','maria','123',2,1),('Ernesto','Jimenez','juan','12',1,1),('Gisela','Ramirez','gise','123',3,1);


CREATE TABLE Descuentos (
    idDescuento int PRIMARY KEY AUTO_INCREMENT,
    nombreDescuento varchar(100),
    valorDescuento decimal(4,2)
);

insert into Servicio(servicio,precio) values('Diario',35),('Domiciliario',40),('Paquete',0);

insert into Sesiones (idTipo,sesiones,precio) values(3,10,315),(3,12,385),(3,15,490);

insert into Descuentos (nombreDescuento,valorDescuento) values('Regular Citas',0.06);

call MostrarPacienteHistoria();











