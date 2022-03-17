Create table [dbo].[Curso](
    Id INT IDENTITY(1,1) NOT NULL,
    Name VARCHAR(MAX) NOT NULL,
	AreaId int NOT null

    CONSTRAINT PK_Curso PRIMARY KEY (Id)
    CONSTRAINT FK_Curso_Area FOREIGN KEY (AreaId) REFERENCES Area(Id)
)