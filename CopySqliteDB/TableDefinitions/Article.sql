CREATE TABLE [Article] (
  [Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [FileNameNoExt] nvarchar(255) NOT NULL COLLATE NOCASE
, [Title] nvarchar(255) NOT NULL COLLATE NOCASE
, [Uri] nvarchar(255) NULL COLLATE NOCASE
, [Details] ntext NULL
, [DetailsMD] ntext NULL
, [PrimaryScriptureId] int DEFAULT (31192) NOT NULL
, [CreateDate] datetime NOT NULL
, [DocBlobID] int NULL
, [PdfBlobID] int NULL
, [IsPlaceHolder] bit NOT NULL
, [IsFavorite] bit NOT NULL
, [ExtraVerses] int DEFAULT (0) NOT NULL
, [IsWordStudy] bit NOT NULL
, [IsParasha] bit NOT NULL
, CONSTRAINT [FK_Article_0_0] FOREIGN KEY ([PrimaryScriptureId]) REFERENCES [Scripture] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TRIGGER [fki_Article_PrimaryScriptureId_Scripture_ID] BEFORE Insert ON [Article] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table Article violates foreign key constraint FK_Article_Scripture') WHERE (SELECT [ID] FROM Scripture WHERE  [ID] = NEW.[PrimaryScriptureId]) IS NULL; END;
CREATE TRIGGER [fku_Article_PrimaryScriptureId_Scripture_ID] BEFORE Update ON [Article] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table Article violates foreign key constraint FK_Article_Scripture') WHERE (SELECT [ID] FROM Scripture WHERE  [ID] = NEW.[PrimaryScriptureId]) IS NULL; END;
