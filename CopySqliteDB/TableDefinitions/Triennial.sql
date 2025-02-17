CREATE TABLE [Triennial] (
  [Id] int NOT NULL
, [SectionId] tinyint NOT NULL
, [RowCnt] tinyint NOT NULL
, [BookId] int NOT NULL
, [AnnualId] int NOT NULL
, [VerseRange] nvarchar(50) NOT NULL COLLATE NOCASE
, [ScriptureID_Beg] int NOT NULL
, [ScriptureID_End] int NOT NULL
, [RowIdentity] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
);
CREATE UNIQUE INDEX [Triennial_Triennial_IX_Triennial_Unique] ON [Triennial] ([Id] ASC,[SectionId] ASC,[RowCnt] ASC);
