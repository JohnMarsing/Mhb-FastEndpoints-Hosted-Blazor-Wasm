SELECT
at.Verse
, wp.ScriptureID, wp.WordCount, wp.SegmentCount, wp.WordEnum
, wp.Hebrew1, wp.Hebrew2, wp.Hebrew3
, wp.KjvWord, wp.Strongs, wp.Transliteration, wp.FinalEnum
FROM WordPart wp 
INNER JOIN AlephTavVerse at ON wp.ScriptureID=at.ScriptureID
--WHERE wp.ScriptureID=1
ORDER BY wp.ScriptureID, wp.WordCount, wp.SegmentCount
LIMIT 20