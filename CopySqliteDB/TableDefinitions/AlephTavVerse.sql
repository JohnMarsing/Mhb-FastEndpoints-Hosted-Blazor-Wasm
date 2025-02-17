CREATE TABLE [AlephTavVerse] (
  [ScriptureID] int NOT NULL
, [Verse] nvarchar(50) NOT NULL COLLATE NOCASE
, [CommentsMD] nvarchar(500) NULL COLLATE NOCASE
, [HasTwo] int NOT NULL
, CONSTRAINT [sqlite_autoindex_AlephTavVerse_1] PRIMARY KEY ([ScriptureID])
, CONSTRAINT [FK_AlephTavVerse_0_0] FOREIGN KEY ([ScriptureID]) REFERENCES [Scripture] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
