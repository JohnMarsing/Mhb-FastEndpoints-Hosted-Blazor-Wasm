CREATE TABLE [WordPart] (
  [ScriptureID] int NOT NULL
, [WordCount] int NOT NULL
, [SegmentCount] int NOT NULL
, [WordEnum] int NULL
, [Hebrew1] nvarchar(30) NOT NULL COLLATE NOCASE
, [Hebrew2] nvarchar(30) NULL COLLATE NOCASE
, [Hebrew3] nvarchar(30) NULL COLLATE NOCASE
, [KjvWord] nvarchar(100) NULL COLLATE NOCASE
, [Strongs] int NULL
, [Transliteration] nvarchar(30) NULL COLLATE NOCASE
, [FinalEnum] int NULL
, CONSTRAINT [sqlite_autoindex_WordPart_1] PRIMARY KEY ([ScriptureID],[WordCount])
);
