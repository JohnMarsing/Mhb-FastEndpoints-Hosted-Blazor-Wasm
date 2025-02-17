CREATE VIEW vwTableRowCount
AS   
  
/*  
SELECT * FROM vwTableRowCount  

DROP VIEW vwTableRowCount

*/  

SELECT
(SELECT count(*) FROM AlephTavVerse)           AS AlephTavVerseCnt,          --    612
(SELECT count(*) FROM AlephTavVerseWordPart)   AS AlephTavVerseWordPartCnt,  --  3,165
(SELECT count(*) FROM Article)                 AS ArticleCnt,                --    630
(SELECT count(*) FROM JotAndTittle)            AS JotAndTittleCnt,           --     74
(SELECT count(*) FROM Mitzvot)                 AS MitzvotCnt,                --    645  
(SELECT count(*) FROM WordPart)                AS WordPartCnt,               -- 304,574
(SELECT count(*) FROM WordPartKjv)             AS WordPartKjvCnt;            -- 322,350
