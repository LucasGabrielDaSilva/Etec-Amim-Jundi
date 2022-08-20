create database BDAULA

use BDAULA
 

create table Aluno
(ID_aluno int primary key not null,
Nome varchar(70) not null,
Telefone varchar(12) not null,
Email varchar(70) not null)

create table Professores
(id_prof int primary key not null,
nome Varchar (70) not null, 
RG Varchar (9) not null,
CPF bigint not null,
Endereço Varchar(50) not null,
Numero Varchar (6) not null,
Bairro Varchar (40)not null
)
Create Table Curso
(id_curso int primary key not null,
Nome Varchar (80) not null,
CargaHorario int not null,
Conteudo text not null)



select * from Curso
select * from Aluno
select * from Professores

