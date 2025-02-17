CREATE TABLE [WordPartKjv] (
  [ScriptureID] int NOT NULL
, [WordCount] tinyint NOT NULL
, [Strongs] int NULL
, [Word] nvarchar(70) NULL COLLATE NOCASE
, CONSTRAINT [sqlite_autoindex_WordPartKjv_1] PRIMARY KEY ([ScriptureID],[WordCount])
);
