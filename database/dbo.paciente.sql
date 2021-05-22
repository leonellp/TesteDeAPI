CREATE TABLE [dbo].[Table]
(
	[Idpaciente] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Nome] VARCHAR(200) NOT NULL, 
    [Sexo] CHAR NOT NULL,
	[Nascimento] date NOT NULL,
	[Inativo] date NULL,
	[Celular] varchar(14) NULL
)
