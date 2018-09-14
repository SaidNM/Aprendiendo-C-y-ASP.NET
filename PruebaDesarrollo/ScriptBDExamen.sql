create database examen;
use examen;
create table categoria (idCategoria int not null auto_increment primary key, descripcion varchar(45));
create table producto(idProducto int not null auto_increment primary key, nombre varchar(45) not null,precio double  not null,
						descripcion varchar(45),existencias int not null, idCategoria int not null,
                        foreign key (idCategoria) references categoria(idCategoria) on delete cascade on update cascade);
insert into categoria(descripcion) values ("Lacteos");
insert into categoria(descripcion) values ("Electronica");
insert into categoria(descripcion) values ("Ropa");
select * from categoria;
insert into producto(nombre,precio,descripcion,existencias,idCategoria) values ("Pantalla",14999.90,"Aparato para ver programas",6,2);
insert into producto(nombre,precio,descripcion,existencias,idCategoria) values ("Leche SantaClara",20.5,"Leche entera 1L",50,1);
insert into producto(nombre,precio,descripcion,existencias,idCategoria) values ("Sueter Polo",253.90,"Sueter de algodon",10,3);
insert into producto(nombre,precio,descripcion,existencias,idCategoria) values ("Pantalon Mezclilla",460,"Pantalon color azu",30,3);
insert into producto(nombre,precio,descripcion,existencias,idCategoria) values ("Bocinas",5000,"Par de bocinas para auto",9,2);
insert into producto(nombre,precio,descripcion,existencias,idCategoria) values ("Leche Lala",23,"Leche premium 1L",25,1);
insert into producto(nombre,precio,descripcion,existencias,idCategoria) values ("Playera Nike",150,"Playera de algodon azul",7,3);
select * from producto;
select producto.nombre, producto.precio , producto.descripcion, producto.existencias, categoria.descripcion from producto,categoria where producto.idCategoria=categoria.idCategoria order by precio asc;
