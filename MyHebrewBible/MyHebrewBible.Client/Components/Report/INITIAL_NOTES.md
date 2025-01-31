# Tech Notes for the Report component

##

## ToDo
- rename `Sections` to `ReportBuilder`
- For the `BookChaper` version, take the `Api` call out of `Sections` and put it `Index.razor`

# Details \ 

## Add a `HebrewParagraph` component as an alternative to `HebrewTable`

## `WordSelected.cs`
- the message body of the "WordSelected" event. 

### Parameters
- **`Strongs`**: the Strongs number is the key that joins the KJV English word with the corresponding Hebrew word
- **`WordCount`**: KJV Word Order

### Used by these components
- **`Card`**: acts as a pass through between following components
- **`Sections`**: is the parent component that holds the state for the selected word and refreshes it when the state changes
- **`ParagraphWithWordButtons`**: contains buttons that a word can be selected from
- **`HebrewTable`**: displays the text and highlights the selected word

```csharp
public record WordSelected(long Strongs, long WordCount);
```

### Extension Possibilities

```csharp
public static class Helper
{
  public static string GetHighlighter(long currentStrongs, long selectedStrongs)
	{
  	return $"{currentStrongs} != 0 && {currentStrongs} == {selectedStrongs} ? 'table-success' : ''";
  }

  public static WordSelected Initialize() => new WordSelected(0, 0);

}
```

See also `Record-extensions-using-a-base-record.md`

---

<!-- 
Ignore Spelling: Strongs, csharp
-->

## TitleSubtitle

		ToDo: Still having problems syncing the navbar, title etc. with the actual chapter being shown; 
    maybe only during slow internet connection 