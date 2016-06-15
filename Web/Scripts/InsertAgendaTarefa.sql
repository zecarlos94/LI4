USE Interrail;

INSERT INTO Agenda (Id, Imagem, Data, fk_Utilizador) 
VALUES (1, null, convert(datetime,'18-06-12 10:34:09 PM', 5), 'a70443@alunos.uminho.pt'),
       (2, null, convert(datetime,'18-06-12 10:34:09 PM', 5), 'a71223@alunos.uminho.pt');

INSERT INTO Tarefa (Id, Designacao, Data, fk_Agenda, fk_Relatorio, fk_Local)
VALUES (1, 'Tarefa fixe', convert(datetime,'18-06-12 10:34:09 PM', 5), 1, 1, 1),
       (2, 'Fixe', convert(datetime,'18-06-12 10:34:09 PM', 5), 2, 3, 3),
	   (3, 'Crazy task', convert(datetime,'18-06-12 10:34:09 PM', 5), 1, 2, 2);

--DELETE Tarefa;
--DELETE Agenda;
