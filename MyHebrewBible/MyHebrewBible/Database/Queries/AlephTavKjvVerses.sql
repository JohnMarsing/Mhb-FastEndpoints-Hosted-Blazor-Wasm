--DECLARE  @BookId int=1,  @Chapter int=17
-- FWIW Gen 17:8 has two SAT
SELECT  s.ID, s.BCV, s.Verse, s.VerseOffset, s.KJV, s.DescH, s.DescD  
FROM Scripture s
	INNER JOIN AlephTavVerse atv ON s.Id=atv.ScriptureID
--WHERE s.BookID=@BookId and s.Chapter=@Chapter
WHERE s.BookID=1 and s.Chapter=17
ORDER BY s.ID
