USE InLock_Games_Tarde;

SELECT * FROM Usuarios;

SELECT * FROM TipoUsuarios;

SELECT * FROM Estudios;

SELECT * FROM Jogos;

SELECT NomeJogo, Estudios.NomeEstudio
FROM Jogos
INNER JOIN Estudios ON Estudios.IdEstudio = Jogos.IdEstudio;

SELECT NomeEstudio, Jogos.NomeJogo
FROM Estudios
LEFT JOIN Jogos ON Jogos.IdEstudio = Estudios.IdEstudio;

SELECT * FROM Usuarios
WHERE Email = 'cliente@cliente.com' AND Senha = 'cliente';

SELECT * FROM Jogos
WHERE IdJogo = 1;

SELECT * FROM Estudios
WHERE IdEstudio = 3;