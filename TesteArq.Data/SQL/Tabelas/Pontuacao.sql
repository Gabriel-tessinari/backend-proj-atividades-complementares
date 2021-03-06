CREATE TABLE [dbo].[Pontuacao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Pontos] Decimal(4, 2) NULL,
	[NumeroMaximo] [int] NOT NULL,
	[AtividadeId] [int] NOT NULL,
	[CursoId] [int] NOT NULL,

	CONSTRAINT [PK_Pontuacao] PRIMARY KEY (Id),
	CONSTRAINT FK_Pontuacao_Atividade FOREIGN KEY ([AtividadeId]) REFERENCES Atividades(Id),
	CONSTRAINT FK_Pontuacao_Curso FOREIGN KEY ([CursoId]) REFERENCES Curso(Id),
)