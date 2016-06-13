USE Interrail;

INSERT INTO Local (Id, Descricao, Coordenadas, Cidade, Pais)
VALUES (1, 'Torre Eiffel', geography::STGeomFromText('LINESTRING(48 51.30, 2 17.40)', 4326), 'Paris', 'France'),
	   (2, 'National Monument', geography::STGeomFromText('LINESTRING(52 22.22, 4 53.37)', 4326), 'Amsterdam', 'The Netherlands'),
	   (3, 'Anne Frank House', geography::STGeomFromText('LINESTRING(52.37 0.0, 4.88 0.0)', 4326), 'Amsterdam', 'The Netherlands'),
	   (4, 'The Motherland Calls', geography::STGeomFromText('LINESTRING(48 44.33, 44 32.13)', 4326), 'Volgograd', 'Russia'),
	   (5, 'Obelisk of Glory', geography::STGeomFromText('LINESTRING(53 30.48, 49 24.34)', 4326), 'Tolyatti', 'Russia'),
	   (6, 'Siegestor', geography::STGeomFromText('LINESTRING(48 09.08, 11 34.55)', 4326), 'Munich', 'Germany'),
	   (7, 'Coleseum', geography::STGeomFromText('LINESTRING(41 53.24, 12 29.32)', 4326), 'Rome', 'Italy');

