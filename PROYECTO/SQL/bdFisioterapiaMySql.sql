
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
CONSTRAINT `FK__CARGO_EMPLEDO`
    FOREIGN KEY (`idCargo`)
    REFERENCES `bdFisioterapia`.`Cargo` (`idCargo`)
);

create table Horario(
idHorario int primary key AUTO_INCREMENT,
horario varchar(20),
estado int
);

create table Servicio(
idServicio int primary key AUTO_INCREMENT,
servicio varchar(50),
precio double
);

create table Sesiones(
idSesion int primary key AUTO_INCREMENT,
idTipo int ,
sesiones int,
precio double,
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
estadoPago int,
descuento decimal(4,2),
total double,
estadoCita varchar(20),
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
monto double,
fpago datetime,
CONSTRAINT `FK__Pago_Citas`
    FOREIGN KEY (`idCita`)
    REFERENCES `bdFisioterapia`.`Citas` (`idCita`)
);

create table Productos(
idProducto int primary key AUTO_INCREMENT,
nomProducto varchar(100),
precio double,
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
precioU double,
subtotal double,
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
insert into Empleado(nombres,apellidos,usuario,contraseña,idCargo) values('Camila','Lopez','maria','123',2),('Ernesto','Jimenez','juan','12',1);

call MostrarPacienteHistoria();











