CREATE DATABASE CopaDoMundo
go
USE CopaDoMundo
go
CREATE TABLE Area 
( 
 IDArea INT PRIMARY KEY,  
 ValorIngresso FLOAT,  
)
go
CREATE TABLE Torcedor 
( 
 IDTor INT PRIMARY KEY,  
 IDNome VARCHAR(max),  
 Idade INT,  
)
go
CREATE TABLE Alocacao 
( 
 IDArea INT,  
 IDTor INT,
 PRIMARY KEY(IDArea, IDTor)
)
go
ALTER TABLE Alocacao ADD FOREIGN KEY(IDArea) REFERENCES Area (IDArea)
ALTER TABLE Alocacao ADD FOREIGN KEY(IDTor) REFERENCES Torcedor (IDTor)
go
Create view AreaAlocacao
as  
SELECT distinct a.IDArea , a.ValorIngresso, count(a.IDArea) as qtd
FROM dbo.Area AS a LEFT OUTER JOIN
dbo.Alocacao AS al ON a.IDArea = al.idArea
group by a.IDArea, a.ValorIngresso
go
create view TorcedorAlocado
as
select t.*,al.IDArea, al.IDTor as toralocado from Torcedor t
left join Alocacao al
on t.IDTor=al.IDArea
go
alter table Alocacao
add alocacaodata datetime default getDate() null