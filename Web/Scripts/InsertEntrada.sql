USE Interrail;

SELECT * FROM Entrada;

INSERT INTO Entrada (Id, Imagem, FicheiroAudio, FicheiroTexto, Nome, Coordenadas, Data, fk_Tarefa)
SELECT 1, BulkColumn, null, null, 'Entrada c/imagem',  geography::STGeomFromText('LINESTRING(52 22.22, 4 53.37)', 4326), convert(datetime,'18-06-12 10:34:09 PM', 5), 1
FROM Openrowset( Bulk 'C:\Users\Tiago\Desktop\water.jpg', Single_Blob) as img

SELECT * FROM Tarefa;

DELETE Entrada;