Use HorasDB

insert into Area ([Name]) VALUES 
('Tecnologia'), 
('Saude')

Insert into Curso ([Name],[PontuacaoMin], [AreaId]) VALUES 
('Ciencia da Computação', 7, 1), 
('Engenharia da Computação',7, 1), 
('sistema de Informação', 7, 1),
('Medicina',7, 2),
('Enfermagem',7, 2),
('Nutrição',7, 2)


insert into Aluno ([Matricula], [Nome], [CursoId]) VALUES
(20221, 'Aluno 01', 1),
(20222, 'Aluno 02', 1),
(20223, 'Aluno 03', 1),
(20224, 'Aluno 04', 2),
(20225, 'Aluno 05', 2),
(20226, 'Aluno 06', 2),
(20227, 'Aluno 07', 3),
(20228, 'Aluno 08', 3),
(20229, 'Aluno 09', 3),
(202210, 'Aluno 010', 4),
(202211, 'Aluno 011', 4),
(202212, 'Aluno 012', 4),
(202213, 'Aluno 013', 5),
(202214, 'Aluno 014', 5),
(202215, 'Aluno 015', 5),
(202216, 'Aluno 016', 6),
(202217, 'Aluno 017', 6),
(202218, 'Aluno 018', 6)

INSERT Into GrupoAtividades ([Nome]) VALUES
('3.1 Iniciação Científica'),
('3.2 Monitoria'),
('3.3 Extensão')

INSERT into Atividades ([Nome], [GrupoAtividadesId], [ConverterHoras]) VALUES
('Trabalhos desenvolvidos com orientação docente,
apresentados na Instituição (extra sala de aula e extra
disciplina específica), em eventos científicos
específicos ou seminários multidisciplinares (dentre
eles o Inovaweek).', 1, 0),
('Trabalhos desenvolvidos com orientação docente,
apresentados em eventos científicos específicos ou
seminários e publicados em anais, mencionando o
nome da Instituição.
', 1, 0),
('As atividades de monitoria, como bolsista ou
voluntária, em disciplinas pertencentes ao currículo do
seu curso.', 2, 0),
('Organização, coordenação, realização de cursos e/ou
eventos internos ou externos à Instituição, de interesse
desta ou da comunidade.', 3, 0),
('Participação em VISITAS TÉCNICAS. ', 3, 0)

INSERT into Pontuacao ([Pontos], [NumeroMaximo], [AtividadeId], [CursoId]) VALUES
(15.0, 4, 1, 1),
(15.0, 4, 1, 2),
(15.0, 4, 1, 3),
(15.0, 4, 2, 1),
(15.0, 4, 2, 2),
(15.0, 4, 2, 3),
(5.0, 3, 3, 1),
(5.0, 3, 3, 2),
(5.0, 3, 3, 3),
(15.0, 2, 4, 1),
(15.0, 2, 4, 2),
(15.0, 2, 4, 3),
(5.0, 5, 5, 1),
(5.0, 5, 5, 2),
(5.0, 5, 5, 3)

INSERT into [Status] ([Descricao]) VALUES
('Pendente'),
('Recusado'),
('Aprovado')

INSERT into HorasComplementares ([AlunoId], [PontuacaoId], [Certificado], [StatusId],[Observacao], [Horas], [Data])
VALUES
(1,1,'Certificado.JPG', 1, null, 5, '20220401'),
(1,3,'Certificado.JPG', 1, null, 14, '20220402'),
(1,5,'Certificado.JPG', 1, null, 4, '20220403'),
(2,1,'Certificado.JPG', 1, null, 10, '20220404'),
(2,3,'Certificado.JPG', 1, null, 7, '20220405'),
(2,5,'Certificado.JPG', 1, null, 1, '20220406'),
(2,1,'Certificado.JPG', 1, null, 2, '20220407'),
(3,1,'Certificado.JPG', 1, null, 8, '20220401'),
(5,1,'Certificado.JPG', 1, null, 8, '20220402'),
(6,1,'Certificado.JPG', 1, null, 8, '20220403'),
(6,1,'Certificado.JPG', 1, null, 8, '20220404'),
(6,1,'Certificado.JPG', 1, null, 8, '20220405'),
(8,1,'Certificado.JPG', 1, null, 8, '20220410'),
(9,1,'Certificado.JPG', 1, null, 8, '20220412'),
(9,1,'Certificado.JPG', 1, null, 8, '20220413'),
(11,1,'Certificado.JPG', 1, null, 8, '20220417'),
(12,1,'Certificado.JPG', 1, null, 8, '20220415'),
(15,1,'Certificado.JPG', 1, null, 8, '20220420'),
(16,1,'Certificado.JPG', 1, null, 8, '20220416')