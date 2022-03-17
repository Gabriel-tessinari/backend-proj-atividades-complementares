CREATE TABLE [dbo].[HorasComplementares](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlunoId] int not null,
	[PontuacaoId] int not null,
	[Certificado] varchar(max) not null,
	[StatusId] int not null,
	[Observacao] varchar(max) not null,
	[Horas] int not null,

    CONSTRAINT PK_HorasComplementares PRIMARY KEY (Id),
	CONSTRAINT FK_HorasComplementares_Aluno FOREIGN KEY ([AlunoId]) REFERENCES Aluno(Id),
	CONSTRAINT FK_HorasComplementares_Pontuacao FOREIGN KEY ([PontuacaoId]) REFERENCES Pontuacao(Id),
	CONSTRAINT FK_HorasComplementares_Status FOREIGN KEY ([StatusId]) REFERENCES [Status](Id),
)