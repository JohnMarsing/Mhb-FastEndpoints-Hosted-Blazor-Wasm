CREATE TABLE [AlephTavVerseWordPart] (
  [Id] int NOT NULL PRIMARY KEY
, [ScriptureID] int NOT NULL
, [WordCount] int NOT NULL
/*
, CONSTRAINT [FK_AlephTavVerseWordPart_0_0] FOREIGN KEY ([ScriptureID], [WordCount]) REFERENCES [WordPart] ([ScriptureID], [WordCount]) ON DELETE NO ACTION ON UPDATE NO ACTION
, CONSTRAINT [FK_AlephTavVerseWordPart_1_0] FOREIGN KEY ([ScriptureID]) REFERENCES [Scripture] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
*/
);
/*
CREATE TRIGGER [fki_AlephTavVerseWordPart_ScriptureID_Scripture_ID] BEFORE Insert ON [AlephTavVerseWordPart] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table AlephTavVerseWordPart violates foreign key constraint FK_AlephTavVerseWordPart_Scripture') WHERE (SELECT [ID] FROM Scripture WHERE  [ID] = NEW.[ScriptureID]) IS NULL; END;
CREATE TRIGGER [fku_AlephTavVerseWordPart_ScriptureID_Scripture_ID] BEFORE Update ON [AlephTavVerseWordPart] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table AlephTavVerseWordPart violates foreign key constraint FK_AlephTavVerseWordPart_Scripture') WHERE (SELECT [ID] FROM Scripture WHERE  [ID] = NEW.[ScriptureID]) IS NULL; END;
CREATE TRIGGER [fki_AlephTavVerseWordPart_ScriptureID_WordPart_ScriptureID] BEFORE Insert ON [AlephTavVerseWordPart] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Insert on table AlephTavVerseWordPart violates foreign key constraint FK_AlephTavVerseWordPart_WordPart') WHERE (SELECT [ScriptureID], [WordCount] FROM WordPart WHERE  [ScriptureID] = NEW.[ScriptureID] AND [WordCount] = NEW.[WordCount]) IS NULL; END;
CREATE TRIGGER [fku_AlephTavVerseWordPart_ScriptureID_WordPart_ScriptureID] BEFORE Update ON [AlephTavVerseWordPart] FOR EACH ROW BEGIN SELECT RAISE(ROLLBACK, 'Update on table AlephTavVerseWordPart violates foreign key constraint FK_AlephTavVerseWordPart_WordPart') WHERE (SELECT [ScriptureID], [WordCount] FROM WordPart WHERE  [ScriptureID] = NEW.[ScriptureID] AND [WordCount] = NEW.[WordCount]) IS NULL; END;
*/