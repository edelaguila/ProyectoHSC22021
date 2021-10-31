/*tablas especificas area compras*/
use hotelSanCarlos;

CREATE TABLE proveedores (
  idProveedor varchar(15),
  nombre varchar(100) not NULL,
  direccion varchar(500) not NULL,
  telefono int not NULL,
  email varchar(200) not NULL,
  idEmpresa varchar(15),
  stsproveedor varchar(1),
  primary key (idProveedor),
  foreign key (idEmpresa) references empresa (idEmpresa)
  )ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table ordencompra(
  idOrdenCompra varchar(15),
  idProveedor	varchar(15) not null,
  total			float not null,
  fecha 		date,
  descripcion	varchar(100),
  primary key (idOrdenCompra),
  foreign key (idProveedor) references proveedores (idProveedor)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table movimiento (
  idMovimiento  varchar(15),
  idOrdenCompra varchar(15) not null,
  total			float,
  abonado		float,
  stsMov		varchar(1),
  primary key	(idMovimiento),
  foreign key   (idOrdenCompra) references ordencompra (idOrdenCompra)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE facturaEncabezado (
  idFacturaEncabezado varchar(15),
  idProveedor varchar(15) not NULL,
  fecha date,
  descripcion varchar(200),
  total float not null,
  idOrdenCompra varchar(15) not null,
  primary key(idFacturaEncabezado),
  foreign key (idProveedor) references proveedores (idProveedor),  
  foreign key (idOrdenCompra) references ordencompra (idOrdenCompra)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table facturaDetalle(
	idFacturaDetalle varchar(15), 
	idFacturaEncabezado varchar(15),
	idProducto			varchar(15),
	monto float,
	concepto varchar(65),
	primary key(idFacturaDetalle),
    foreign key (idFacturaEncabezado) references facturaEncabezado (idFacturaEncabezado),
    foreign key (idProducto) references producto (idProducto)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;
