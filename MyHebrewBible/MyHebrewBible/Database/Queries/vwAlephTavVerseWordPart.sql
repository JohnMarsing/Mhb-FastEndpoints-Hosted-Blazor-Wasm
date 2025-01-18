CREATE VIEW vwAlephTavVerseWordPart
AS 

/*
SELECT * 
FROM vwAlephTavVerseWordPart
WHERE BookID=2 AND Chapter=20
ORDER BY Id



SELECT 
at.Verse
, at.HasTwo
, atwp.*
FROM AlephTavVerse at
  INNER JOIN vwAlephTavVerseWordPart atwp
    ON at.ScriptureID=atwp.ScriptureID
WHERE at.ScriptureID=1
--WHERE BookID=1 AND Chapter=14
ORDER BY Id

SELECT * FROM vwAlephTavVerseWordPart 
WHERE BookID=1 AND Chapter=2
ORDER BY Id


SELECT * FROM vwAlephTavVerseWordPart 
WHERE BookID=1 AND Chapter=14
ORDER BY Id

SELECT Id, BCV, BookID, Chapter
, ScriptureID, WordCount, SegmentCount, WordEnum
, Hebrew1, Hebrew2, Hebrew3
, KjvWord, Strongs, Transliteration, FinalEnum
FROM vwAlephTavVerseWordPart
ORDER BY Id

--DROP VIEW vwAlephTavVerseWordPart

*/

SELECT 
atwp.Id, s.BCV, s.BookID, s.Chapter, s.Verse
, wp.ScriptureID, wp.WordCount, wp.SegmentCount, wp.WordEnum, wp.Hebrew1, wp.Hebrew2, wp.Hebrew3, wp.KjvWord, wp.Strongs, wp.Transliteration, wp.FinalEnum
FROM WordPart wp
  INNER JOIN AlephTavVerseWordPart atwp
    ON wp.ScriptureID=atwp.ScriptureID AND wp.WordCount=atwp.WordCount
  INNER JOIN Scripture s 
    ON atwp.ScriptureID = s.Id
    
    