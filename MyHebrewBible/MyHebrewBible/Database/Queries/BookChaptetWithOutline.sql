SELECT ID, BCV, DescH, DescD, KJV
--, Verse, VerseOffset,   
FROM Scripture
--WHERE BookID=@BookId and Chapter=@Chapter
WHERE BookID=2 and Chapter=20 AND DescD != 'NULL'
ORDER BY ID