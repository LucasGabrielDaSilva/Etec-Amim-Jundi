 create database AulaSelect

CREATE TABLE  CLIENTES 
(
  codigo  int  primary key identity not null,
  nome  varchar (60) not null,
  cidade  varchar (40) not null,
  estado varchar (02) not null,
  pais  varchar (35) not null,
  celular  varchar (25) not null,
  email   varchar (50) not null,
  fone_fixo varchar (25) not null
 );
INSERT INTO CLIENTES (nome, cidade, estado, pais, celular, email, fone_fixo) 
 VALUES ('Raul Cunha', 'Osvaldo Cruz', 'SP', 'Brasil', '999999999', 'raul@gmail.com', '35280022');
 
 INSERT INTO CLIENTES (nome, cidade, estado, pais, celular, email, fone_fixo) 
 VALUES ('Gabriela Santos', 'Osvaldo Cruz', 'SP', 'Brasil', '999874532', 'gabi@gmail.com', '35288765');
 
 INSERT INTO CLIENTES (nome, cidade, estado, pais, celular, email, fone_fixo) 
 VALUES ('Pedro Fonseca', 'Rio de Janeiro', 'RJ', 'Brasil', '997654389', 'pedro@outlook.com', '37378954');
 
 INSERT INTO CLIENTES (nome, cidade, estado, pais, celular, email, fone_fixo) 
 VALUES ('Maria Silva', 'Salvador', 'BA', 'Brasil', '996508765', 'maria@gmail.com', '78654321');


CREATE TABLE  produtos 
(
  codigo  int  primary key identity not null,
  Descricao varchar(30) not null,
  preco  numeric (5,2) not null
  );
  
  
INSERT INTO produtos (descricao, preco) 
 VALUES ('Chocolate', '10.5');
INSERT INTO produtos (descricao, preco) 
 VALUES ('Suco', '5');
 
 select*from CLIENTES
 select*from produtos
 select * from CLIENTES where estado Like 'SP%'
 select * from CLIENTES where codigo in (2,4,1)
 select*from CLIENTES order by fone_fixo desc 
select*from produtos order by preco  
Delete from CLIENTES where codigo=3

