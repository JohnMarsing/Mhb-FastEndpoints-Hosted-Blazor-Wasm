SELECT s.ID, t.SectionId, t.RowCnt, t.VerseRange
, s.BCV, s.BookID, s.Chapter, s.Verse
, s.KJV --, s.VerseOffset, s.DescH, s.DescD
--, ScriptureID_Beg, ScriptureID_End
--, BookId, AnnualId, RowIdentity
FROM  Scripture s
CROSS JOIN Triennial t 
--wHERE t.Id = @TriennialId  AND s.ID BETWEEN ScriptureID_Beg AND ScriptureID_End
wHERE t.Id = 12  AND s.ID BETWEEN ScriptureID_Beg AND ScriptureID_End
ORDER BY s.ID -- t.SectionId, t.RowCnt

SELECT 
SectionId
, RowCnt
, VerseRange
, ScriptureID_Beg, ScriptureID_End
--, BookId, AnnualId, RowIdentity
FROM Triennial
wHERE Id = 12
ORDER BY SectionId, RowCnt
