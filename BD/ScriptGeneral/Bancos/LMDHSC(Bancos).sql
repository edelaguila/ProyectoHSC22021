use hotelsancarlos;

INSERT INTO proveedor VALUES ('1', 'Prov1', 'Zona 6', '123453', 'avc@miumg.edu.gt', '1', 'A');
INSERT INTO proveedor VALUES ('2', 'Prov2', 'Zona 6', '123453', 'avc@miumg.edu.gt', '1', 'A');
INSERT INTO banco VALUES ('1', 'Banco Industrial', 'Zona 1');

INSERT INTO chequesprov values ('1','Al Portador','1','1',100,'2021/11/25','A');
INSERT INTO chequesprov values ('2','Al Portador','1','1',150,'2021/10/26','A');
INSERT INTO chequesprov values ('3','Al Portador','1','2',150,'2021/10/26','A');

INSERT INTO moneda values ('1','Dolar','1');
INSERT INTO moneda values ('2','Euro','1');

INSERT INTO tipocambio values('1','1','2021-11-05','7.73');
INSERT INTO tipocambio values('2','2','2021-11-05','8.94');

INSERT INTO tipocuena values('001','Industrial','1');
INSERT INTO tipocuena values('002','Banrural','1');

INSERT INTO cuenta values('001','Industrial','001','50.00','1000','10000','1','001');
INSERT INTO cuenta values('002','Banrural','002','25.00','100','25000','1','002');
