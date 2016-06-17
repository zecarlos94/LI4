--select Imagem from dbo.Tarefa as T inner join dbo.Entrada as E on T.Id = E.fk_Tarefa where '2010-01-12' = CAST( E.Data as date); 
--select L.Id from dbo.Local as L where L.Descricao like 'Braga';
--select Imagem from dbo.Local as L inner join  dbo.Tarefa as T on 2 = T.fk_Local inner join dbo.Entrada as E on T.Id = E.fk_Tarefa where L.Coordenadas.STEquals(E.Coordenadas) = 1;
--select E.Id from dbo.Tarefa as T inner join dbo.Entrada as E on T.Id = E.fk_Tarefa where '2010-01-12' = CAST( E.Data as date); 
--select E.Id,E.Imagem from dbo.Local as L inner join  dbo.Tarefa as T on 2 = T.fk_Local inner join dbo.Entrada as E on T.Id = E.fk_Tarefa where L.Coordenadas.STEquals(E.Coordenadas) = 1;
--select E.Id,E.Imagem from dbo.Tarefa as T inner join dbo.Entrada as E on T.Id = E.fk_Tarefa;

select E.Id,E.Imagem from dbo.Local as L inner join  dbo.Tarefa as T 
	on (select L.Id from dbo.Local as L where L.Descricao like 'Braga') = T.fk_Local 
	inner join dbo.Entrada as E on T.Id = E.fk_Tarefa where L.Coordenadas.STEquals(E.Coordenadas) = 1  and E.Id='2';

