CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] varchar(max) NOT NULL,

    CONSTRAINT PK_Status PRIMARY KEY (Id)
)