use hotelSanCarlos;

create table if not exists COMPRAENCABEZADO(
	pkNoDocumentoEnca 			varchar(15),
    fkIdProveedor				varchar(15),
    fkIdEmpleado				varchar(15),
    fkIdEmpresa					varchar(15),
    fkIdSucursal				varchar(15),
	fkIdBodega       			varchar(15),
    fechaCompra 				varchar(15),
    totalCompra 				double(12,2) not null,
    estadoCompra 				int(1)not null,
    primary key(pkNoDocumentoEnca),
  foreign key (fkIdProveedor) references proveedor (idProveedor),
  foreign key (fkIdEmpleado) references empleado (pkIdEmpleado),
  foreign key (fkIdEmpresa) references empresa (idEmpresa),
  foreign key (fkIdSucursal) references sucursal (idSucursal),
  foreign key (fkIdBodega) references bodega (pkid)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;


create table COMPRADETALLE(
    fkNoDocumentoEnca           varchar(15),
    fkIdProducto                    varchar(15),
    cantidadCompraDe            int(10)not null,
    costoCompraDe               double(8,2)not null,
    estado                      int(1),
    primary key(fkNoDocumentoEnca,fkIdProducto),
    foreign key(fkNoDocumentoEnca) references compraencabezado(pkNoDocumentoEnca),
    foreign key(fkIdProducto) references producto(pkid)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;


create table if not exists SALDOSCOMRPA(
pksaldocompra               varchar(15),
fkNoDocumentoEnca           varchar(15),
saldo                       double(10,2),
primary key (pksaldocompra)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

create table if not exists SALDOHISTORICOCOMPRA(
pksaldohistoricocompra     varchar(15),
fechamovimientocompra       varchar(15) not null,
fkNoDocumentoEnca           varchar(15),
saldoanterior                double(10,2),
abono                        double(10,2),
cargo                        double(10,2),
primary key (pksaldohistoricocompra),
    foreign key (fkNoDocumentoEnca) references compraencabezado(pkNoDocumentoEnca)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;



