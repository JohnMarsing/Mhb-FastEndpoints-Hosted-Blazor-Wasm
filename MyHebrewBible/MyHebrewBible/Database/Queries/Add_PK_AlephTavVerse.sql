/*
-- SQLite add primary key to existing table


CREATE TABLE AlephTavVerseNew (
  ScriptureID bigint PRIMARY KEY NOT NULL
, Verse nvarchar(50) NOT NULL COLLATE NOCASE
, CommentsMD nvarchar(500) NULL COLLATE NOCASE
, HasTwo bigint NOT NULL
, CONSTRAINT [FK_AlephTavVerse_Scripture] FOREIGN KEY (ScriptureID) REFERENCES Scripture (ID) ON DELETE NO ACTION ON UPDATE NO ACTION
);

INSERT INTO AlephTavVerseNew 
      (ScriptureID, Verse, CommentsMD, HasTwo)
SELECT ScriptureID, Verse, CommentsMD, HasTwo 
FROM AlephTavVerse
ORDER BY ScriptureID;

SELECT * FROM AlephTavVerseNew

ALTER TABLE AlephTavVerse RENAME TO AlephTavVerse_backup;
ALTER TABLE AlephTavVerseNEW RENAME TO AlephTavVerse;

--DROP TABLE AlephTavVerse_backup;

*/



