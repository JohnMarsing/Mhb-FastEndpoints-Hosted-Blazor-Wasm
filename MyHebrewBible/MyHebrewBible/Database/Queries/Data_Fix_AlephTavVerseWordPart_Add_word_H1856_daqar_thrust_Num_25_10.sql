
INSERT INTO AlephTavVerseWordPart( Id, ScriptureID, WordCount)
SELECT  304553, 4480, 7 -- Add, word H1856 daqar thrust Num 25:8 before et- translated as thrut
/*

SELECT MAX(Id) FROM vwAlephTavBookChapterWordPart  -- 304553
SELECT Id FROM AlephTavVerseWordPart ORDER BY ID DESC limit 5

SELECT * 
FROM vwAlephTavBookChapterWordPart
WHERE BookID=4 AND Chapter=25
ORDER BY Id

SELECT atwp.*, s.KJV 
FROM 
AlephTavVerseWordPart atwp 
INNER JOIN Scripture s
    ON atwp.ScriptureID=s.ID
WHERE BookID=4 AND Chapter=25
*/
--limit 100