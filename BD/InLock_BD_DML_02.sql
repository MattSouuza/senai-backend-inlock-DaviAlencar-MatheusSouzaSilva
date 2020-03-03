USE InLock_Games_Tarde;

INSERT INTO Estudios (NomeEstudio)
VALUES ('Blizzard'), ('Rockstar Studios'), ('Square Enix');

INSERT INTO Jogos (NomeJogo, Descricao, DataLancamento, Valor, IdEstudio)
VALUES ('Diablo III', 'É um jogo que contém bastante ação e é viciante, seja você um novato ou um fã.', '15/05/2012', 99, 1),
('Red Dead Redemption II', 'É um jogo eletrônico de ação-aventura western desenvolvido pela Rockstar Studios.', '26/10/2018', 120, 2);

INSERT INTO TipoUsuarios (TituloTipoUsuario) 
VALUES ('Administrador'), ('Cliente');

INSERT INTO Usuarios (Email, Senha, IdTipoUsuario)
VALUES ('admin@admin.com', 'admin', 1), ('cliente@cliente.com', 'cliente', 2);