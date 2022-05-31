-- Primeiro Rodar
Create DATABASE HorasDB


-- Depois Rodar
Use HorasDB

Create table [dbo].[Area](
    Id INT IDENTITY(1,1) NOT NULL,
    Name VARCHAR(MAX) NOT NULL

    CONSTRAINT PK_Area PRIMARY KEY (Id)
)

Create table [dbo].[Curso](
    Id INT IDENTITY(1,1) NOT NULL,
    Name VARCHAR(MAX) NOT NULL,
	PontuacaoMin Decimal(4, 2) Not null,
	AreaId int NOT null

    CONSTRAINT PK_Curso PRIMARY KEY (Id)
    CONSTRAINT FK_Curso_Area FOREIGN KEY (AreaId) REFERENCES Area(Id)
)

CREATE TABLE [dbo].[Aluno](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Matricula] [int] NOT NULL,
	[Nome] [varchar](Max) NOT NULL,
    CursoId [int] NOT NULL

    CONSTRAINT PK_Aluno PRIMARY KEY (Id),
    CONSTRAINT FK_Aluno_Curso FOREIGN KEY (CursoId) REFERENCES Curso(Id)
)

CREATE TABLE [dbo].[GrupoAtividades](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](Max) NOT NULL,

    CONSTRAINT PK_GrupoAtividades PRIMARY KEY (Id),
)

CREATE TABLE [dbo].[Atividades](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] varchar(max) NOT NULL,
	[GrupoAtividadesId] int not null,
	[ConverterHoras] bit not null

    CONSTRAINT PK_Atividades PRIMARY KEY (Id),
	CONSTRAINT FK_Atividades_GrupoAtividades FOREIGN KEY (GrupoAtividadesId) REFERENCES GrupoAtividades(Id),
)


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


CREATE TABLE [dbo].[Conversao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PontuacaoId] int not null,
	[IntervaloInic] int not null,
	[IntervaloFim] int not null,
	[Pontuacao] Decimal(4,2) not null,

    CONSTRAINT PK_Conversao PRIMARY KEY (Id),
	CONSTRAINT FK_Conversao_Pontuacao FOREIGN KEY ([PontuacaoId]) REFERENCES Pontuacao(Id)
)

CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] varchar(max) NOT NULL,

    CONSTRAINT PK_Status PRIMARY KEY (Id)
)

CREATE TABLE [dbo].[HorasComplementares](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlunoId] int not null,
	[PontuacaoId] int not null,
	[Certificado] varchar(max) not null,
	[StatusId] int not null,
	[Observacao] varchar(max),
	[Horas] int not null,
	[Data] DATETIME NOT NULL,
	[Descricao] varchar(max)

    CONSTRAINT PK_HorasComplementares PRIMARY KEY (Id),
	CONSTRAINT FK_HorasComplementares_Aluno FOREIGN KEY ([AlunoId]) REFERENCES Aluno(Id),
	CONSTRAINT FK_HorasComplementares_Pontuacao FOREIGN KEY ([PontuacaoId]) REFERENCES Pontuacao(Id),
	CONSTRAINT FK_HorasComplementares_Status FOREIGN KEY ([StatusId]) REFERENCES [Status](Id),
)
