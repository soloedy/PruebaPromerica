CREATE DATABASE CanjePuntos;

Use CanjePuntos;

CREATE TABLE Articulo(
	art_Id integer,
	art_Nombre varchar(50),
	art_tipo varchar(50),
	art_subtipo varchar(50),
	PRIMARY KEY (art_Id));

CREATE TABLE Sucursal(
	suc_id integer, 
	suc_nombre varchar(150),
	PRIMARY KEY (suc_id));

CREATE TABLE SucursualInventario(
	suc_id integer, 
	suci_fecha date, 
	art_id integer, 
	suci_cantidad integer, 
	FOREIGN KEY (suc_id) references Sucursal(suc_id),
	FOREIGN KEY (art_id) references Articulo(art_id));

CREATE TABLE Promocion_maestro(
	prom_id integer, 
	prom_nombre varchar(150),
	prom_FechaInicio date, 
	prom_FechaFin date,
	prom_estado bit,
	PRIMARY KEY (prom_id));

CREATE TABLE Promocion_detalle(
	prom_id integer, 
	art_id integer, 
	promd_precio decimal,
	FOREIGN KEY (prom_id) references Promocion_maestro(prom_id),
	FOREIGN KEY (art_id) references Articulo(art_id));

CREATE TABLE Canje(
	can_id integer, 
	prom_id integer, 
	can_cantidad integer, 
	art_id integer, 
	can_precio decimal,
	can_observaciones varchar(300),
	PRIMARY KEY (can_id),
	FOREIGN KEY (prom_id) references Promocion_maestro(prom_id),
	FOREIGN KEY (art_id) references Articulo(art_id));