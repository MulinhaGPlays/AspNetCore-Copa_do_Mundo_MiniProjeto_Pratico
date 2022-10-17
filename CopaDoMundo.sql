CREATE DATABASE CopaDoMundo
go
USE CopaDoMundo
go
CREATE TABLE Area 
( 
 IDArea INT PRIMARY KEY,  
 ValorIngresso FLOAT,  
)

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