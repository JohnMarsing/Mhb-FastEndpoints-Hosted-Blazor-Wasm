SELECT s.BCV, wp.ScriptureId, wp.WordCount, wp.Strongs
FROM WordPart wp 
INNER JOIN Scripture s ON wp.ScriptureID=s.Id
WHERE wp.Strongs=0
ORDER BY wp.ScriptureID, wp.WordCount	
LIMIT 10