
SELECT at.ScriptureID, at.Detail, s.BCV, s.BookID, s.Chapter
, wp.WordCount, wp.WordEnum, wp.Hebrew1, wp.Hebrew2, wp.Hebrew3 
--, wp.KjvWord, wp.SegmentCount
FROM WordPart wp
INNER JOIN AlephTav at ON wp.ScriptureID = at.ScriptureID AND wp.WordCount = at.Word
INNER JOIN Scripture s ON wp.ScriptureID = s.ID

--SELECT ScriptureID, Detail, Word FROM AlephTav;
--SELECT * FROM WordPart LIMIT 10