USE InLock_Games_Tarde;

INSERT INTO Estudios (NomeEstudio)
VALUES ('Blizzard'), ('Rockstar Studios'), ('Square Enix');

INSERT INTO Jogos (NomeJogo, Descricao, DataLancamento, Valor, IdEstudio)
VALUES ('Diablo III', '� um jogo que cont�m bastante a��o e � viciante, seja voc� um novato ou um f�.', '15/05/2012', 99, 1),
('Red Dead Redemption II', '� um jogo eletr�nico de a��o-aventura western desenvolvido pela Rockstar Studios.', '26/10/2018', 120, 2);

INSERT INTO TipoUsuarios (TituloTipoUsuario) 
VALUES ('Administrador'), ('Cliente');

INSERT INTO Usuarios (Email, Senha, IdTipoUsuario)
VALUES ('admin@admin.com', 'admin', 1), ('cliente@cliente.com', 'cliente', 2);