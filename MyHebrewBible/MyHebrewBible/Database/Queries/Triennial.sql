SELECT s.ID, t.SectionId
--, t.RowCnt
, t.GroupCount
, t.VerseRange
, s.BCV, s.BookID, s.Chapter, s.Verse
, s.KJV --, s.VerseOffset, s.DescH, s.DescD
--, ScriptureID_Beg, ScriptureID_End
--, BookId, AnnualId, RowIdentity
FROM  Scripture s
CROSS JOIN vwParashaTableOfContents t 
--Triennial t
--wHERE t.Id = @TriennialId  AND s.ID BETWEEN ScriptureID_Beg AND ScriptureID_End
wHERE t.Id = 15  AND s.ID BETWEEN ScriptureID_Beg AND ScriptureID_End
ORDER BY s.ID -- t.SectionId, t.RowCnt

SELECT 
SectionId
--, RowCnt
, ROW_NUMBER() OVER (PARTITION BY SectionId ORDER BY RowCnt) AS GroupCount
, VerseRange
, ScriptureID_Beg, ScriptureID_End
--, BookId, AnnualId, RowIdentity
FROM Triennial
wHERE Id = 15
ORDER BY SectionId, RowCnt
