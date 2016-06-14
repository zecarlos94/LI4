USE Interrail;

INSERT INTO Relatorio (Id, Data, Titulo, Tipo, fk_Utilizador)
VALUES (1, convert(datetime,'18-06-12 10:34:09 PM', 5), 'Visita a não sei onde', 0, 'a70443@alunos.uminho.pt'),
       (2, convert(datetime,'18-06-12 10:34:09 PM', 5), 'Outra visita', 0, 'a70443@alunos.uminho.pt'),
	   (3, convert(datetime,'18-06-12 10:34:09 PM', 5), 'Hello', 0, 'a71223@alunos.uminho.pt'),
	   (4, convert(datetime,'18-06-12 10:34:09 PM', 5), 'Ching-chong visita a Marrocos', 0, 'a72223@alunos.uminho.pt');