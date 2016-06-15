select CAST(GETDATE() as time)
select CAST(GETDATE() as date)

-- pesquisa de imagens por local
select L.Id from dbo.Local as L where L.Descricao like 'o';

select Imagem from dbo.Local as L
	inner join  dbo.Tarefa as T
	on L.Id=T.fk_Local
		inner join dbo.Entrada as E
		on T.Id=E.fk_Tarefa
where L.Coordenadas.STEquals(E.Coordenadas)=1;

-- pesquisa de imagens por data
-- esta a comparar com a data atual
select Imagem from dbo.Tarefa as T
		inner join dbo.Entrada as E
		on T.Id=E.fk_Tarefa
where DATE()= CAST(E.data as date);
-- DATE() is a single date which will be read from textbox