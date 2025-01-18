CREATE VIEW vwAlephTavTriennialWordPart
AS 

/*

SELECT * 
FROM vwAlephTavTriennialWordPart
--WHERE TriennialId=1 
WHERE TriennialId=8
ORDER BY Id

*/

SELECT t.Id AS TriennialId, t.VerseRange AS TriennialVerseRange, atwp.*
FROM vwAlephTavVerseWordPart atwp
CROSS JOIN  Triennial t
WHERE atwp.ScriptureID BETWEEN t.ScriptureID_Beg AND t.ScriptureID_End  