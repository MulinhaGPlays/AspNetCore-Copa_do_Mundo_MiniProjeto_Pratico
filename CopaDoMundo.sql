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
create view AreaAlocacao
as
select a.*,al.idTor from Area a
left join Alocacao al
on a.IDArea=al.IDArea
go
create view TorcedorAlocado
as
select t.*,al.* from Torcedor t
left join Alocacao al
on t.IDTor=al.IDArea