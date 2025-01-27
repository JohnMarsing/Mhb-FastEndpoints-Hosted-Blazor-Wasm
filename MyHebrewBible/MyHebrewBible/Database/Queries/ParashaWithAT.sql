--DECLARE @TriennialId int =15

SELECT s.ID, t.SectionId, t.RowCnt, t.VerseRange
, s.BCV, s.BookID, s.Chapter, s.Verse, s.VerseOffset, s.KJV, s.DescH, s.DescD
FROM  Scripture s
CROSS JOIN Triennial t 
--WHERE t.Id = @TriennialId AND s.ID BETWEEN ScriptureID_Beg AND ScriptureID_End
WHERE t.Id = 15 AND s.ID BETWEEN ScriptureID_Beg AND ScriptureID_End
ORDER BY s.ID


SELECT Id, BCV, BookID, Chapter, Verse
, ScriptureID, WordCount, SegmentCount, WordEnum
, Hebrew1, Hebrew2, Hebrew3
, KjvWord, Strongs, Transliteration, FinalEnum
FROM vwAlephTavTriennialWordPart v
--WHERE v.TriennialId=@TriennialId
WHERE v.TriennialId=15
ORDER BY Id