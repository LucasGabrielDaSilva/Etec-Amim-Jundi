create database Federa��o

use Federa��o

create table times

(
Cod_time int primary key not null,
Nome varchar(40),
Data_De_Fundacao int,
Mascote varchar(50)
)

select * from times

insert into times
(Cod_time, Nome, Data_De_Fundacao, Mascote)

values 
(1, 'BOTA', '1918', 'Manequinho'),
(2, 'COR', '1910', 'Gavi�o'),
(3, 'PAL', '1914', 'Porco'),
(4, 'SAN', '1908', 'Baleia'),
(5, 'S�O', '1930', 'Velinho'),
(6, 'INTER', '1913', 'Le�o'),
(7, 'GUARANI', '1911', 'Bugre'),
(8, 'GR�MIO', '2001', 'Tigre')

select * from times

 EXEC sp_rename 'Equipes', 'Times'; //ALTERA NOME DA TABLEA
 
 select * from INFORMATION_SCHEMA.TABLES//Mostra todas as tabelas
 
 ALTER TABLE Times //adiciona colunas na tabela
 add hino Text
 
 ALTER TABLE Times
 ALter Column Nome varchar(80) //Altera o modo da coluna 
 
 
 