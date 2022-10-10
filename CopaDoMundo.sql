Create database CopaDoMundo
go
Use CopaDoMundo
go
alter table Area
alter column IDArea int not null
go
alter table Torcedor
alter column IDTor int not null
go
alter table Alocacao
alter column IDArea int not null
go
alter table Alocacao
alter column IDTor int not null
go
alter table Alocacao
add PRIMARY KEY (IDArea, IDTor)
go
alter table Area
add PRIMARY KEY (IDArea)
go
alter table Torcedor
add PRIMARY KEY (IDArea)
go
alter table Alocacao
Add foreign key (IDArea) references Area(IDArea)
go
alter table Torcedor
Add foreign key (IDTor) references Torcedor(IDTor)
go
select a.IDArea as IDAreaArea, al.IDArea as IDAreaAlocacao, a.ValorIngresso as 'Valor do Ingresso', al.IDTor as IDTorcedor from alocacao al
right join area a on al.IDArea = a.IDArea
go
Create View AreaQtd as
select a.IDArea as IDAreaArea, COUNT(al.IDArea) as Qtd from alocacao al
right join area a on al.IDArea = a.IDArea
group by a.IDArea
select * from AreaQtd