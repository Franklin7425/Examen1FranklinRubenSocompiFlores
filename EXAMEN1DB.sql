
CREATE DATABASE ExamenDB;
USE ExamenDB;



CREATE TABLE Persona (
    IDPersona INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Nombre NVARCHAR(100)NOT NULL,
    Apellido NVARCHAR(100)NOT NULL,
    Estado NVARCHAR(100)NOT NULL
);

CREATE TABLE Empleado (
    IDEmpleado INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	IDPERSONA INT NOT NULL,
    Nombre NVARCHAR(100)NOT NULL,
    Puesto NVARCHAR(255)NOT NULL,
    Salario DECIMAL(10,2)NOT NULL,
    FechaContratacion DATETIME NOT NULL,
	FOREIGN KEY (IDPERSONA) REFERENCES PERSONA (IDPERSONA)
);



INSERT INTO Persona(Nombre, Apellido, Estado) 
VALUES 
    ('Carlos', 'Suarez','Activo'),
    ('Joel', 'Colque','Activo'),
    ('Pedro', 'Villca','Activo'),
    ('Mia', 'Nina','Activo'),
    ('Lia', 'Segovia','Activo'),
    ('Jazmin', 'Morales','Activo'),
    ('Vanesa', 'Mesa','Activo'),
    ('Ariel', 'Chambi','Activo'),
    ('Limber', 'Ortega','Activo'),
    ('Nicolas', 'Subelza','Activo'),
    ('Nick', 'Flores', 'Activo'),
    ('Jhon', 'Cueva','Activo'),
    ('Randy', 'Orton','Activo'),
    ('Vegeta', 'Perales','Activo'),
    ('Goku', 'Velazquez','Activo');


INSERT INTO Empleado (IDPERSONA, Nombre, Puesto, Salario, FechaContratacion)
VALUES
    (1, 'Juan', 'Gerente de ventas', 5000.00, '2020-02-15 00:00:00'),
    (2, 'Maria', 'Asistente administrativo', 3000.00, '2021-05-10 00:00:00'),
    (3, 'Carlos', 'Analista de sistemas', 4500.00, '2019-11-20 00:00:00'),
    (4, 'Laura', 'Contador', 4800.00, '2020-08-03 00:00:00'),
    (5, 'Pedro', 'Ingeniero de sistemas', 5500.00, '2022-01-30 00:00:00'),
    (6, 'Ana', 'Desarrollador web', 4000.00, '2020-04-25 00:00:00'),
    (7, 'Luis', 'Diseñador grafico', 4200.00, '2021-09-12 00:00:00'),
    (8, 'Sofia', 'Recursos humanos', 3800.00, '2018-07-05 00:00:00'),
    (9, 'Diego', 'Analista financiero', 4700.00, '2022-03-08 00:00:00'),
    (10, 'Gabriela', 'Jefa de marketing', 4200.00, '2019-10-17 00:00:00'),
    (11, 'Oscar', 'Jefe de limpieza', 2000.00, '2020-11-28 00:00:00'),
    (12, 'Valeria', 'Mantenimiento', 3200.00, '2021-07-14 00:00:00'),
    (13, 'Jorge', 'Técnico de soporte', 3800.00, '2019-04-22 00:00:00'),
    (14, 'Mariana', 'Secretaria', 2500.00, '2022-02-19 00:00:00'),
    (15, 'Raul', 'Jefe de seguridad', 4900.00, '2020-06-30 00:00:00');


	select * from Persona;
	select * from Empleado;