Create DataBase Vendas
Use Vendas

create table categoria (cat_cod int identity (1,1) Primary Key not null,
cat_nome varchar(95)
)
select * from categoria
create table subcategoria (scat_cod int identity(1,1) Primary Key not null,
scat_nome varchar (95) Not null,
cat_cod int not null Foreign Key(cat_cod)
References categoria (cat_cod)
)

Insert into categoria(cat_nome)
Values ('Açougue'),('Frios'),('Bebidas')
select * from categoria