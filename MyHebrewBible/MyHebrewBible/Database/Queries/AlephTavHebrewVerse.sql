﻿-- private const string alephTavHebrewVerseSelect
SELECT 
	s.Id AS ScriptureID, s.BCV, s.Chapter, s.Verse, wp.WordCount, wp.WordEnum
, wp.Hebrew1, wp.Hebrew2, wp.Hebrew3, wp.KjvWord, wp.Strongs, wp.Transliteration, wp.FinalEnum
, atv.HasTwo
FROM WordPart wp 
	INNER JOIN AlephTavVerse atv 
		ON wp.ScriptureID = atv.ScriptureID 
	INNER JOIN Scripture s 
		ON wp.ScriptureID = s.ID
WHERE BookID=1
ORDER BY wp.ScriptureID, wp.WordCount