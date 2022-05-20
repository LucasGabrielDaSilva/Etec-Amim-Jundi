Create database vendas

use vendas

create table categoria
(cat_cod int identity(1,1) primary key not null,
cat_nome varchar(95) not null)

create table subcategoria(
scat_cod int identity(1,1) primary key not null,
scat_nome varchar (95) not null,
cat_cod int not null foreign key (cat_cod) 
references categoria(cat_cod)
)

select * from categoria

select * from subcategoria

insert into categoria (cat_nome)
VALUES
('Açougue')

insert into categoria (cat_nome)
Values
('Frios')

insert into categoria (cat_nome)
Values
('Bebidas')

insert into categoria (cat_nome)
Values
('Congelados e Resfriados')

insert into categoria (cat_nome)
Values
('Padaria')

insert into subcategoria (scat_nome, cat_cod)
values
('Aves',1),
('Refrigerante',3),
('Laticinio',2),
('Bolo de Chocolate',5),
('Pães Congelados', 4),
('Bovino',1)


create table marca (
cod_marca int identity(1,1) primary key not null,
nome Varchar(30) not null
)

insert into marca(nome)
values 
('Coca-cola'),
('Sadia'),
('Perdigão'),
('Forno de Minas'),
('Friboi'),
('Fabricação Própria')

select * from marca

create table produtos
(cod_produto int identity primary key not null,
nome Varchar(60)not null,
preco money not null,
data_fab date not null,
data_venc date not null,
inf_adicionais text null,
cod_marca int not null foreign key (cod_marca)
references marca (cod_marca),
cat_cod int not null foreign key (cat_cod)
references categoria(cat_cod),
scat_cod int not null foreign key (scat_cod)
references subcategoria(scat_cod)
)

select * from marca
select * from subcategoria
select * from categoria
select * from produtos

insert into produtos(nome,preco,data_fab,data_venc,inf_adicionais,cod_marca,cat_cod,scat_cod)
values
 ('Coca-Cola 2 Litros',  9.50, '10/10/2021', '10/12/2022', 'Produto Gaseificado',3,3,2),
('Requeijão', 8.99,'20/02/2022','20/04/2022','Contém amido de milho',1,2,3),
('Peito de Peru', 23.87, '10/04/2022', '17/04/2022', 'Contém Peru', 1,5,1),
('Pão Francês', 8.00,'08/05/2022','23/06/2022','Contém Pão',5,4,6),
('Guarana Antartica', 5.00, '12/03/2022', '12/06/2022', 'Contem Gás',3,3,6)

select S.scat_cod, S.scat_nome, S.cat_cod, C.cat_nome
from subcategoria S inner join categoria C
on (S.cat_cod = C.cat_cod)


Select p.nome, p.cod_marca, m.nome
from produtos p inner join marca m
on (p.cod_marca = m.cod_marca)

/*Listar os nomes dos produtos e suas subcategorias*/

select p.nome, p.scat_cod, s.scat_nome
from produtos p inner join subcategoria s
on (p.scat_cod = s.scat_cod)

select p.nome, c.cat_nome, s.cat_cod, m.nome
from produtos p inner join categoria c
on (p.cat_cod = c.cat_cod)
inner join subcategoria s
on (p.scat_cod = s.cat_cod)
inner join marca m 
on (p.cod_marca = m.cod_marca)