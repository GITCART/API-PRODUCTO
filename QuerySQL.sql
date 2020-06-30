-- CREAR DATABASE
create database servicios
go

-- USAR DATABASE
use servicios
go

-- CREAR PRODUCTOS
create table productos
(
	pro_id			bigint			not null	identity(1,1),
	pro_codigo		varchar(10)		not null,
	pro_descripcion	varchar(60)		not null,
	pro_precio		decimal(10,2)	not null,
)
alter table productos add constraint  pk_productos primary key(pro_id)
alter table productos add constraint  uq_productos unique(pro_codigo)


-- QUERY

create procedure p_listar_productos
AS
	select pro_id, pro_codigo, pro_descripcion, pro_precio from productos
go

create procedure p_obtner_productos @pro_id bigint
AS
	select pro_id, pro_codigo, pro_descripcion, pro_precio from productos where pro_id=@pro_id
go


/*=========================================
	INSERTAR REGISTRO
==========================================*/
insert into productos 
(pro_codigo, pro_descripcion, pro_precio) 
values ('TERMA0001','Terma Instantánea Express ROTOPLAS, con potencia 5500 Watts',198.12)

insert into productos 
(pro_codigo, pro_descripcion, pro_precio) 
values ('PARL0002','Parlante Portatil Multi Bluetooh 16W PK3   LG',189.64)

insert into productos 
(pro_codigo, pro_descripcion, pro_precio) 
values ('BZKB2215','Parlante B2215 Powerful Tower   BAZZUKA, Metal / Plástico',320.50)

insert into productos 
(pro_codigo, pro_descripcion, pro_precio) 
values ('LEBTSPK03R','Parlante Altavoz con Bluetooth y Música Box Rojo (LEOTEC)',79.00)

insert into productos 
(pro_codigo, pro_descripcion, pro_precio) 
values ('BZKB11520','Parlante B115 20 BLT Pedestal (BAZZUKA), Metal / Plástico',699.00)
GO
