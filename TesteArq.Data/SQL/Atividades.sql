CREATE TABLE [dbo].[Atividades](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GrupoAtividadesId] int not null,
	[ConverterHoras] bit not null

    CONSTRAINT PK_Atividades PRIMARY KEY (Id),
	CONSTRAINT FK_Atividades_GrupoAtividades FOREIGN KEY (GrupoAtividadesId) REFERENCES GrupoAtividades(Id),
)
