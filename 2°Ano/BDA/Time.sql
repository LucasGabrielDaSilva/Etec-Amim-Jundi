Create DataBase Confedera��o
Use Confedera��o

Create Table Times 
(Cod_Times int primary key not null,
Nome_Times Varchar(50),
Data_Funda��o Date,
Mascote Varchar(25)
)

Select *From Times

Insert into Times(Cod_Times, Nome_Times, Data_Funda��o, Mascote)
values
(1, 'Vasco', 15/02/1888, 'Barco'),
(2, 'Corinthians', 15/04/1933, 'Bandeira'),
(3, 'S�o Paulo', 20/06/1750, 'Bandeira'),
(4, 'Palmeiras', 08/10/1966, 'Porco'),
(5, 'Barcelona', 29/12/1999, 'Paris'),
(6, 'Real Madrid', 18/09/2000, 'Trofeu'),
(7 , 'Santos', 01/01/1900, 'Peixe'),
(8, 'Atletico Mineiro', 07/06/1888, 'Minas')

Create Table Jogadores (
cod_joga int primary key not null,
Nome Varchar (50),
Estado_de_nascimento Varchar (30),
Posi��o int
)

Insert into Jogadores (cod_joga, Nome, Estado_de_nascimento, Posi��o)
Values
(1, 'Lucas Jesus', 'MG', 24),
(2, 'Matheus Junior', 'SP', 4),
(3, 'Marco Malagueta', 'RJ', 5),
(4, 'Kaique Junior2', 'BA', 6),
(5, 'Cristiane', 'Sp', 7),
(6, 'Eduardo Henrique', 'Sp', 8)

Create Table Arbitragem (
Cod_Juiz int primary key not null,
Nome Varchar(30),
Endereco Varchar (50),
RG Varchar(10),
CPF Varchar(13)
)
Insert into Arbitragem (Cod_Juiz, Nome, Endere�o, RG, CPF)
Values (1, 'Vinicius','Rua J�ao', '656632587', '25478325963'),
(2,''Jo)


Create Table Estadios(
Cod_Estadio int primary key not null,
Nome_Estadio Varchar(50),
Cidade Varchar (50),
Estado Varchar (2)
)

Insert into Estadios (Cod_Estadio,Nome_Estadio,Cidade,Estado)
Valeus 
(1,'Maracan�','Rio de Janeiro','RJ'),
(2, 'Morumbi', 'S�o Paulo', 'SP'),
(3, 'Arena do Gr�mio', 'Porto Alegre', 'RS'),
(4,'Pitua�u', 'Salvador', 'BA'),
(5, 'Amig�o','Campo Grande', 'PB')




