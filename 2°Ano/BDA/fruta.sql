Create DataBase Banca

Use Banca



Create Table Frutas
(Cod_Fruta int primary key not null,
Nome_Fruta Varchar(25) not null,
Pre�o money not null,
Fornecedor Varchar(50) not null,
Data_Entrega date not null
)
Select *from Frutas

insert into Frutas
(Cod_Fruta, Nome_Fruta, Pre�o, Fornecedor, Data_Entrega)
values
(2, 'Banana', 1.33, 'S�tio S�o Pedro', '12/03/2088'),
(3, 'Abacate', 2.99, 'S�tio Frederico', '04/02/2088'),
(4 , 'Manga', 3.25, 'S�tio S�o Marcio', '10/05/2088')
(1, 'Melancia', 8.25, 'S�tio S�o Jos�', '08/06/2088'),

Select Nome_Fruta, Pre�o from Frutas 
order by Nome_Fruta, Pre�o desc
Select * from Frutas 
order by Nome_Fruta, Pre�o 

