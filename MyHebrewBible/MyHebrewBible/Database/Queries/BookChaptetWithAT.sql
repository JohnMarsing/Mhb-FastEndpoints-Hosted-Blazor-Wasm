-- DECLARE @BookId int =39,  @Chapter int=4

SELECT ID, BCV, Verse, VerseOffset, KJV, DescH, DescD  
FROM Scripture
--WHERE BookID=@BookId and Chapter=@Chapter
WHERE BookID=39 and Chapter=4
ORDER BY ID

SELECT Id, BCV, BookID, Chapter, Verse
, ScriptureID, WordCount, SegmentCount, WordEnum
, Hebrew1, Hebrew2, Hebrew3
, KjvWord, Strongs, Transliteration, FinalEnum
--, HasTwo
FROM vwAlephTavVerseWordPart
--WHERE BookID=@BookId and Chapter=@Chapter
WHERE BookID=39 and Chapter=4
ORDER BY Id