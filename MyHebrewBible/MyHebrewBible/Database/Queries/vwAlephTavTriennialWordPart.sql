CREATE VIEW vwAlephTavTriennialWordPart
AS 

/*

SELECT * 
FROM vwAlephTavTriennialWordPart
--WHERE TriennialId=1 
WHERE TriennialId=8
ORDER BY Id

DROP VIEW vwAlephTavTriennialWordPart

*/

SELECT t.Id AS TriennialId, t.VerseRange AS TriennialVerseRange, atwp.*
FROM vwAlephTavBookChapterWordPart atwp
CROSS JOIN  Triennial t
WHERE atwp.ScriptureID BETWEEN t.ScriptureID_Beg AND t.ScriptureID_End  