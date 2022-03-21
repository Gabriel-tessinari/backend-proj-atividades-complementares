CREATE TABLE [dbo].[Conversao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PontuacaoId] int not null,
	[IntervaloInic] int not null,
	[IntervaloFim] int not null,
	[Pontuacao] Decimal(4,2) not null,

    CONSTRAINT PK_Conversao PRIMARY KEY (Id),
	CONSTRAINT FK_Conversao_Pontuacao FOREIGN KEY ([PontuacaoId]) REFERENCES Pontuacao(Id)

)