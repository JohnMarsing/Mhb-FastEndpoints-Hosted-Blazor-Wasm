CREATE TABLE [Scripture] (
  [Id] int NOT NULL
, [BCV] text NOT NULL
, [BookID] int NOT NULL
, [Chapter] int NOT NULL
, [Verse] int NOT NULL
, [KJV] text NOT NULL
, [VerseOffset] text NULL
, [DescH] text NULL
, [DescD] text NULL
, [DescHSlug] text NULL
, CONSTRAINT [sqlite_master_PK_Scripture] PRIMARY KEY ([Id])
);
CREATE UNIQUE INDEX [Scripture_sqlite_autoindex_Scripture_2] ON [Scripture] ([BCV] ASC);
CREATE UNIQUE INDEX [Scripture_sqlite_autoindex_Scripture_1] ON [Scripture] ([Id] ASC);
