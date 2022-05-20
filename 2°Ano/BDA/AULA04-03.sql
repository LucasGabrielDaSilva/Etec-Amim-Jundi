Create database Cliente_Animal
use Cliente_Animal

Create table Cliente
(codigo int primary key not null,
nome varchar(80) not null,
endereco varchar(80) not null,
bairro varchar (50) not null,
cidade varchar(50) not null,
estado varchar(30) not null,
cep bigint)

insert into Cliente
(codigo,nome,endereco,bairro,cidade,estado,cep)
values
(1, 'Rita Lima', 'Rua Vinte, 4','Centro','Osvaldo Cruz','SP',17700000),
(2, 'Paulo Costa', 'Rua Quarentena, 2', 'Vila A','Osvaldo Cruz','SP',17700000),
(3, 'Amanda Gomes','Rua Cinquenta,3','centro','parapua','SP',17730000),
(4, 'Felipe Lira','Av.Brasil, 20', 'Centro','Osvaldo Cruz', 'SP', 177000),
(5, 'Lucas Gabriel','av felipe carmona', 'centro','osvaldo cruz','sp',17700000),
(6, 'Willian Yuji','Rua Andre Campoy','Acapulco','Osvaldo Cruz','SP',17700000)

update Cliente
SET cep = 17700000
WHERE codigo = 4;

select * from Cliente order by nome, codigo, endereco asc

select nome, cidade from Cliente

Create table Animais
(cod int primary key not null,
nome varchar(40) not null,
datanasc date not null,
sexo varchar (20) not null,
falecido varchar(20) not null,
observa��es text not null)

insert into Animais
(cod,nome,datanasc,sexo,falecido,observa��es)
values
(1, 'Lulu','2014-08-11', 'F', 'N', 'Nada Consta'),
(2,'Pingo', '2009-10-10', 'M', 'N', 'Nada Consta'),
(3, 'Xuxa','2017-05-04', 'F','S','Acidente de carro')



select * from Animais order by nome desc
select nome, datanasc, sexo from Animais 

update Animais
SET observa��es = 'Envenenamento'
WHERE cod = 3;

update Cliente
SET endereco = 'Rua Jap�o, 130'
WHERE codigo = 3;

update Cliente
SET estado = 'RJ'
WHERE codigo = 4;

update Cliente
SET cep = '21310000'
WHERE codigo = 4;


DELETE FROM Animais
WHERE cod = 2;

exec sp_rename 'Animais.observa��es','historico', 'COLUMN'

alter table Cliente
drop column cep

ALTER TABLE Animais
ADD ra�a varchar(50)

update Animais
SET ra�a = 'Pincher'
WHERE cod = 1;

update Animais
SET ra�a = 'Pincher'
WHERE cod = 2;

update Animais
SET ra�a = 'Pincher'
WHERE cod = 3;

SELECT * FROM information_schema.tables

EXEC sp_rename 'Cliente',
'Tab_clientes';

drop table animais

drop table Tab_cliente

use master
drop database Cliente_Animal