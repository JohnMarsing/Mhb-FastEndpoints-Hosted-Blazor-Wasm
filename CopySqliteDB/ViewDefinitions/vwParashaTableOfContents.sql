CREATE VIEW vwParashaTableOfContents  
AS   
  
/*  
SELECT *   
FROM vwParashaTableOfContents  
WHERE Id=15  
ORDER BY SectionId, RowCnt  
 
*/  
  
SELECT SectionId  
, ROW_NUMBER() OVER (PARTITION BY Id, SectionId ORDER BY SectionId, RowCnt) AS GroupCount  
, BookId, AnnualId, VerseRange, ScriptureID_Beg, ScriptureID_End, Id, RowIdentity, RowCnt  
FROM Triennial;
