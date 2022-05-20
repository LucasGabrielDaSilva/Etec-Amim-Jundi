Create DataBase Clínica
Use Clínica

Create Table Paciente
(cod_paci int identity (1,1)primary key not null,
Nome varchar (100),
CPF bigint,
Data_Nasc date,
Endereco Varchar(120),
Observacoes text)

Insert into Paciente
(Nome, CPF, Data_Nasc, Endereco, Observacoes)
Values
('José da Silva', 12345678910, '28/04/1967', 'Rua do Lucas 126', 'Diagnóstico de Diabetes'),
('Vinicius', 98765432198, '30/11/2005', 'Av Bandeirantes 629', 'Pressão baixa'),
('Lucas Gabriel', 6289416783, '13/04/2006', 'Av Felipe Carmona 1256', 'Sindrome do Panico')

Alter Table Paciente
Add Cidade Varchar(50)

Update Paciente
       Set Cidade= 'Parapuã'
       Where cod_paci=1


Update Paciente
       Set Cidade= 'Rinópolis'
       Where cod_paci=5

Update Paciente
       Set Cidade= 'Osvaldo Cruz'
       Where cod_paci=6

Delete from Paciente
Where cod_paci = 4;

Alter Table Paciente
Alter column Endereco Varchar (60)

Select * from Paciente

alter table Paciente
drop column cpf

Select * from Paciente

sp_rename 'Paciente.Observacoes', 'Historico', 'Column'