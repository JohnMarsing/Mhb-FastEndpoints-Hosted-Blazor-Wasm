CREATE VIEW vwTableRowCount
AS   
  
/*  
SELECT * FROM vwTableRowCount  

DROP VIEW vwTableRowCount

*/  
       SELECT count(*) AS RowCnt, 'AlephTavVerse'         AS Name FROM AlephTavVerse         --    612
UNION  SELECT count(*) AS RowCnt, 'AlephTavVerseWordPart' AS Name FROM AlephTavVerseWordPart --  3,165
UNION  SELECT count(*) AS RowCnt, 'Article'               AS Name FROM Article               --    630
UNION  SELECT count(*) AS RowCnt, 'JotAndTittle'          AS Name FROM JotAndTittle          --     74
UNION  SELECT count(*) AS RowCnt, 'Mitzvot'               AS Name FROM Mitzvot               --    645  
UNION  SELECT count(*) AS RowCnt, 'Scripture'             AS Name FROM Scripture             --    31102
UNION  SELECT count(*) AS RowCnt, 'Triennial'             AS Name FROM Triennial             --    580
UNION  SELECT count(*) AS RowCnt, 'WordPart'              AS Name FROM WordPart              -- 304,574
UNION  SELECT count(*) AS RowCnt, 'WordPartKjv'           AS Name FROM WordPartKjv           -- 322,350