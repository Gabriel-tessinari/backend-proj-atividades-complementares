CREATE TABLE [dbo].[Conversao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PontuacaoId] int not null,
	[IntervaloInic] time not null,
	[IntervaloFim] time not null,
	[Pontuacao] Decimal(2,2) not null,

    CONSTRAINT PK_Conversao PRIMARY KEY (Id),
	CONSTRAINT FK_Conversao_Pontuacao FOREIGN KEY ([PontuacaoId]) REFERENCES Pontuacao(Id)

)
